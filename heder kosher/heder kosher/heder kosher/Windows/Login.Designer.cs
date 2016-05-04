namespace Heder_Kosher
{
    partial class Login
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
            this.LoginB = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.UserID = new System.Windows.Forms.TextBox();
            this.UserPass = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginB
            // 
            this.LoginB.Location = new System.Drawing.Point(359, 342);
            this.LoginB.Name = "LoginB";
            this.LoginB.Size = new System.Drawing.Size(133, 49);
            this.LoginB.TabIndex = 0;
            this.LoginB.Text = "Login";
            this.LoginB.UseVisualStyleBackColor = true;
            this.LoginB.Click += new System.EventHandler(this.LoginB_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(112, 342);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(133, 49);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // UserID
            // 
            this.UserID.Location = new System.Drawing.Point(212, 129);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(161, 20);
            this.UserID.TabIndex = 2;
            // 
            // UserPass
            // 
            this.UserPass.Location = new System.Drawing.Point(212, 180);
            this.UserPass.Name = "UserPass";
            this.UserPass.Size = new System.Drawing.Size(161, 20);
            this.UserPass.TabIndex = 3;
            this.UserPass.UseSystemPasswordChar = true;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(152, 136);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(18, 13);
            this.IdLabel.TabIndex = 4;
            this.IdLabel.Text = "ID";
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Location = new System.Drawing.Point(131, 180);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(53, 13);
            this.PassLabel.TabIndex = 5;
            this.PassLabel.Text = "Password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 443);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.UserPass);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.LoginB);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginB;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox UserID;
        private System.Windows.Forms.TextBox UserPass;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label PassLabel;
    }
}

