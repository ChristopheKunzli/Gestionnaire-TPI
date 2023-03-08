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
    public partial class DetailsForm : Form
    {
        private bool userIsResponsable;

        public DetailsForm(bool userIsResponsable)
        {
            InitializeComponent();

            this.userIsResponsable = userIsResponsable;
        }
    }
}
