namespace Heder_Kosher
{
    partial class ManagerMain
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
            this.AddRemoveEmp = new System.Windows.Forms.Button();
            this.AddRemoveCourse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddRemoveEmp
            // 
            this.AddRemoveEmp.Location = new System.Drawing.Point(23, 38);
            this.AddRemoveEmp.Name = "AddRemoveEmp";
            this.AddRemoveEmp.Size = new System.Drawing.Size(133, 35);
            this.AddRemoveEmp.TabIndex = 0;
            this.AddRemoveEmp.Text = "Add/Remove Employee";
            this.AddRemoveEmp.UseVisualStyleBackColor = true;
            this.AddRemoveEmp.Click += new System.EventHandler(this.AddRemoveEmp_Click);
            // 
            // AddRemoveCourse
            // 
            this.AddRemoveCourse.Location = new System.Drawing.Point(23, 101);
            this.AddRemoveCourse.Name = "AddRemoveCourse";
            this.AddRemoveCourse.Size = new System.Drawing.Size(133, 35);
            this.AddRemoveCourse.TabIndex = 1;
            this.AddRemoveCourse.Text = "Add/Remove Class";
            this.AddRemoveCourse.UseVisualStyleBackColor = true;
            this.AddRemoveCourse.Click += new System.EventHandler(this.AddRemoveCourse_Click);
            // 
            // ManagerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 442);
            this.Controls.Add(this.AddRemoveCourse);
            this.Controls.Add(this.AddRemoveEmp);
            this.Name = "ManagerMain";
            this.Text = "ManagerMain";
            this.Load += new System.EventHandler(this.ManagerMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddRemoveEmp;
        private System.Windows.Forms.Button AddRemoveCourse;
    }
}