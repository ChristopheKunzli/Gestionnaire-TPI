namespace Gestionnaire_TPI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvListTPI = new DataGridView();
            cmdAdd = new Button();
            cmdRefresh = new Button();
            cmdDetails = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvListTPI).BeginInit();
            SuspendLayout();
            // 
            // dgvListTPI
            // 
            dgvListTPI.AllowUserToAddRows = false;
            dgvListTPI.AllowUserToDeleteRows = false;
            dgvListTPI.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListTPI.Location = new Point(12, 36);
            dgvListTPI.Name = "dgvListTPI";
            dgvListTPI.ReadOnly = true;
            dgvListTPI.RowTemplate.Height = 25;
            dgvListTPI.Size = new Size(1243, 402);
            dgvListTPI.TabIndex = 3;
            // 
            // cmdAdd
            // 
            cmdAdd.Enabled = false;
            cmdAdd.Location = new Point(294, 7);
            cmdAdd.Name = "cmdAdd";
            cmdAdd.Size = new Size(135, 23);
            cmdAdd.TabIndex = 2;
            cmdAdd.Text = "Nouveau TPI";
            cmdAdd.UseVisualStyleBackColor = true;
            cmdAdd.Visible = false;
            cmdAdd.Click += cmdAdd_Click;
            // 
            // cmdRefresh
            // 
            cmdRefresh.Location = new Point(12, 7);
            cmdRefresh.Name = "cmdRefresh";
            cmdRefresh.Size = new Size(135, 23);
            cmdRefresh.TabIndex = 0;
            cmdRefresh.Text = "Rafraichir";
            cmdRefresh.UseVisualStyleBackColor = true;
            cmdRefresh.Click += cmdRefresh_Click;
            // 
            // cmdDetails
            // 
            cmdDetails.Location = new Point(153, 7);
            cmdDetails.Name = "cmdDetails";
            cmdDetails.Size = new Size(135, 23);
            cmdDetails.TabIndex = 1;
            cmdDetails.Text = "Voir détails / modifier";
            cmdDetails.UseVisualStyleBackColor = true;
            cmdDetails.Click += cmdDetails_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1267, 450);
            Controls.Add(cmdDetails);
            Controls.Add(cmdRefresh);
            Controls.Add(cmdAdd);
            Controls.Add(dgvListTPI);
            Name = "MainForm";
            Text = "Main";
            ((System.ComponentModel.ISupportInitialize)dgvListTPI).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListTPI;
        private Button cmdAdd;
        private Button cmdRefresh;
        private Button cmdDetails;
    }
}