using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ProjSicilynes.Modele;


namespace ProjSicilynes.DAL
{
    internal class SecteurDAO
    {
        private static string provider = "localhost";

        private static string dataBase = "sicilylines";

        private static string uid = "root";

        private static string mdp = "";

        private static ConnexionSql maConnexionSql;


        private static MySqlCommand Ocom;


        // Mise à jour d'un employé
        public static void updateSecteur(Secteur s)
        {
            try
            {


                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("update secteur set nom = '" + s.Nom + "' where id = " + s.Id);


                int i = Ocom.ExecuteNonQuery();



                maConnexionSql.closeConnection();



            }

            catch (Exception emp)
            {

                throw (emp);
            }
        }
        //Supprimer un secteur
        public static void DeleteSecteur(Secteur s)
        {
            try
            {


                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("delete from secteur where id = " + s.Id);


                int i = Ocom.ExecuteNonQuery();



                maConnexionSql.closeConnection();



            }

            catch (Exception emp)
            {

                throw (emp);
            }
        }

        //Insert d'un secteur
        public static void insertSecteur(Secteur s)
        {

            try
            {


                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("INSERT INTO secteur(nom) VALUES (" + s.Nom + ")");


                int i = Ocom.ExecuteNonQuery();



                maConnexionSql.closeConnection();



            }

            catch (Exception unSecteur)
            {

                throw (unSecteur);
            }
        }

        //Afficher un secteur
        public static List<Secteur> getSecteur()
        {
            List<Secteur> sec = new List<Secteur>();
            try 
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                Ocom = maConnexionSql.reqExec("select * from secteur");


                MySqlDataReader reader = Ocom.ExecuteReader();
                Secteur s;


                while (reader.Read())
                {
                    int unId = (int)reader.GetValue(0);
                    string nom = (string)reader.GetValue(1);
                    //Instanciation d'un Secteur
                    s = new Secteur(unId, nom);

                    // Ajout de ce secteur a la liste
                    sec.Add(s);
                }

                reader.Close();
                maConnexionSql.closeConnection();

                // Envoi de la liste au Manager
                return (sec);
            
            }


            catch (Exception unSecteur)
            {

                throw (unSecteur);

            }


        }



    }
}