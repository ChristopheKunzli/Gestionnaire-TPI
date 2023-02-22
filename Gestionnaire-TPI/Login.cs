namespace Gestionnaire_TPI
{
    public partial class frmLogin : Form
    {
        private ConnectionDB connection;

        public frmLogin()
        {
            InitializeComponent();
            connection = new ConnectionDB();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if(txtMail.Text == "")
            {
                MessageBox.Show("Veuillez rentrer un adresse email valide");
                return;
            }

            if(txtPass.Text == "")
            {
                MessageBox.Show("Veuillez rentrer votre mot de passe (si premi�re connexion, le mot de passe par d�faut est \"1234 \")");
                return;
            }

            User test = connection.getUser(txtMail.Text, txtPass.Text);

            if(test == null) 
            { 
                MessageBox.Show("ERROR"); 
            }
            else 
            { 
                MessageBox.Show($"{test.Email}"); 
            }

        }


    }
}