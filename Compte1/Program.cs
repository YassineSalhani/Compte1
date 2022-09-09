using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compte1
{
    class Program
    {
        static void Main(string[] args)
        {
            Banque b = new Banque();
            Compte c1;
            c1 = new Compte(12345, "toto", 1000, -500);
            b.ajouter(c1);
            b.ajouter(12345, "toto", 1000, -500);
            b.ajouter(45657, "titi", 2000, -1000);
            b.ajouter(12654, "tintin", 5000, -500);
            Console.WriteLine(b.rendCompte(45657).ToString());

            foreach (Compte c in b.MesComptes)
            {
                Console.WriteLine(c.ToString());
            }

        }
    }
}
