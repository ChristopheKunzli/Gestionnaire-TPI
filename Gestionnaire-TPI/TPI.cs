using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionnaire_TPI
{
    public class TPI
    {
        private string title;
        private string year;
        private string remarks;
        private string duration;
        private Candidate candidate;
        private Collaborator projectChief;

        public string Title { get { return title; } }
        public string Year { get { return year; } }
        public string Remarks { get { return remarks; } }
        public string Duration { get { return duration; } }
        public Candidate Candidate { get { return candidate; } }
        public Collaborator ProjectChief { get { return projectChief; } }
        
        
        public TPI(string title) 
        { 
            this.title = title;
        }

        public TPI(string title, string year, string remarks, string duration)
        {
            this.title = title;
            this.year = year;
            this.remarks = remarks;
            this.duration = duration;
        }

        public TPI(string title, string year, string remarks, string duration, Candidate candidate, Collaborator projectChief)
        {
            this.title = title;
            this.year = year;
            this.remarks = remarks;
            this.duration = duration;
            this.candidate = candidate;
            this.projectChief = projectChief;
        }

        /// <summary>
        /// Give all important information on the TPI
        /// </summary>
        /// <returns>An array containing each value to display as strings</returns>
        public string[] DisplayTPIShort(bool ChiefIsResponsableTPI)
        {
            string[] res = (ChiefIsResponsableTPI) 
                ? new string[] { title, year, candidate.GetFullName(), projectChief.GetFullName(), "Supprimmer" } 
                : new string[] { title, year, candidate.GetFullName(), projectChief.GetFullName() } ;

            return res;
        }

        public string[] DisplayTPIFull()
        {
            return Array.Empty<string>();
        }
    }
}
