namespace Gestionnaire_TPI
{
    public partial class LoginForm : Form
    {
        private ConnectionDB connection;
        private Collaborator user;
        private readonly string DEFAULT_PASSWORD = "1234";

        public Collaborator User { get { return user; } }

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
                MessageBox.Show("Veuillez rentrer une adresse email valide");
                return;
            }

            if(password == string.Empty)
            {
                MessageBox.Show("Veuillez rentrer votre mot de passe");
                return;
            }

            user = connection.GetUser(mail, password);

            if(user == null) 
            { 
                MessageBox.Show("Email ou mot de passe erroné");
                return;
            }

            //Check if user needs to change password or not
            if(password == DEFAULT_PASSWORD)
            {
                Form changePass = new ChangePassword(user);

                //Determine what to do when the changePassword form is closed based on it's dialog result
                changePass.FormClosing += delegate { 
                    if(changePass.DialogResult == DialogResult.OK)
                    {
                        //If user successfully changed their password, go to main form
                        closeForm();
                    }
                    else
                    {
                        this.Show();
                        user = null;
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