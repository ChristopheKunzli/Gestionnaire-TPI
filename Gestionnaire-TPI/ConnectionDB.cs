using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using MySqlConnector;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Gestionnaire_TPI
{
    public class ConnectionDB
    {
        private MySqlConnection connection;

        public ConnectionDB()
        {
            connection = InitConnexion();
            //connection2 = InitConnexion();
        }

        /// <summary>
        /// Method used to create a connection to the DataBase
        /// </summary>
        private MySqlConnection InitConnexion()
        {
            // connection string creation : contact the DB server
            string connectionString = "SERVER=127.0.0.1; PORT=3306; DATABASE=tpi-manager; UID=client_tpi-manager; PASSWORD=Pa$$w0rd";
            return new MySqlConnection(connectionString);
        }

        /// <summary>
        /// Method used to fetch and create a user object from the DataBase
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns>The created user</returns>
        public Collaborator GetUser(string email, string password) 
        {
            Collaborator user = null;
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

                    user = new Collaborator(firstName, lastName, mail, acronym, isAdmin);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }


            return user;
        }

        /// <summary>
        /// Method used to change a user's password
        /// </summary>
        /// <param name="user"></param>
        /// <param name="newPassword"></param>
        public void UpdateUserPassword(Collaborator user, string newPassword)
        {
            try
            {
                connection.Open();
                MySqlCommand cmdUpdate = connection.CreateCommand();

                cmdUpdate.CommandText = $"UPDATE Collaborators SET password=@pass WHERE email=@mail";

                cmdUpdate.Parameters.AddWithValue("@pass", newPassword);
                cmdUpdate.Parameters.AddWithValue("@mail", user.Email);

                cmdUpdate.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Method used to fetch the entire list of tpi along with their candidate and project chief
        /// </summary>
        /// <returns></returns>
        public List<TPI> getListTPI()
        {
            List<TPI> list = new List<TPI>();

            try
            {
                connection.Open();

                MySqlCommand cmdSelect = connection.CreateCommand();

                //cmdSelect.CommandText = 
                //    $"SELECT title, year, remarks, duration, Candidates_id, Collaborators_id FROM tpi";

                cmdSelect.CommandText = 
                    "SELECT tpi.title, tpi.year, tpi.remarks, tpi.duration, tpi.CDC, " +
                    "candidates.firstName AS candidate_firstName, candidates.lastName AS candidate_lastName, " +
                    "collaborators.firstName AS collaborator_firstName, collaborators.lastName AS collaborator_lastName " +
                    "FROM tpi " +
                    "LEFT JOIN candidates ON candidates.id = tpi.Candidates_id " +
                    "LEFT JOIN collaborators ON collaborators.id = tpi.Collaborators_id " +
                    "LEFT JOIN classes ON classes.id = candidates.Classes_id";

                MySqlDataReader dataReader = cmdSelect.ExecuteReader();

                while (dataReader.Read())
                {
                    string title = dataReader["title"].ToString();
                    string year = dataReader["year"].ToString();
                    string remarks = dataReader["remarks"].ToString();
                    string duration = dataReader["duration"].ToString();

                    //int candidate_id =  int.Parse(dataReader["Candidates_id"].ToString());
                    //int collaborator_id =  int.Parse(dataReader["Candidates_id"].ToString());

                    string candidateName = dataReader["candidate_firstName"].ToString() + " " + dataReader["candidate_lastName"].ToString();
                    string projectChiefName = dataReader["collaborator_firstName"].ToString() + " " + dataReader["collaborator_lastName"].ToString();

                    //Candidate cand = getCandidateByID(candidate_id);
                    //Collaborator collab = getCollaboratorByID(collaborator_id);

                    list.Add(new TPI(title, year, remarks, duration));
                   
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return list;
        }

        /// <summary>
        /// Method used to get information of a specific candidate by searching it's id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Candidate object</returns>
        /// <exception cref="NotImplementedException"></exception>
        public Candidate getCandidateByID(int id)
        {
            Candidate candidate = null;

            try
            {
                connection.Open();
                MySqlCommand cmdSelect = connection.CreateCommand();


                cmdSelect.CommandText = 
                    $"SELECT candidates.email, candidates.firstName, candidates.lastName, classes.name AS class_name FROM candidates " +
                    $"INNER JOIN classes ON classes.id = candidates.Classes_id " +
                    $"WHERE candidates.id = @id";

                cmdSelect.Parameters.AddWithValue("@id", id);

                MySqlDataReader dataReader = cmdSelect.ExecuteReader();

                //Store all results in a data table object
                DataTable table = new DataTable();
                table.Load(dataReader);

                string fn = table.Rows[0]["firstName"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                connection.Close();
            }

            return candidate;
        }

        /// <summary>
        /// Method used to get information of a specific collaborator by searching it's id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Collaborator object</returns>
        /// <exception cref="NotImplementedException"></exception>
        public Collaborator getCollaboratorByID(int id) 
        {
            throw new NotImplementedException();
        }
    }
}
