using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassiHooneLoomine_tulusa
{
    class Program
    {
        static void Main(string[] args)
        {
            EraMaja majake = new EraMaja();
            
            Inimene mees = new Inimene("Juku");
            majake.uks = new Uks("must");
            mees.hoone = majake;
            mees.NaitaInfo();
            majake.Suurus();
            Console.ReadKey();
        }
    }
}
