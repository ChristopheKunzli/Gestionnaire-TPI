namespace Gestionnaire_TPI
{
    public partial class LoginForm : Form
    {
        private ConnectionDB connection;
        private User collaborator;
        private string DEFAULT_PASSWORD = "1234";

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

            if(password == DEFAULT_PASSWORD)
            {
                Form changePass = new ChangePassword(collaborator);
                changePass.FormClosing += delegate { 
                    if(DialogResult == DialogResult.OK)
                    {
                        this.Close();
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
                DialogResult = DialogResult.OK;
                this.Close();
            }

        }

    }
}