﻿namespace Gestionnaire_TPI
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
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdRefresh = new System.Windows.Forms.Button();
            this.cmdDetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTPI)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListTPI
            // 
            this.dgvListTPI.AllowUserToAddRows = false;
            this.dgvListTPI.AllowUserToDeleteRows = false;
            this.dgvListTPI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListTPI.Location = new System.Drawing.Point(12, 36);
            this.dgvListTPI.Name = "dgvListTPI";
            this.dgvListTPI.ReadOnly = true;
            this.dgvListTPI.RowTemplate.Height = 25;
            this.dgvListTPI.Size = new System.Drawing.Size(1137, 402);
            this.dgvListTPI.TabIndex = 3;
            // 
            // cmdAdd
            // 
            this.cmdAdd.Enabled = false;
            this.cmdAdd.Location = new System.Drawing.Point(294, 7);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(135, 23);
            this.cmdAdd.TabIndex = 2;
            this.cmdAdd.Text = "Nouveau TPI";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Visible = false;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdRefresh
            // 
            this.cmdRefresh.Location = new System.Drawing.Point(12, 7);
            this.cmdRefresh.Name = "cmdRefresh";
            this.cmdRefresh.Size = new System.Drawing.Size(135, 23);
            this.cmdRefresh.TabIndex = 0;
            this.cmdRefresh.Text = "Rafraichir";
            this.cmdRefresh.UseVisualStyleBackColor = true;
            this.cmdRefresh.Click += new System.EventHandler(this.cmdRefresh_Click);
            // 
            // cmdDetails
            // 
            this.cmdDetails.Location = new System.Drawing.Point(153, 7);
            this.cmdDetails.Name = "cmdDetails";
            this.cmdDetails.Size = new System.Drawing.Size(135, 23);
            this.cmdDetails.TabIndex = 1;
            this.cmdDetails.Text = "Voir détails / modifier";
            this.cmdDetails.UseVisualStyleBackColor = true;
            this.cmdDetails.Click += new System.EventHandler(this.cmdDetails_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 450);
            this.Controls.Add(this.cmdDetails);
            this.Controls.Add(this.cmdRefresh);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.dgvListTPI);
            this.Name = "MainForm";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTPI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvListTPI;
        private Button cmdAdd;
        private Button cmdRefresh;
        private Button cmdDetails;
    }
}