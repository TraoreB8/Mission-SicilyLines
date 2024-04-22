using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ProjSicilynes.Modele;

namespace ProjSicilynes.DAL
{
    internal class LiaisonDAO
    {
        // attributs de connexion statiques
        private static string provider = "localhost";

        private static string dataBase = "sicilylines";

        private static string uid = "root";

        private static string mdp = "";



        private static ConnexionSql maConnexionSql;


        private static MySqlCommand Ocom;


        /* Mise à jour d'une Liaison
        public static void updateLiaison(Liaison l)
        {
            try
            {


                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("update liaison set duree = '" + l.Duree + "' where id = " + l.idliaison);


                int i = Ocom.ExecuteNonQuery();



                maConnexionSql.closeConnection();



            }

            catch (Exception emp)
            {

                throw (emp);
            }
        }*/

        //Modifier liaison
        public static void modifLiaison(Liaison l)
        {
            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);

                maConnexionSql.openConnection();

                Ocom = maConnexionSql.reqExec("update liaison set duree = '" + l.Duree + "' where id = " + l.idliaison);


                int i = Ocom.ExecuteNonQuery();

                maConnexionSql.closeConnection();

            }

            catch (Exception emp)
            {

                throw (emp);
            }
        }




        public static void DeleteLiaison(Liaison l)
        {
            try
            {


                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("delete from liaison  where id = " + l.idliaison);


                int i = Ocom.ExecuteNonQuery();



                maConnexionSql.closeConnection();



            }

            catch (Exception emp)
            {

                throw (emp);
            }
        }
        //Afficher les liaisons
        public static List <Liaison> getLiaison(int idSecteur)
        {
            try
            {
                List<Liaison> list = new List<Liaison>();
                Liaison laliaison = new Liaison();
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();
                Ocom = maConnexionSql.reqExec("Select * from liaison where idSecteur = " + idSecteur + "+1");

                MySqlDataReader reader1 = Ocom.ExecuteReader();



                while (reader1.Read())
                {

                    int _unId = (int)reader1.GetValue(0);
                    string _duree = (string)reader1.GetValue(1);
                    int idPortDepart = (int)reader1.GetValue(2);
                    int idPortArrivee = (int)reader1.GetValue(3);
                    int _idSecteur = (int)reader1.GetValue(4);

                    laliaison = new Liaison(_unId, _duree, idPortDepart, idPortArrivee, _idSecteur);

                    //Chaque objet ajouter inséré dans la liste
                    list.Add(laliaison);
                }
                reader1.Close();

                maConnexionSql.closeConnection();


                return (list);

            }

            catch (Exception uneLiaison)
            {

                throw (uneLiaison);
            }
        }
        //insert
        public static void  insertLiaison(string duree, int monPortDepart, int monPortArrivee, int idSecteur)
        {
            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();
                String sqlReq = "INSERT INTO liaison(duree, port_depart, port_arrivee, idSecteur) VALUES('" + duree + "'," + monPortDepart + "," + monPortArrivee + "," + idSecteur + ");";
                Ocom = maConnexionSql.reqExec(sqlReq);
                Console.WriteLine(sqlReq);

                int i = Ocom.ExecuteNonQuery();

                maConnexionSql.closeConnection();

            }

            catch (Exception emp)
            {

                throw (emp);
            }



        }

    }
}