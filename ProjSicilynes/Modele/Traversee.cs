using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProjSicilynes.Modele
{
    internal class Traversee
    {
        private int _idTraversee;
        private string date;
        private string heure;
        private int idLiaison;
        private int _idBateau;

        public Traversee (int unIdTraversee, string uneDate, string heure, int idLiaison, int idBateau)
        {
            this._idTraversee = unIdTraversee;
            this.date = uneDate;
            this.heure = heure;
            this.idLiaison = idLiaison;
            this._idBateau = idBateau;
        }

        public Traversee()
        {

        }

        public int idTraversee { get => _idTraversee; set => _idTraversee = value ;}
        public string Date { get => date; set => date = value; }
        public string Heure { get => heure; set => heure = value; }
        public int IdLiaison { get => idLiaison; set => idLiaison = value; }
        public int IdBateau { get => _idBateau; set => _idBateau = value; }


        public virtual string Description
        {
            get
            {
                return ("Traversée n° " + this._idTraversee + "; Date : " + this.date +
                "; Heure : " + this.heure + "; id du Bateau :" + this._idBateau + " id de la liaison :" + this.idLiaison);
            }
        }
    }
}
