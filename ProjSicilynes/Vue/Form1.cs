using ProjSicilynes.Controleur;
using ProjSicilynes.Modele;
using ProjSicilynes.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace ProjSicilynes
{
    public partial class Form1 : Form
    {
        Mgr monManager;
        List<Secteur> lsecteur = new List<Secteur>();
        List<Liaison> lalaison = new List<Liaison>();
        List<Traversee> latraverse = new List<Traversee>();
        public Form1()
        {
            InitializeComponent();
            monManager = new Mgr();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            lsecteur = monManager.chargementEmpBD();

            //Permet d'effacer
            comboBox1.DataSource = null;
            //La classe LiaisonDAO va dans getLiaison et va dans l'id de la liste de secteur
            comboBox1.DataSource = PortDAO.GetPort();
            //Permet d'afficher la description
            comboBox1.DisplayMember = "Description";


            //Permet de reset, ou sinon il va garder les précédents valeurs
            comboBox2.DataSource = null;
            //La classe LiaisonDAO va dans getLiaison et va dans l'id de la liste de secteur
            comboBox2.DataSource = PortDAO.GetPort();
            //Permet d'afficher la description
            comboBox2.DisplayMember = "Description";
            listBoxLiaison.DataSource = lalaison;

            //label7.Text = Convert.ToString( Liaison.NbLiaison()) + " liaisons crées";


            affiche();

        }

        public void affiche()

        {

            try
            {
                //Reset 
                listBoxSecteur.DataSource = null;
                //Connection 
                listBoxSecteur.DataSource = lsecteur;

                //Utilise la méthode
                listBoxSecteur.DisplayMember = "Description";
                listBoxLiaison.DataSource = null;
                listBoxLiaison.DataSource = lalaison;

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnModifSecteur_Click(object sender, EventArgs e)
        {
            try
            {
                // Modifier
                Secteur unSecteur = (Secteur)listBoxSecteur.SelectedItem;

                unSecteur.Nom = tbSecteur.Text;

                SecteurDAO.updateSecteur(unSecteur);

                lsecteur = monManager.chargementEmpBD();

                affiche();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnSuppLiaison_Click(object sender, EventArgs e)
        {
            try
            {
                //L'objet prend la liste de la lisaison
                Liaison uneLiaison = (Liaison)listBoxLiaison.SelectedItem;
                //la classe utilise la méthode deleteLiaison et prend la liste de lisaion
                LiaisonDAO.DeleteLiaison(uneLiaison);



                //L'objet prend la liste des secteurs
                var secteur = listBoxSecteur.SelectedItem as Secteur;
                //La classe utilise la méthode et va chercher dans les id de la liste des secteurs
                listBoxLiaison.DataSource = LiaisonDAO.getLiaison(secteur.Id);
                //Affiche le return de la méthode description
                listBoxLiaison.DisplayMember = "Description";
                affiche();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnModifLiaison_Click(object sender, EventArgs e)
        {
            /* //Création de l'objet uneLiaison qui prend la liste de liaison 
             Liaison uneLiaison = (Liaison)listBoxLiaison.SelectedItem;
             //La classe LiaisonDAO utilise la méthode modifLiaison et prend en paramètre l'id de la liste de liaison)
             LiaisonDAO.modifLiaison(uneLiaison.idliaison, tbDuree.Text);
             affiche(); */

            try
            {
                // Modifier
                Liaison uneLiaison = (Liaison)listBoxLiaison.SelectedItem;

                uneLiaison.Duree = tbLiaison.Text;

                LiaisonDAO.modifLiaison(uneLiaison);


                affiche();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void listBoxSecteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Permet de prendre l'id de la chose sélectionnée
            int secteur = listBoxSecteur.SelectedIndex;
            //Permet de reset, ou sinon il va garder les précédents valeurs
            listBoxLiaison.DataSource = null;
            //La classe LiaisonDAO va dans getLiaison et va dans l'id de la liste de secteur
            listBoxLiaison.DataSource = LiaisonDAO.getLiaison(secteur) ;

            listBoxLiaison.DisplayMember = "Description";


            label7.Text = Convert.ToString(listBoxLiaison.Items.Count)+"nombre de liaisons";

        }

        private void listBoxLiaison_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Permet de prendre l'id de la chose sélectionnée
            Liaison liaisonSelec = listBoxLiaison.SelectedItem as Liaison;
            //Permet de reset, ou sinon il va garder les précédents valeurs
            if (liaisonSelec != null)
            {
                listBoxTraversee.DataSource = TraverseeDAO.GetTraversee(liaisonSelec.idliaison) ;
                //Permet d'afficher la description
                listBoxTraversee.DisplayMember = "Description";

            }


        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            /*            Secteur secteur = listBoxSecteur.SelectedItem as Secteur;
                        //L'objet prend la liste des secteurs
                        Port portdepart = comboBox1.SelectedItem as Port;
                        //L'objet prend la liste des secteurs
                        Port portarrivee = comboBox2.SelectedItem as Port;

                        LiaisonDAO.insertLiaison(tbDuree.Text, portdepart.idport, portarrivee.idport, secteur.Id);

                        //Permet de reset, ou sinon il garde les précédents valeurs
                        Liaison uneLiaison = (Liaison)listBoxLiaison.SelectedItem;
                        listBoxLiaison.DataSource = null;
                        // Ajout en appellant la méthode

                        affiche();*/

            Secteur secteur = listBoxSecteur.SelectedItem as Secteur;
            //L'objet prend la liste des secteurs
            Port portdepart = comboBox1.SelectedItem as Port;
            //L'objet prend la liste des secteurs
            Port portarrivee = comboBox2.SelectedItem as Port;

            LiaisonDAO.insertLiaison(tbDuree.Text, portdepart.idport, portarrivee.idport, secteur.Id);

            //Permet de reset, ou sinon il va garder les précédents valeurs
            Liaison uneLiaison = (Liaison)listBoxLiaison.SelectedItem;
            listBoxLiaison.DataSource = null;
            // Ajout en appellant la méthode

            affiche();

        }
    }
}
