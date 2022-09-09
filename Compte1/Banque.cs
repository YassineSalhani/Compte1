using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compte1
{
    class Banque
    {
        public Banque()
        {
            mesComptes = new List<Compte>();
        }
        private List<Compte> mesComptes;

        public List<Compte> MesComptes
        {
            get { return mesComptes; }
            set { mesComptes = value; }
        }


        public void ajouter(Compte c)
        {
            mesComptes.Add(c);
        }
        public void ajouter(int leNumero, string leNom, double leSolde, double leDecouvertAutorise)
        {
            Compte monCompte = new Compte(leNumero, leNom, leSolde, leDecouvertAutorise);
            this.ajouter(monCompte);
        }
        public Compte rendCompte(int numCompte)
        {
            foreach (Compte c in mesComptes)
            {
                if (c.Contains(numCompte))
                {
                    return c;
                }
                else
                {
                    return null;
                }
            }


        }
        



    }


}
