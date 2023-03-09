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
            txtTitle.Text = tpi.Title;
            txtRemark.Text = tpi.Remarks;
            dateYear.Text = tpi.Year;
            numDuration.Value = (tpi.Duration == null) ? 0 : int.Parse(tpi.Duration);

            cmdAllowChange.Enabled = userIsResponsable;
            cmdAllowChange.Visible = userIsResponsable;

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
            cmbCandidate.DisplayMember = "Email";
            cmbCandidate.ValueMember = "Email";

            cmbCandidate.DropDownStyle = ComboBoxStyle.DropDownList;

            //Preselect a specific item
            //Candidate currentCandidate = null;
            foreach (Candidate c in candidates)
            {
                if (c.Email == tpi.Candidate.Email)
                {
                    cmbCandidate.SelectedItem = c;
                    break;
                }
            }


            //Init collaborators combobox
            try
            {
                ConnectionDB db = new ConnectionDB();
                collaborators = db.getListCollaborator();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Set data in combobox
            cmbChief.DataSource = collaborators;

            //Select which properties should be used as display and value
            cmbChief.DisplayMember = "Email";
            cmbChief.ValueMember = "Email";

            cmbChief.DropDownStyle = ComboBoxStyle.DropDownList;

            //Preselect a specific item
            //Candidate currentCandidate = null;
            foreach (Collaborator c in collaborators)
            {
                if (c.Email == tpi.ProjectChief.Email)
                {
                    cmbChief.SelectedItem = c;
                    break;
                }
            }

        }

        private void cmdAllowChange_Click(object sender, EventArgs e)
        {
            txtTitle.Enabled = true;
            txtRemark.Enabled = true;
            dateYear.Enabled = true;
            numDuration.Enabled = true;
            cmbCandidate.Enabled = true;
            cmbChief.Enabled = true;
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
