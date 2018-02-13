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
            readSitesHttpToTabs(tabControl);
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
                string[] splitted = site.Split('.');
                TabPage tP = new TabPage(splitted[splitted.Length - 2]);
                siteList.Add(new Site(splitted[splitted.Length - 2]));

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
                        foreach (HtmlNode a in nodes) { 
                        if (a.Attributes.Contains("href"))
                        //Get your value here
                        {
                                tB.AppendText(a.InnerText.Trim().Replace("&quot;", "'")+Environment.NewLine+ a.Attributes["href"].Value+Environment.NewLine);
                            siteList[siteList.Count - 1].articles.Add(new Article(a.InnerText.Trim().Replace("&quot;", "'"), a.Attributes["href"].Value));
                        }
                    }
                    }
                }
                catch(Exception e)
                {

                }
                tP.Controls.Add(tB);
                tC.TabPages.Add(tP);
            }

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
