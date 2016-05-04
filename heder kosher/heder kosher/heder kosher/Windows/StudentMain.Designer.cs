namespace Heder_Kosher
{
    partial class StudentMain
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
            this.ShowProgramTraining = new System.Windows.Forms.Button();
            this.RegisterToClass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShowProgramTraining
            // 
            this.ShowProgramTraining.Location = new System.Drawing.Point(31, 43);
            this.ShowProgramTraining.Name = "ShowProgramTraining";
            this.ShowProgramTraining.Size = new System.Drawing.Size(127, 37);
            this.ShowProgramTraining.TabIndex = 0;
            this.ShowProgramTraining.Text = "Training Program";
            this.ShowProgramTraining.UseVisualStyleBackColor = true;
            this.ShowProgramTraining.Click += new System.EventHandler(this.ShowProgramTraining_Click);
            // 
            // RegisterToClass
            // 
            this.RegisterToClass.Location = new System.Drawing.Point(31, 108);
            this.RegisterToClass.Name = "RegisterToClass";
            this.RegisterToClass.Size = new System.Drawing.Size(127, 37);
            this.RegisterToClass.TabIndex = 1;
            this.RegisterToClass.Text = "Register To Class";
            this.RegisterToClass.UseVisualStyleBackColor = true;
            this.RegisterToClass.Click += new System.EventHandler(this.RegisterToClass_Click);
            // 
            // StudentMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 478);
            this.Controls.Add(this.RegisterToClass);
            this.Controls.Add(this.ShowProgramTraining);
            this.Name = "StudentMain";
            this.Text = "StudentMain";
            this.Load += new System.EventHandler(this.StudentMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShowProgramTraining;
        private System.Windows.Forms.Button RegisterToClass;

    }
}