using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassiHooneLoomine_tulusa
{
    public class Uks
    {
        string color;
        public string Color 
        {
            set { color = value; }
            get { return color; }
        }
        public Uks(string color = "sinine")
        {
            Color = color;
        }
        public void NaitaInfo()
        {
            Console.WriteLine($"Mina olen uks, minu värv on {Color}");
        }

    }
}
