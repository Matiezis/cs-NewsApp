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
        string[] titleTags = { "//span[@class='title']",
                               "//div[@class='_3I9Ewz']",
                               "//li[@class='news-li ']"};

        private void NewsApp_Load(object sender, EventArgs e)
        {
            getSiteList();
            readSitesHttpToTabs(tabControl);
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
            foreach (string s in websiteList)
            {
                rtbInput.AppendText(s + Environment.NewLine);
            }
        }
        private void readSitesHttpToTabs(TabControl tC)
        {
            HtmlWeb web = new HtmlWeb();
            foreach (string site in websiteList)
            {
                string[] splitted = site.Split('.');
                TabPage tP = new TabPage(splitted[splitted.Length - 2]);

                RichTextBox tB = new RichTextBox();
                tB.Dock = DockStyle.Fill;
                tB.Multiline = true;
                tB.ScrollBars = RichTextBoxScrollBars.Vertical;

                HtmlAgilityPack.HtmlDocument document = web.Load(site);
                try
                {
                    
                    foreach (string tag in titleTags)
                    {
                        if (document.DocumentNode.SelectNodes(tag) != null)
                        {
                            HtmlNode[] nodes = document.DocumentNode.SelectNodes(tag).ToArray();
                            foreach (HtmlNode item in nodes)
                            {
                                tB.AppendText(item.InnerText + Environment.NewLine);
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
    }
}
