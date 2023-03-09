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
        }

        /// <summary>
        /// Method used to instantiate a connection to the DataBase
        /// </summary>
        private MySqlConnection InitConnexion()
        {
            // connection string creation : contact the DB server
            string connectionString = "SERVER=SC-C236-PC09; PORT=3306; DATABASE=tpi-manager; UID=client_tpi-manager; PASSWORD=Pa$$w0rd";
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

                cmdSelect.CommandText = 
                    "SELECT tpi.title, tpi.year, tpi.remarks, tpi.duration, tpi.CDC, " +
                    "candidates.firstName AS candidate_firstName, candidates.lastName AS candidate_lastName, candidates.email AS candidate_email, " +
                    "collaborators.firstName AS collaborator_firstName, collaborators.lastName AS collaborator_lastName, collaborators.email AS collaborator_email, collaborators.acronym AS collaborator_acronym, collaborators.isResponsableTPI AS collaborator_isResponsable, " +
                    "classes.name AS candidate_className " +
                    "FROM tpi " +
                    "LEFT JOIN candidates ON candidates.id = tpi.Candidates_id " +
                    "LEFT JOIN collaborators ON collaborators.id = tpi.Collaborators_id " +
                    "LEFT JOIN classes ON classes.id = candidates.Classes_id";

                MySqlDataReader dataReader = cmdSelect.ExecuteReader();

                while (dataReader.Read())
                {
                    //Extract TPI data
                    string title = dataReader["title"].ToString();
                    string year = dataReader["year"].ToString();
                    string remarks = dataReader["remarks"].ToString();
                    string duration = dataReader["duration"].ToString();

                    //Extract candidate data
                    string candidatefirstName = dataReader["candidate_firstName"].ToString();
                    string candidatelastName = dataReader["candidate_lastName"].ToString();
                    string candidateEmail = dataReader["candidate_email"].ToString();
                    string candidateClass = dataReader["candidate_className"].ToString();

                    //Extract project chief data
                    string projectChiefirstName = dataReader["collaborator_firstName"].ToString();
                    string projectChieflastName = dataReader["collaborator_lastName"].ToString();
                    string projectChiefEmail = dataReader["collaborator_email"].ToString(); 
                    string projectChiefAcronym = dataReader["collaborator_acronym"].ToString();
                    bool projectChiefIsResponsable = (dataReader["collaborator_isResponsable"].ToString() == "1") ? true : false;

                    //Instanciate objects and add TPI to list
                    Candidate cand = new Candidate(candidatefirstName, candidatelastName, candidateEmail, candidateClass);
                    Collaborator chief = new Collaborator(projectChiefirstName, projectChieflastName, projectChiefEmail, projectChiefAcronym, projectChiefIsResponsable);

                    list.Add(new TPI(title, year, remarks, duration, cand, chief));
                   
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

        public List<Candidate> getListCandidates()
        {
            List<Candidate> list = new List<Candidate>();

            try
            {
                connection.Open();

                MySqlCommand cmdSelect = connection.CreateCommand();

                cmdSelect.CommandText =
                    "SELECT candidates.firstName, candidates.lastName, candidates.email, classes.name AS className " +
                    "FROM candidates " +
                    "LEFT JOIN classes ON classes.id = candidates.Classes_id";

                MySqlDataReader dataReader = cmdSelect.ExecuteReader();

                while (dataReader.Read())
                {
                    //Extract candidate data
                    string firstName = dataReader["firstName"].ToString();
                    string lastName = dataReader["lastName"].ToString();
                    string email = dataReader["email"].ToString();
                    string className = dataReader["className"].ToString();

                    list.Add(new Candidate(firstName, lastName, email, className));

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

        public List<Collaborator> getListCollaborator()
        {
            List<Collaborator> list = new List<Collaborator>();

            try
            {
                connection.Open();

                MySqlCommand cmdSelect = connection.CreateCommand();

                cmdSelect.CommandText =
                    "SELECT firstName, lastName, email, acronym, isResponsableTPI " +
                    "FROM collaborators";

                MySqlDataReader dataReader = cmdSelect.ExecuteReader();

                while (dataReader.Read())
                {
                    //Extract candidate data
                    string firstName = dataReader["firstName"].ToString();
                    string lastName = dataReader["lastName"].ToString();
                    string email = dataReader["email"].ToString();
                    string acronym = dataReader["acronym"].ToString();
                    bool isResponsable = (dataReader["isResponsableTPI"].ToString() == "1") ? true : false;

                    list.Add(new Collaborator(firstName, lastName, email, acronym, isResponsable));

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
