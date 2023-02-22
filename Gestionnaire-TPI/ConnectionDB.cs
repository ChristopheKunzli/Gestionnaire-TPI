using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace Gestionnaire_TPI
{
    public class ConnectionDB
    {
        private MySqlConnection connection;

        public ConnectionDB()
        {
            InitConnexion();
        }

        /// <summary>
        /// Method used to create a connection to the DataBase
        /// </summary>
        private void InitConnexion()
        {
            // connection string creation : contact the DB server
            string connectionString = "SERVER=127.0.0.1; PORT=3306; DATABASE=tpi-manager; UID=client_tpi-manager; PASSWORD=Pa$$w0rd";
            connection = new MySqlConnection(connectionString);
        }

        /// <summary>
        /// Method used to fetch and create a user object from the DataBase
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public User getUser(string email, string password) 
        {
            User user = null;
            try
            {
                connection.Open();

                MySqlCommand commandGet = connection.CreateCommand();

                commandGet.CommandText = $"SELECT email, acronym, lastName, firstName, isResponsableTPI FROM collaborators WHERE collaborators.email = '{email}' AND collaborators.password = '{password}'";

                MySqlDataReader dataReader = commandGet.ExecuteReader();

                while (dataReader.Read())
                {
                    string firtsName = dataReader["firstName"].ToString();
                    string lastName = dataReader["lastName"].ToString();
                    string mail = dataReader["email"].ToString();
                    string acronym = dataReader["acronym"].ToString();

                    bool isAdmin = (dataReader["isResponsableTPI"].ToString() == "1") ? true : false;

                    user = new User(firtsName, lastName, mail, acronym, isAdmin);
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return user;
        }
    }
}
