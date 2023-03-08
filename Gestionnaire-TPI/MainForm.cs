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
    public partial class MainForm : Form
    {
        private ConnectionDB connection;
        private Collaborator user;

        public MainForm(Collaborator user)
        {
            InitializeComponent();

            this.user = user;

            cmdDetails.Text = (user.IsAdmin) ? "Voir détails / Modifier" : "Voir détails";

            initDGV();
        }

        private void initDGV()
        {
            //Add all base columns
            dgvListTPI.ColumnCount = 4;

            dgvListTPI.Columns[0].Name = "Titre";
            dgvListTPI.Columns[1].Name = "Date";
            dgvListTPI.Columns[2].Name = "Candidat";
            dgvListTPI.Columns[3].Name = "Chef de projet";

            dgvListTPI.Columns[0].Width = 600;
            dgvListTPI.Columns[2].Width = 200;
            dgvListTPI.Columns[3].Width = 200;

            //Prevent user from manipulating the data
            dgvListTPI.ReadOnly = true;
            dgvListTPI.AllowUserToAddRows = false;
            dgvListTPI.AllowUserToDeleteRows = false;
            dgvListTPI.AllowUserToOrderColumns = false;

            dgvListTPI.AllowUserToResizeColumns = false;
            dgvListTPI.AllowUserToResizeRows = false;

            dgvListTPI.AllowDrop = false;

            if (user.IsAdmin)
            {
                //Show the add button
                cmdAdd.Visible = true;
                cmdAdd.Enabled = true;

                //Create a delete button
                DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                button.Name = "Supprimer TPI";
                button.Text = "Supprimmer";

                //Add a column, that will generate the delete button on every row
                dgvListTPI.Columns.Add(button);

                //add 'CellContentClick' event handler to the grid, this is intended for the delete button
                dgvListTPI.CellContentClick += new DataGridViewCellEventHandler(dgvListTPI_CellContentClick);
            }

            refreshList();
        }

        /// <summary>
        /// Insert all data to the DataGridView
        /// </summary>
        private void refreshList()
        {
            dgvListTPI.Rows.Clear();

            try
            {
                connection = new ConnectionDB();

                List<TPI> list = connection.getListTPI();

                foreach (TPI tpi in list)
                {
                    dgvListTPI.Rows.Add(tpi.DisplayTPIShort(user.IsAdmin));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Event handler for CellContentClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvListTPI_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            //Verify that the user clicked on a celle that contains a button 
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                //TODO Replace this to delete a TPI instead
                MessageBox.Show(dgvListTPI[0, e.RowIndex].Value.ToString());
            }
        }

        /// <summary>
        /// Event handler for the add button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdAdd_Click(object sender, EventArgs e)
        {
            Form addTPI = new Form();

            addTPI.FormClosing += delegate
            {
                this.Show();
            };

            addTPI.Show();
            this.Hide();
        }

        /// <summary>
        /// Event handler for the refresh button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            refreshList();
        }

        /// <summary>
        /// Event handler for the details button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdDetails_Click(object sender, EventArgs e)
        {
            DetailsForm detailsForm = new DetailsForm();

            DataGridViewRow t = dgvListTPI.Rows[dgvListTPI.SelectedCells[0].RowIndex];

            //Get title of TPI :
            //t.Cells[0].ToString();
            
            detailsForm.FormClosing += delegate
            {
                this.Show();
            };

            detailsForm.Show();
            this.Hide();
        }
    }
}
