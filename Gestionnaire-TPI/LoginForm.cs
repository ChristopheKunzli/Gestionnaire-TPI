namespace Gestionnaire_TPI
{
    public partial class LoginForm : Form
    {
        private ConnectionDB connection;
        private User collaborator;
        private readonly string DEFAULT_PASSWORD = "1234";

        public User Collaborator { get { return collaborator; } }

        public LoginForm()
        {
            InitializeComponent();
            connection = new ConnectionDB();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string mail = txtMail.Text;
            string password = txtPass.Text;

            //Errors
            if (mail == string.Empty)
            {
                MessageBox.Show("Veuillez rentrer un adresse email valide");
                return;
            }

            if(password == string.Empty)
            {
                MessageBox.Show("Veuillez rentrer votre mot de passe (si première connexion, le mot de passe par défaut est \"1234 \")");
                return;
            }

            collaborator = connection.GetUser(mail, password);

            if(collaborator == null) 
            { 
                MessageBox.Show("Email ou mot de passe erroné");
                return;
            }

            //Check if user needs to change password
            if(password == DEFAULT_PASSWORD)
            {
                Form changePass = new ChangePassword(collaborator);

                //Determine what to do when the changePassword form is closed based on it's dialog result
                changePass.FormClosing += delegate { 
                    if(changePass.DialogResult == DialogResult.OK)
                    {
                        closeForm();
                    }
                    else
                    {
                        this.Show();
                        collaborator = null;
                    }
                };

                changePass.Show();
                this.Hide();
            }
            else
            {
                //Close the login form to continue to the main form (see Program.cs)
                closeForm();
            }

        }

        /// <summary>
        /// Closes the form after updating the form's DialogResult
        /// </summary>
        /// <param name="isLoggedIn"></param>
        private void closeForm(bool isLoggedIn = true)
        {
            this.DialogResult = (isLoggedIn)? DialogResult.OK : DialogResult.Abort;
            this.Close();
        }

    }
}