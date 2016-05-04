namespace Heder_Kosher
{
    partial class ReceptionMain
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
            this.button1 = new System.Windows.Forms.Button();
            this.addStudent = new System.Windows.Forms.Button();
            this.RemoveStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add/Remove Student to Class";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addStudent
            // 
            this.addStudent.Location = new System.Drawing.Point(26, 104);
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(96, 40);
            this.addStudent.TabIndex = 1;
            this.addStudent.Text = "Add Student";
            this.addStudent.UseVisualStyleBackColor = true;
            this.addStudent.Click += new System.EventHandler(this.addRemoveStudent_Click);
            // 
            // RemoveStudent
            // 
            this.RemoveStudent.Location = new System.Drawing.Point(26, 169);
            this.RemoveStudent.Name = "RemoveStudent";
            this.RemoveStudent.Size = new System.Drawing.Size(96, 40);
            this.RemoveStudent.TabIndex = 2;
            this.RemoveStudent.Text = "Remove Student";
            this.RemoveStudent.UseVisualStyleBackColor = true;
            this.RemoveStudent.Click += new System.EventHandler(this.RemoveStudent_Click);
            // 
            // ReceptionMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 405);
            this.Controls.Add(this.RemoveStudent);
            this.Controls.Add(this.addStudent);
            this.Controls.Add(this.button1);
            this.Name = "ReceptionMain";
            this.Text = "ReceptionMain";
            this.Load += new System.EventHandler(this.ReceptionMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addStudent;
        private System.Windows.Forms.Button RemoveStudent;

    }
}