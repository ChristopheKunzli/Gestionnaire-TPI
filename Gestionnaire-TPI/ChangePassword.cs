using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestionnaire_TPI
{
    public partial class ChangePassword : Form
    {
        private Collaborator user;
        ConnectionDB? connection;

        public ChangePassword(Collaborator user)
        {
            InitializeComponent();
            this.user = user;
        }

        private readonly HashSet<char> CHARS = new("(#$%&()*+-<=>?@)".ToCharArray());

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string password = txtNewPass.Text;
            string confirmPass = txtConfirmNewPass.Text;

            //Errors
            if(password == string.Empty) 
            {
                MessageBox.Show("Veuillez rentrer un mot depasse");
                return;
            }

            if (password.Length < 8)
            {
                MessageBox.Show("Minimum 8 caractères");
                return;
            }

            if (confirmPass == string.Empty || !confirmPass.Equals(password))
            {
                MessageBox.Show("Veuillez confirmer votre mot de passe ");
                return;
            }

            //Check if password meets requirements
            if (isPasswordValid(password))
            {
                //Update the password in the databse
                connection = new ConnectionDB();
                connection.UpdateUserPassword(user, password);

                //Leave this form and login form
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Mot de passe invalide");
            }
        }

        /// <summary>
        /// Method used to check if the password fulfills all our requirements of a valid password
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        private bool isPasswordValid(string password)
        {
            //TODO Use Regex instead of manually checking password validity

            if (password.Length < 8) return false;

            bool containsSpecialChar = false;
            bool containsDigit = false;
            bool containsLetter = false;

            foreach (char c in password.ToCharArray())
            {
                if (CHARS.Contains(c))
                {
                    containsSpecialChar = true;
                }

                if (char.IsDigit(c))
                {
                    containsDigit = true;
                }

                if (char.IsLetter(c))
                {
                    containsLetter = true;
                }
            }

            return containsSpecialChar && containsDigit && containsLetter;
        }
    }
}
