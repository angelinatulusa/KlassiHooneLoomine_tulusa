using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassiHooneLoomine_tulusa
{
    public class KorteriteMaja : Hoone
    {
        string korrused;
        public KorteriteMaja(int pindala = 200) : base(pindala)
        {

            if (Pindala == 200)
            {
                korrused = "kahekorrulisene maja";
            }
            else if (Pindala == 400)
            {
                korrused = "nelikorruseline maja";
            }
            else if (Pindala == 600)
            {
                korrused = "üheksa korrulisene maja";
            }
            else
            {
                korrused = "kuueteistkorrulisene maja";
            }
        }
        public void NaitaInfo()
        {
            Console.WriteLine("Ma olen {0}", korrused);
        }

    }
}
