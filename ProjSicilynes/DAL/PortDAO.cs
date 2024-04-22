using MySql.Data.MySqlClient;
using ProjSicilynes.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjSicilynes.DAL
{
    internal class PortDAO
    {
        // attributs de connexion statiques
        private static string provider = "localhost";

        private static string dataBase = "sicilylines";

        private static string uid = "root";

        private static string mdp = "";



        private static ConnexionSql maConnexionSql;


        private static MySqlCommand Ocom;



        public static List<Port> GetPort()
        {
            List<Port> leport = new List<Port>();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                Ocom = maConnexionSql.reqExec("select * from port");

                MySqlDataReader reader = Ocom.ExecuteReader();
                Port p;

                while (reader.Read())
                {
                    int id = (int)reader.GetValue(0);
                    string nom = (string)reader.GetValue(1);

                    p = new Port(id, nom);
                    leport.Add(p);
                }


                reader.Close();

                maConnexionSql.closeConnection();

            }

            catch (Exception emp)
            {

                throw (emp);

            }
            return leport;

        }


    }
}
