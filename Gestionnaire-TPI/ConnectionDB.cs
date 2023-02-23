using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
        /// <returns>The created user</returns>
        public User GetUser(string email, string password) 
        {
            User user = null;
            try
            {
                connection.Open();

                MySqlCommand cmdSelect = connection.CreateCommand();

                cmdSelect.CommandText = $"SELECT email, acronym, lastName, firstName, isResponsableTPI FROM collaborators " +
                    $"WHERE collaborators.email = '{email}' AND collaborators.password = '{password}'";

                MySqlDataReader dataReader = cmdSelect.ExecuteReader();

                while (dataReader.Read())
                {
                    string firstName = dataReader["firstName"].ToString();
                    string lastName = dataReader["lastName"].ToString();
                    string mail = dataReader["email"].ToString();
                    string acronym = dataReader["acronym"].ToString();

                    bool isAdmin = (dataReader["isResponsableTPI"].ToString() == "1") ? true : false;

                    user = new User(firstName, lastName, mail, acronym, isAdmin);
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return user;
        }

        /// <summary>
        /// Method used to change a user's password
        /// </summary>
        /// <param name="user"></param>
        /// <param name="newPassword"></param>
        public void UpdateUserPassword(User user, string newPassword)
        {
            try
            {
                connection.Open();
                MySqlCommand cmdUpdate = connection.CreateCommand();

                cmdUpdate.CommandText = $"UPDATE Collaborators SET password=@pass WHERE email=@mail";

                cmdUpdate.Parameters.AddWithValue("@pass", newPassword);
                cmdUpdate.Parameters.AddWithValue("@mail", user.Email);

                cmdUpdate.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
