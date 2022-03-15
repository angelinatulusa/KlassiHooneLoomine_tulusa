using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassiHooneLoomine_tulusa
{
    public class Hoone
    {
        int pindala;
        public int Pindala
        {
            set 
            { 
                pindala = value;
            }
            get { return pindala; }
        }
        public Uks uks;
        public Uks GetUks()
        {
            return uks;
        }
        public Hoone(int pindala)
        {
            Pindala = pindala;
        }
        public void NaitaInfo()
        {
            Console.WriteLine($"Mina olen maja, minu pindala on {Pindala} m2");
            
        }
        


    }
}
