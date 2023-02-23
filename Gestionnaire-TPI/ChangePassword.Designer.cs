namespace Gestionnaire_TPI
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtConfirmNewPass = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.lblConfirmNewPass = new System.Windows.Forms.Label();
            this.txtExplain = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(251, 135);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(100, 23);
            this.txtNewPass.TabIndex = 0;
            // 
            // txtConfirmNewPass
            // 
            this.txtConfirmNewPass.Location = new System.Drawing.Point(251, 186);
            this.txtConfirmNewPass.Name = "txtConfirmNewPass";
            this.txtConfirmNewPass.PasswordChar = '*';
            this.txtConfirmNewPass.Size = new System.Drawing.Size(100, 23);
            this.txtConfirmNewPass.TabIndex = 1;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(180, 243);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Confirmer";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Location = new System.Drawing.Point(60, 138);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(128, 15);
            this.lblNewPass.TabIndex = 3;
            this.lblNewPass.Text = "Nouveau mot de passe";
            // 
            // lblConfirmNewPass
            // 
            this.lblConfirmNewPass.AutoSize = true;
            this.lblConfirmNewPass.Location = new System.Drawing.Point(60, 186);
            this.lblConfirmNewPass.Name = "lblConfirmNewPass";
            this.lblConfirmNewPass.Size = new System.Drawing.Size(183, 15);
            this.lblConfirmNewPass.TabIndex = 4;
            this.lblConfirmNewPass.Text = "Confirmer nouveau mot de passe";
            // 
            // txtExplain
            // 
            this.txtExplain.Location = new System.Drawing.Point(60, 12);
            this.txtExplain.Multiline = true;
            this.txtExplain.Name = "txtExplain";
            this.txtExplain.ReadOnly = true;
            this.txtExplain.Size = new System.Drawing.Size(312, 88);
            this.txtExplain.TabIndex = 5;
            this.txtExplain.Text = resources.GetString("txtExplain.Text");
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 300);
            this.Controls.Add(this.txtExplain);
            this.Controls.Add(this.lblConfirmNewPass);
            this.Controls.Add(this.lblNewPass);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtConfirmNewPass);
            this.Controls.Add(this.txtNewPass);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNewPass;
        private TextBox txtConfirmNewPass;
        private Button btnConfirm;
        private Label lblNewPass;
        private Label lblConfirmNewPass;
        private TextBox txtExplain;
    }
}