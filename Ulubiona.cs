using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowserApp
{
    public class Ulubiona
    {
        private string tytul;
        public string url;

        public Ulubiona(string tytul, string url)
        {
            this.tytul = tytul;
            this.url = url;
        }

        public override string ToString()
        {
            return tytul;
        }
    }
}
