namespace Gestionnaire_TPI
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(133, 41);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(196, 23);
            this.txtMail.TabIndex = 0;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(133, 83);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(196, 23);
            this.txtPass.TabIndex = 1;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(39, 44);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(36, 15);
            this.lblMail.TabIndex = 0;
            this.lblMail.Text = "Email";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(39, 86);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(77, 15);
            this.lblPass.TabIndex = 1;
            this.lblPass.Text = "Mot de passe";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(157, 129);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connexion";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 182);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtMail);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtMail;
        private TextBox txtPass;
        private Label lblMail;
        private Label lblPass;
        private Button btnConnect;
    }
}