using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjSicilynes.DAL;

namespace ProjSicilynes.Modele
{
    internal class Port
    {
        private int id;
        private string nom;

        public Port(int id, string nom)
        {
            this.id = id;
            this.nom = nom;
        }

        public int idport { get => id; set => id = value; }
        public string nomport { get => nom; set => nom = value; }


        public string Description
        {
            get => "Id : " + this.id + " Nom :" + this.nom;
        }
    }

}
