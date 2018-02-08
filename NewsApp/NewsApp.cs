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

namespace NewsApp
{
    public partial class NewsApp : Form
    {
        public NewsApp()
        {
            InitializeComponent();
        }

        private void NewsApp_Load(object sender, EventArgs e)
        {
            WebClient x = new WebClient();
            string source = x.DownloadString("http://www.onet.pl/");
            rtbInput.Text = source;
        }
    }
}
