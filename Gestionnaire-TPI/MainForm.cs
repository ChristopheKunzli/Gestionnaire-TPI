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
        private User user;

        public MainForm(User user)
        {
            InitializeComponent();
            this.user = user;
            
            initDGV();

        }

        private void initDGV()
        {
            //Add all columns
            dgvListTPI.ColumnCount = 4;

            dgvListTPI.Columns[0].Name = "Titre";
            dgvListTPI.Columns[0].Width = 500;
            dgvListTPI.Columns[1].Name = "Date";
            dgvListTPI.Columns[2].Name = "Candidat";
            dgvListTPI.Columns[3].Name = "Chef de projet";

            //Prevent user from manipulating the data
            dgvListTPI.ReadOnly = true;
            dgvListTPI.AllowUserToAddRows = false;
            dgvListTPI.AllowUserToDeleteRows = false;
            dgvListTPI.AllowUserToOrderColumns = false;

            dgvListTPI.AllowUserToResizeColumns = true;
            dgvListTPI.AllowUserToResizeRows = false;
            dgvListTPI.AllowDrop = false;


            if (user.IsAdmin)
            {
                cmdAdd.Visible = true;
                cmdAdd.Enabled = true;

                DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                button.Text = "Supprimmer";
                button.Name = "cmdDelete";

                dgvListTPI.Columns.Add(button);

                dgvListTPI.CellContentClick += new DataGridViewCellEventHandler(dgvListTPI_CellContentClick);
            }

            displayList();


        }

        /// <summary>
        /// Event handler for the delete button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvListTPI_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                MessageBox.Show(dgvListTPI[0, e.RowIndex].Value.ToString());
            }
        }


        /// <summary>
        /// Insert all data to the DataGridView
        /// </summary>
        private void displayList()
        {
            dgvListTPI.Rows.Clear();

            try
            {
                connection = new ConnectionDB();

                List<TPI> list = connection.getListTPI();

                foreach (TPI tpi in list)
                {
                    dgvListTPI.Rows.Add(tpi.displayTPI());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void cmdAdd_Click(object sender, EventArgs e)
        {
            Form addTPI = new Form();


            addTPI.FormClosing += delegate {
                this.Show();
            };

            addTPI.Show();
            this.Hide();
        }
    }
}
