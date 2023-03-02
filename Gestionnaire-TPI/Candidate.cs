using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Gestionnaire_TPI
{
    public class Candidate : Person
    {
        private string className;

        public string ClassName { get { return className; } }

        public Candidate(string firstName, string lastName, string email, string className) : base (firstName, lastName, email)
        {
            this.className = className;
        }
    }
}
