using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjSicilynes.Modele
{
    internal class Liaison
    {
        private int idLiaison;
        private string duree;
        private int portDepart;
        private int portArrivee;
        private Secteur unSecteur;


        public Liaison(int unId, string uneDuree, int pDep, int pArr, Secteur leSecteur)
        {
            this.idLiaison = unId;
            this.duree = uneDuree;
            this.portDepart = pDep;
            this.portArrivee = pArr;
            this.unSecteur = leSecteur;
        }


        public int idliaison { get => idLiaison; set => idLiaison = value; }
        public string Duree { get => duree; set => duree = value; }
        public int PortDepart { get => portDepart; set => portDepart = value; }
        public int PortArrivee { get => portArrivee; set => portArrivee = value; }

        public string Description()
        {
            return ("Liaison n° " + this.idLiaison + " sa durée : " + this.duree +
                " son port de départ : " + this.portDepart + " son port d'arrivée" + this.portArrivee);

        }
    }
}
