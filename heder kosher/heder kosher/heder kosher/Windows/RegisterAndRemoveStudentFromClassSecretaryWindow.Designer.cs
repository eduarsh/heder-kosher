﻿namespace Heder_Kosher
{
    partial class RegisterAndRemoveStudentFromClassSecretaryWindow
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.studentID = new System.Windows.Forms.Label();
            this.coursID = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.showAllClass = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // studentID
            // 
            this.studentID.AutoSize = true;
            this.studentID.Location = new System.Drawing.Point(12, 51);
            this.studentID.Name = "studentID";
            this.studentID.Size = new System.Drawing.Size(58, 13);
            this.studentID.TabIndex = 1;
            this.studentID.Text = "Student ID";
            // 
            // coursID
            // 
            this.coursID.AutoSize = true;
            this.coursID.Location = new System.Drawing.Point(237, 47);
            this.coursID.Name = "coursID";
            this.coursID.Size = new System.Drawing.Size(46, 13);
            this.coursID.TabIndex = 3;
            this.coursID.Text = "Class ID";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(305, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Student ID";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(80, 394);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(451, 37);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 6;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(220, 391);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(75, 23);
            this.Remove.TabIndex = 7;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // showAllClass
            // 
            this.showAllClass.Location = new System.Drawing.Point(583, 144);
            this.showAllClass.Name = "showAllClass";
            this.showAllClass.Size = new System.Drawing.Size(75, 58);
            this.showAllClass.TabIndex = 8;
            this.showAllClass.Text = "Show All Class\'s";
            this.showAllClass.UseVisualStyleBackColor = true;
            this.showAllClass.Click += new System.EventHandler(this.showAllClass_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(583, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 54);
            this.button1.TabIndex = 9;
            this.button1.Text = "Show All Students in Class\'s";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(565, 287);
            this.dataGridView1.TabIndex = 10;
            // 
            // RegisterAndRemoveStudentFromClassSecretaryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 451);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.showAllClass);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.coursID);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.studentID);
            this.Controls.Add(this.textBox1);
            this.Name = "RegisterAndRemoveStudentFromClassSecretaryWindow";
            this.Text = "RegisterAndRemoveFromClass";
            this.Load += new System.EventHandler(this.RegisterAndRemoveStudentFromClassSecretaryWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label studentID;
        private System.Windows.Forms.Label coursID;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button showAllClass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}