﻿using System;
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

namespace NewsApp
{
    public partial class NewsApp : Form
    {
        public NewsApp()
        {
            InitializeComponent();
        }

        private string websiteFilePath = "";
        private string articlesFilePath = "";
        List<string> websiteList = new List<string>();
        List<Site> siteList = new List<Site>();

        private void NewsApp_Load(object sender, EventArgs e)
        {
            getSiteList();
            
            //test();
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
        private void readSitesHttpToTabs(TabControl tC)
        {
            HtmlWeb web = new HtmlWeb();
            foreach (string site in websiteList)
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
                        foreach (HtmlNode node in nodes) {
                            if (node.Attributes.Contains("href"))
                            {
                                if (node.Attributes["href"].Value.StartsWith("/")|| node.Attributes["href"].Value.StartsWith("#"))
                                {
                                    tB.AppendText(node.InnerText.Trim().Replace("&quot;", "'").ToLower() + Environment.NewLine + site+node.Attributes["href"].Value.Trim() + Environment.NewLine);
                                    siteList[siteList.Count - 1].articles.Add(new Article(node.InnerText.Trim().Replace("&quot;", "'").ToLower(), site+node.Attributes["href"].Value.Trim()));
                                }
                                else { }
                                tB.AppendText(node.InnerText.Trim().Replace("&quot;", "'").ToLower() + Environment.NewLine + node.Attributes["href"].Value.Trim() + Environment.NewLine);
                                siteList[siteList.Count - 1].articles.Add(new Article(node.InnerText.Trim().Replace("&quot;", "'").ToLower(), node.Attributes["href"].Value.Trim()));
                            }
                        }
                    }
                }
                catch(Exception e)
                {
                    MessageBox.Show("Following error occured: "+Environment.NewLine+e.ToString());
                }
                tP.Controls.Add(tB);
                tC.TabPages.Add(tP);
            }

        }
        private void bttnRun_Click(object sender, EventArgs e)
        {
            if (tbKeyword.Text != "")
            {
                rtbOutput.Text = "";
                string keyword = tbKeyword.Text.Trim().ToLower();
                foreach (Site site in siteList)
                {
                    foreach (Article article in site.articles)
                    {
                        if (article.name.Contains(keyword))
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
            if (tbMailInput.Text != ""&& tbEmailAdress.Text !="" && tbEmailLogin.Text !="" && tbEmailPassword.Text !="")
            {

                try
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp-mail.outlook.com");

                    mail.From = new MailAddress(tbEmailAdress.Text);
                    mail.To.Add(tbMailInput.Text);
                    mail.Subject = "Articles for keyword: "+tbKeyword.Text;
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
            readSitesHttpToTabs(tabControl);
            tbEmailAdress.Enabled = true;
            tbEmailLogin.Enabled = true;
            tbEmailPassword.Enabled = true;
            tbKeyword.Enabled = true;
            tbMailInput.Enabled = true;
            bttnRun.Enabled = true;
            bttnSend.Enabled = true;
            rtbOutput.Enabled = true;
        }
        /*
private void test()
{
const string xpath = "//a";
HtmlWeb web = new HtmlWeb();
List<Site> siteList = new List<Site>();
siteList.Add(new Site("onet"));

HtmlAgilityPack.HtmlDocument document = web.Load("http://www.onet.pl/");
//The following gives you a node collection of your two <a> elements
HtmlNode[] items = document.DocumentNode.SelectNodes(xpath).ToArray();
foreach (HtmlNode a in items)
{
if (a.Attributes.Contains("href"))
//Get your value here
{
siteList[siteList.Count - 1].articles.Add(new Article(a.InnerText.Trim().Replace("&quot;", "'"), a.Attributes["href"].Value));
}
}
foreach(Site site in siteList)
{
foreach(Article article in site.articles)
{
rtbInput.AppendText(article.name + Environment.NewLine + article.link + Environment.NewLine);
}
}
}
*/
    }
}
