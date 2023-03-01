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
            dgvListTPI.ColumnCount = 6;

            dgvListTPI.Columns[0].Name = "Titre";
            dgvListTPI.Columns[0].Width = 500;
            dgvListTPI.Columns[1].Name = "Date";
            dgvListTPI.Columns[2].Name = "Remarques";
            dgvListTPI.Columns[3].Name = "Durée";
            dgvListTPI.Columns[4].Name = "Candidat";
            dgvListTPI.Columns[5].Name = "Chef de projet";


            dgvListTPI.ReadOnly = true;
            dgvListTPI.AllowUserToAddRows = false;
            dgvListTPI.AllowUserToDeleteRows = false;
            dgvListTPI.AllowUserToOrderColumns = false;
            //dgvListTPI.AllowUserToResizeColumns = false;
            dgvListTPI.AllowUserToResizeRows = false;
            dgvListTPI.AllowDrop = false;

            displayList();

        }
        
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
        
    }
}
