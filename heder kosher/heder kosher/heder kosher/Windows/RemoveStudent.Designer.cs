namespace Heder_Kosher
{
    partial class RemoveStudent
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
            this.studentID = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Remove = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // studentID
            // 
            this.studentID.AutoSize = true;
            this.studentID.Location = new System.Drawing.Point(348, 22);
            this.studentID.Name = "studentID";
            this.studentID.Size = new System.Drawing.Size(58, 13);
            this.studentID.TabIndex = 30;
            this.studentID.Text = "Student ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(312, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 29;
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(512, 29);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(141, 36);
            this.Remove.TabIndex = 28;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(944, 288);
            this.dataGridView1.TabIndex = 31;
            // 
            // RemoveStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 428);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.studentID);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Remove);
            this.Name = "RemoveStudent";
            this.Text = "RemoveStudentBySecretary";
            this.Load += new System.EventHandler(this.RemoveStudentBySecretary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}