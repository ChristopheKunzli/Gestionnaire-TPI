using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionnaire_TPI
{
    public class User
    {
        private string firstName;
        private string lastName;
        private string email;
        private string acronym;
        private bool isAdmin;


        public string FirstName { get { return firstName; } }
        public string LastName { get { return lastName; } }
        public string Email { get { return email; } }
        public string Acronym { get { return acronym; } }
        public bool IsAdmin { get { return isAdmin; } }


        public User(string firstName, string lastName, string email, string acronym, bool isAdmin)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.acronym = acronym;
            this.isAdmin = isAdmin;
        }

    }
}
