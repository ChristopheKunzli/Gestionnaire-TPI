using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionnaire_TPI
{
    public class Collaborator : Person
    {
        private string acronym;
        private bool isAdmin;

        public string Acronym { get { return acronym; } }
        public bool IsAdmin { get { return isAdmin; } }


        public Collaborator(string firstName, string lastName, string email, string acronym, bool isAdmin) : base(firstName, lastName, email)
        {
            this.acronym = acronym;
            this.isAdmin = isAdmin;
        }

    }
}
