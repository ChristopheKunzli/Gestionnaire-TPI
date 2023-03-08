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
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(25, 33);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(30, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Titre";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(25, 48);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(41, 15);
            lblYear.TabIndex = 1;
            lblYear.Text = "Annee";
            // 
            // lblRemark
            // 
            lblRemark.AutoSize = true;
            lblRemark.Location = new Point(25, 63);
            lblRemark.Name = "lblRemark";
            lblRemark.Size = new Size(61, 15);
            lblRemark.TabIndex = 2;
            lblRemark.Text = "Remarque";
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Location = new Point(25, 78);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(38, 15);
            lblDuration.TabIndex = 3;
            lblDuration.Text = "Durée";
            // 
            // lblCandidate
            // 
            lblCandidate.AutoSize = true;
            lblCandidate.Location = new Point(25, 93);
            lblCandidate.Name = "lblCandidate";
            lblCandidate.Size = new Size(55, 15);
            lblCandidate.TabIndex = 4;
            lblCandidate.Text = "Candidat";
            // 
            // lblChief
            // 
            lblChief.AutoSize = true;
            lblChief.Location = new Point(25, 108);
            lblChief.Name = "lblChief";
            lblChief.Size = new Size(82, 15);
            lblChief.TabIndex = 5;
            lblChief.Text = "Chef de projet";
            // 
            // lblExpertOne
            // 
            lblExpertOne.AutoSize = true;
            lblExpertOne.Location = new Point(25, 123);
            lblExpertOne.Name = "lblExpertOne";
            lblExpertOne.Size = new Size(49, 15);
            lblExpertOne.TabIndex = 6;
            lblExpertOne.Text = "Expert 1";
            // 
            // lblExpertTwo
            // 
            lblExpertTwo.AutoSize = true;
            lblExpertTwo.Location = new Point(25, 138);
            lblExpertTwo.Name = "lblExpertTwo";
            lblExpertTwo.Size = new Size(49, 15);
            lblExpertTwo.TabIndex = 7;
            lblExpertTwo.Text = "Expert 2";
            // 
            // DetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 423);
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
    }
}