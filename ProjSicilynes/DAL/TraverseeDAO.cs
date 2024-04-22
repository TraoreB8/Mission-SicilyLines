using MySql.Data.MySqlClient;
using ProjSicilynes.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjSicilynes.DAL
{
    internal class TraverseeDAO
    {
        // attributs de connexion statiques
        private static string provider = "localhost";

        private static string dataBase = "sicilylines";

        private static string uid = "root";

        private static string mdp = "";



        private static ConnexionSql maConnexionSql;


        private static MySqlCommand Ocom;


        //Afficher les traversées

        public static List<Traversee> GetTraversee(int idLiaison)
        {
            try
            {
                List<Traversee> lestraversees = new List<Traversee>();
                Traversee latraverse = new Traversee();

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();

                Ocom = maConnexionSql.reqExec("Select * from traversee where id_liaison = " + idLiaison);
                MySqlDataReader reader1 = Ocom.ExecuteReader();



                while (reader1.Read())
                {

                    int _idTraversee = (int)reader1.GetValue(0);
                    string _date = (string)reader1.GetValue(1);
                    string _heure = (string)reader1.GetValue(2);
                    int _idLiaison = (int)reader1.GetValue(3);
                    int _idBateau = (int)reader1.GetValue(4);

                    latraverse = new Traversee(_idLiaison, _date, _heure, _idLiaison, _idBateau);

                    //chaque objet crée ajouté la liste lesliaions
                    lestraversees.Add(latraverse);
                }
                reader1.Close();
                maConnexionSql.closeConnection();
                return lestraversees;
            }
            catch (Exception uneTraversee)
            {
                throw (uneTraversee);
            }
        }


    }
}
