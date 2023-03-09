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
        private TPI tpi;

        private List<Candidate> candidates = new List<Candidate>();
        private List<Collaborator> collaborators = new List<Collaborator>();

        public DetailsForm(bool userIsResponsable, TPI tpi)
        {
            InitializeComponent();

            this.userIsResponsable = userIsResponsable;
            this.tpi = tpi;

            initControls();

            
        }

        private void initControls()
        {
            txtTitle.Enabled = userIsResponsable;
            txtRemark.Enabled = userIsResponsable;
            dateYear.Enabled = userIsResponsable;
            numDuration.Enabled = userIsResponsable;
            cmbCandidate.Enabled = userIsResponsable;

            txtTitle.Text = tpi.Title;
            txtRemark.Text = tpi.Remarks;
            dateYear.Text = tpi.Year;
            numDuration.Value = (tpi.Duration == null) ? 0 : int.Parse(tpi.Duration);


            //Init candidates combobox
            try
            {
                ConnectionDB db = new ConnectionDB();
                candidates = db.getListCandidates();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Set data in combobox
            cmbCandidate.DataSource = candidates;

            //Select which properties should be used as display and value
            cmbCandidate.DisplayMember = "DisplayInfo";
            cmbCandidate.ValueMember = "Email";

            cmbCandidate.DropDownStyle = ComboBoxStyle.DropDownList;

            //Preselect a specific item
            Candidate currentCandidate = null;
            foreach (Candidate c in candidates)
            {
                if (c.Email == tpi.Candidate.Email)
                {
                    currentCandidate = c;
                    break;
                }
            }

            cmbCandidate.SelectedItem = currentCandidate;
        }
    }
}
