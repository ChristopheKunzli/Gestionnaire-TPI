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
            this.dgvListTPI = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTPI)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListTPI
            // 
            this.dgvListTPI.AllowUserToAddRows = false;
            this.dgvListTPI.AllowUserToDeleteRows = false;
            this.dgvListTPI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListTPI.Location = new System.Drawing.Point(12, 12);
            this.dgvListTPI.Name = "dgvListTPI";
            this.dgvListTPI.ReadOnly = true;
            this.dgvListTPI.RowTemplate.Height = 25;
            this.dgvListTPI.Size = new System.Drawing.Size(1161, 426);
            this.dgvListTPI.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 450);
            this.Controls.Add(this.dgvListTPI);
            this.Name = "MainForm";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTPI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvListTPI;
    }
}