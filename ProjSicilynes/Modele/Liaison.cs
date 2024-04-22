using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ProjSicilynes.DAL;

namespace ProjSicilynes.Modele
{
    internal class Liaison
    {
        private int idLiaison;
        private string duree;
        private int portDepart;
        private int portArrivee;
        private int unSecteur;
        private static int count = 0;

        public Liaison()
        {
        }

        public Liaison(int unId, string uneDuree, int pDep, int pArr, int leSecteur)
        {
            this.idLiaison = unId;
            this.duree = uneDuree;
            this.portDepart = pDep;
            this.portArrivee = pArr;
            this.unSecteur = leSecteur;
            Liaison.NbLiaison();
        }

        public static int NbLiaison()
        {
            return count ;
        }

        public int idliaison { get => idLiaison; set => idLiaison = value; }
        public string Duree { get => duree; set => duree = value; }
        public int PortDepart { get => portDepart; set => portDepart = value; }
        public int PortArrivee { get => portArrivee; set => portArrivee = value; }

        public int SecteurL { get => unSecteur; set => unSecteur = value; }

        public override string ToString()
        {
            //Mysql ca commence par 0 et C# commence à 1
            string unDepart = PortDAO.GetPort()[this.portDepart - 1].nomport;
            string unArrivee = PortDAO.GetPort()[this.portArrivee - 1].nomport;
            return ("Liaison n° " + this.idLiaison + " sa durée : " + this.duree +
                " son port de départ : " + this.portDepart + " son port d'arrivée" + this.portArrivee);

        }
    }
}
