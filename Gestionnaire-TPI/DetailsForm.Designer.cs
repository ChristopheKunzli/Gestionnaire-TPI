namespace Gestionnaire_TPI
{
    partial class DetailsForm
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
            lblTitle = new Label();
            lblYear = new Label();
            lblRemark = new Label();
            lblDuration = new Label();
            lblCandidate = new Label();
            lblChief = new Label();
            lblExpertOne = new Label();
            lblExpertTwo = new Label();
            txtTitle = new RichTextBox();
            dateYear = new DateTimePicker();
            txtRemark = new RichTextBox();
            numDuration = new NumericUpDown();
            cmbCandidate = new ComboBox();
            cmbChief = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numDuration).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(12, 33);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(30, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Titre";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(12, 273);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(41, 15);
            lblYear.TabIndex = 1;
            lblYear.Text = "Annee";
            // 
            // lblRemark
            // 
            lblRemark.AutoSize = true;
            lblRemark.Location = new Point(12, 121);
            lblRemark.Name = "lblRemark";
            lblRemark.Size = new Size(61, 15);
            lblRemark.TabIndex = 2;
            lblRemark.Text = "Remarque";
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Location = new Point(286, 273);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(56, 15);
            lblDuration.TabIndex = 3;
            lblDuration.Text = "Durée (h)";
            // 
            // lblCandidate
            // 
            lblCandidate.AutoSize = true;
            lblCandidate.Location = new Point(12, 337);
            lblCandidate.Name = "lblCandidate";
            lblCandidate.Size = new Size(55, 15);
            lblCandidate.TabIndex = 4;
            lblCandidate.Text = "Candidat";
            // 
            // lblChief
            // 
            lblChief.AutoSize = true;
            lblChief.Location = new Point(12, 400);
            lblChief.Name = "lblChief";
            lblChief.Size = new Size(82, 15);
            lblChief.TabIndex = 5;
            lblChief.Text = "Chef de projet";
            // 
            // lblExpertOne
            // 
            lblExpertOne.AutoSize = true;
            lblExpertOne.Location = new Point(12, 471);
            lblExpertOne.Name = "lblExpertOne";
            lblExpertOne.Size = new Size(49, 15);
            lblExpertOne.TabIndex = 6;
            lblExpertOne.Text = "Expert 1";
            // 
            // lblExpertTwo
            // 
            lblExpertTwo.AutoSize = true;
            lblExpertTwo.Location = new Point(12, 486);
            lblExpertTwo.Name = "lblExpertTwo";
            lblExpertTwo.Size = new Size(49, 15);
            lblExpertTwo.TabIndex = 7;
            lblExpertTwo.Text = "Expert 2";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(12, 51);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(558, 58);
            txtTitle.TabIndex = 8;
            txtTitle.Text = "";
            // 
            // dateYear
            // 
            dateYear.Location = new Point(12, 291);
            dateYear.Name = "dateYear";
            dateYear.Size = new Size(200, 23);
            dateYear.TabIndex = 9;
            // 
            // txtRemark
            // 
            txtRemark.Location = new Point(12, 139);
            txtRemark.Name = "txtRemark";
            txtRemark.Size = new Size(558, 119);
            txtRemark.TabIndex = 10;
            txtRemark.Text = "";
            // 
            // numDuration
            // 
            numDuration.Location = new Point(286, 291);
            numDuration.Name = "numDuration";
            numDuration.Size = new Size(120, 23);
            numDuration.TabIndex = 11;
            // 
            // cmbCandidate
            // 
            cmbCandidate.FormattingEnabled = true;
            cmbCandidate.Location = new Point(12, 357);
            cmbCandidate.Name = "cmbCandidate";
            cmbCandidate.Size = new Size(394, 23);
            cmbCandidate.TabIndex = 12;
            // 
            // cmbChief
            // 
            cmbChief.FormattingEnabled = true;
            cmbChief.Location = new Point(12, 418);
            cmbChief.Name = "cmbChief";
            cmbChief.Size = new Size(394, 23);
            cmbChief.TabIndex = 13;
            // 
            // DetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 587);
            Controls.Add(cmbChief);
            Controls.Add(cmbCandidate);
            Controls.Add(numDuration);
            Controls.Add(txtRemark);
            Controls.Add(dateYear);
            Controls.Add(txtTitle);
            Controls.Add(lblExpertTwo);
            Controls.Add(lblExpertOne);
            Controls.Add(lblChief);
            Controls.Add(lblCandidate);
            Controls.Add(lblDuration);
            Controls.Add(lblRemark);
            Controls.Add(lblYear);
            Controls.Add(lblTitle);
            Name = "DetailsForm";
            Text = "DetailsForm";
            ((System.ComponentModel.ISupportInitialize)numDuration).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblYear;
        private Label lblRemark;
        private Label lblDuration;
        private Label lblCandidate;
        private Label lblChief;
        private Label lblExpertOne;
        private Label lblExpertTwo;
        private RichTextBox txtTitle;
        private DateTimePicker dateYear;
        private RichTextBox txtRemark;
        private NumericUpDown numDuration;
        private ComboBox cmbCandidate;
        private ComboBox cmbChief;
    }
}