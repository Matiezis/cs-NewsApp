using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using HtmlAgilityPack;
using System.Net.Mail;
using System.Web;

namespace NewsApp
{
    public partial class NewsApp : Form
    {
        public NewsApp()
        {
            InitializeComponent();
        }

        private string websiteFilePath = "";
        List<string> websiteList = new List<string>();
        List<Site> siteList = new List<Site>();

        private void NewsApp_Load(object sender, EventArgs e)
        {
            getSiteList();
        }

        private string SelectFile()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            fileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            fileDialog.FilterIndex = 2;
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    return fileDialog.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Nie udało się otworzyć pliku. Original error: " + ex.Message);
                }
            }
            return "";
        }

        private void readSiteList()
        {
            if (File.Exists(websiteFilePath))
            {
                websiteList = new List<string>(File.ReadLines(websiteFilePath));
                for (int i = 0; i < websiteList.Count(); i++)
                    websiteList[i] = websiteList[i].TrimEnd('/');
            }
        }

        private void getSiteList()
        {
            string localDirectory = Directory.GetCurrentDirectory();

            if (File.Exists(localDirectory + "\\sites.txt"))
            {
                websiteFilePath = localDirectory + "\\sites.txt";
            }
            else
                websiteFilePath = SelectFile();

            readSiteList();
            foreach (string site in websiteList)
            {
                rtbInput.AppendText(site + Environment.NewLine);
            }
        }
        private void readSitesHtmlToTabs(TabControl tC)
        {
            if (isInternetConnection())
            {
                HtmlWeb web = new HtmlWeb();
                foreach (string site in websiteList)
                {
                    Uri uriResult;
                    if (Uri.TryCreate(site, UriKind.Absolute, out uriResult)
                        && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps))
                    {
                        string trimmedSiteName = site;

                        if (trimmedSiteName.StartsWith("https://"))
                            trimmedSiteName = trimmedSiteName.Substring("https://".Length);
                        if (trimmedSiteName.StartsWith("http://"))
                            trimmedSiteName = trimmedSiteName.Substring("http://".Length);
                        if (trimmedSiteName.StartsWith("www."))
                            trimmedSiteName = trimmedSiteName.Substring("www.".Length);

                        TabPage tP = new TabPage(trimmedSiteName);
                        siteList.Add(new Site(site));

                        RichTextBox tB = new RichTextBox();
                        tB.Dock = DockStyle.Fill;
                        tB.Multiline = true;
                        tB.ScrollBars = RichTextBoxScrollBars.Vertical;

                        HtmlAgilityPack.HtmlDocument document = web.Load(site);
                        try
                        {
                            if (document.DocumentNode.SelectNodes("//a") != null)
                            {
                                HtmlNode[] nodes = document.DocumentNode.SelectNodes("//a").ToArray();
                                foreach (HtmlNode node in nodes)
                                {
                                    if (node.Attributes.Contains("href"))
                                    {
                                        if (node.Attributes["href"].Value.StartsWith("/") || node.Attributes["href"].Value.StartsWith("#"))
                                        {
                                            tB.AppendText(titleTrimming(node.InnerText) + Environment.NewLine + site + node.Attributes["href"].Value.Trim() + Environment.NewLine);

                                            if (!checkIfAlreadyExists(titleTrimming(node.InnerText), site + node.Attributes["href"].Value.Trim()))
                                                siteList[siteList.Count - 1].articles.Add(new Article(titleTrimming(node.InnerText), site + node.Attributes["href"].Value.Trim()));
                                        }
                                        else
                                        {
                                            tB.AppendText(titleTrimming(node.InnerText) + Environment.NewLine + node.Attributes["href"].Value.Trim() + Environment.NewLine);
                                            if (!checkIfAlreadyExists(titleTrimming(node.InnerText), node.Attributes["href"].Value.Trim()))
                                                siteList[siteList.Count - 1].articles.Add(new Article(titleTrimming(node.InnerText), node.Attributes["href"].Value.Trim()));
                                        }
                                    }
                                }
                            }
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Following error occured: " + Environment.NewLine + e.ToString());
                        }
                        tP.Controls.Add(tB);
                        tC.TabPages.Add(tP);
                    }
                }
            }
        }
        private void bttnRun_Click(object sender, EventArgs e)
        {
            if (tbKeyword.Text != "")
            {
                rtbOutput.Text = "";
                string keyword = titleTrimming(tbKeyword.Text);
                foreach (Site site in siteList)
                {
                    foreach (Article article in site.articles)
                    {
                        if (titleNormalizing(article.name).Contains(titleNormalizing(keyword)))
                        {
                            rtbOutput.AppendText(article.name + Environment.NewLine + article.link + Environment.NewLine);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Input");
            }
        }

        private void bttnSend_Click(object sender, EventArgs e)
        {
            if (tbMailInput.Text != "" && tbEmailAdress.Text != "" && tbEmailLogin.Text != "" && tbEmailPassword.Text != "")
            {
                try
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp-mail.outlook.com");

                    mail.From = new MailAddress(tbEmailAdress.Text);
                    mail.To.Add(tbMailInput.Text);
                    mail.Subject = "Articles for keyword: " + tbKeyword.Text;
                    mail.Body = rtbOutput.Text;

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential(tbEmailLogin.Text, tbEmailPassword.Text);
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);
                    MessageBox.Show("Mail succesfuly sent");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void bttnSearch_Click(object sender, EventArgs e)
        {
            panelCover.Visible = true;
            lblPressSearch.Visible = true;
            MessageBox.Show("Loading. Please wait.");

            tabControl.TabPages.Clear();
            readSitesHtmlToTabs(tabControl);

            tbEmailAdress.Enabled = true;
            tbEmailLogin.Enabled = true;
            tbEmailPassword.Enabled = true;
            tbKeyword.Enabled = true;
            tbMailInput.Enabled = true;
            bttnRun.Enabled = true;
            bttnSend.Enabled = true;
            rtbOutput.Enabled = true;
            lblInsertKeyword.Enabled = true;
            lblInsertKeyword.Text = "Insert the keyword by which you would like to filter the articles";

            panelCover.Visible = false;
            lblPressSearch.Visible = true;
        }
        private string titleTrimming(string title)
        {
            title = HttpUtility.HtmlDecode(title);
            title = title.Trim();
            title = title.Replace("\n", "");
            title = title.Replace("\t", " ");
            while (title.Contains("  "))
                title = title.Replace("  ", " ");
            return title;
        }
        private string titleNormalizing(string title)
        {
            char[] polishSymbols = { 'ą', 'ć', 'ę', 'ł', 'ń', 'ó', 'ś', 'ź', 'ż', };
            char[] polishLetters = { 'a', 'c', 'e', 'l', 'n', 'o', 's', 'z', 'z', };
            title = titleTrimming(title).ToLower();
            for (int i = 0; i < polishSymbols.Length; i++)
                title = title.Replace(polishSymbols[i], polishLetters[i]);
            return title;
        }
        private bool checkIfAlreadyExists(string title, string link)
        {
            foreach (Site site in siteList)
            {
                if (site.articles.Count > 1)
                {
                    foreach (Article article in site.articles)
                    {
                        if (article.name == title && article.link == link)
                        {
                            return true;

                        }
                    }
                }
            }
            return false;
        }

        private void bttnReadFile_Click(object sender, EventArgs e)
        {
            try
            {
                websiteFilePath = SelectFile();
                if (File.Exists(websiteFilePath))
                {
                    rtbInput.Text = "";
                    websiteList = new List<string>(File.ReadLines(websiteFilePath));
                    for (int i = 0; i < websiteList.Count(); i++)
                        websiteList[i] = websiteList[i].TrimEnd('/');
                    foreach (string site in websiteList)
                    {
                        rtbInput.AppendText(site + Environment.NewLine);
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Following error occured: " + Environment.NewLine + ex.ToString());
            }
        }
        private bool isInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (client.OpenRead("http://www.google.com/"))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Could not establish an internet connection.");
                return false;
            }
        }

        private void bttnSaveFile_Click(object sender, EventArgs e)
        {
            try
            {
                websiteFilePath = SelectFile();
                if (File.Exists(websiteFilePath))
                {
                    rtbInput.SaveFile(websiteFilePath, RichTextBoxStreamType.PlainText);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Following error occured: " + Environment.NewLine + ex.ToString());
            }
        }

        private void tbKeyword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
                bttnRun_Click(sender, e);
        }

        private void rtbInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                bttnSaveFile_Click(sender, e);
        }
    }
}
