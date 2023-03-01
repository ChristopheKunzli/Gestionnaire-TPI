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

        public string Title { get { return title; } }
        public string Year { get { return year; } }
        public string Remarks { get { return remarks; } }
        public string Duration { get { return duration; } }
        
        
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

        public string[] displayTPI()
        {
            return new string[] { title, year, remarks, duration };
        }
    }
}
