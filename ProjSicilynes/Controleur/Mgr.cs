using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjSicilynes.DAL;
using ProjSicilynes.Modele;

namespace ProjSicilynes.Controleur
{
    internal class Mgr
    {
        DAL.SecteurDAO empDAO = new DAL.SecteurDAO();

        List<Modele.Secteur> maListeSecteur;

        public Mgr()
        {

            maListeSecteur = new List<Modele.Secteur>();
        }

        // Récupération de la liste des SECTEUR à partir de la DAL
        public List<Secteur> chargementEmpBD()
        {

            maListeSecteur = SecteurDAO.getSecteur();

            return (maListeSecteur);
        }

        // Mise à jour d'un secteur  dans la DAL
        public void updateSecteur(Modele.Secteur s)
        {

            SecteurDAO.updateSecteur(s);

        }

        //Suppression d'un secteur
        public void deleteSecteur(Secteur s)
        {

            SecteurDAO.DeleteSecteur(s);

        }
        public void insertSecteur(Secteur s)
        {

            SecteurDAO.insertSecteur(s);

        }

        internal void insertLiaison(Liaison emp)
        {
            throw new NotImplementedException();
        }
    }
}
