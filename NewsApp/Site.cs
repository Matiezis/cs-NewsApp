using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApp
{
    class Site
    {
        public string name;
        public List<Article> articles;
        public Site(string inName)
        {
            name = inName;
            articles = new List<Article>();
        }
    }
}
