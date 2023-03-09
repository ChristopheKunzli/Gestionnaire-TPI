using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionnaire_TPI
{
    public abstract class Person
    {
        protected string firstName;
        protected string lastName;
        protected string email;
        protected string fullName;
        protected string displayInfo; //Used to display the person in a combobox (see DetailsForm)

        public string FirstName { get { return firstName; } }
        public string LastName { get { return lastName;} }
        public string Email { get { return email;} }
        public string FullName { get { return fullName;} }
        public string DisplayInfo { get { return displayInfo;} }

        public Person (string firstName, string lastName, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;

            this.fullName = SetFullName();
        }

        private string SetFullName()
        {
            return $"{firstName} {lastName}";
        }

        public abstract void setDisplayInfo();

    }
}
