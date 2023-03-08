using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionnaire_TPI
{
    public abstract class Person
    {
        private string firstName;
        private string lastName;
        private string email;

        public string FirstName { get { return firstName; } }
        public string LastName { get { return lastName;} }
        public string Email { get { return email;} }

        public Person (string firstName, string lastName, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
        }

        public string GetFullName()
        {
            return $"{firstName} {lastName}";
        }

    }
}
