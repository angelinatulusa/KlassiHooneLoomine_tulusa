using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassiHooneLoomine_tulusa
{
    public class EraMaja : Hoone
    {
        string suurus;
        public EraMaja(int pindala=200) : base(pindala)
        {
            
            if (Pindala == 200)
            {
                suurus = "väike maja";
            }
            else if (Pindala == 400)
            {
                suurus = "keskmine maja";
            }
            else if (Pindala == 600)
            {
                suurus = "suur maja";
            }
            else
            {
                suurus = "liiga suur maja";
            }
        }
        public void Suurus()
        {
            Console.WriteLine($"Ma olen {suurus}");
        }
        
    }
}
