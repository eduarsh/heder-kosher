namespace Heder_Kosher
{
    partial class AddStudent
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
            this.Details5 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Details7 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.details6 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Details4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Details3 = new System.Windows.Forms.TextBox();
            this.Details2 = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.Details1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Details5
            // 
            this.Details5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Details5.FormattingEnabled = true;
            this.Details5.Items.AddRange(new object[] {
            "M",
            "F"});
            this.Details5.Location = new System.Drawing.Point(148, 185);
            this.Details5.Name = "Details5";
            this.Details5.Size = new System.Drawing.Size(121, 21);
            this.Details5.TabIndex = 41;
            this.Details5.SelectedIndexChanged += new System.EventHandler(this.Details5_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "First Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Mail";
            // 
            // Details7
            // 
            this.Details7.Location = new System.Drawing.Point(148, 255);
            this.Details7.Name = "Details7";
            this.Details7.Size = new System.Drawing.Size(141, 20);
            this.Details7.TabIndex = 38;
            this.Details7.TextChanged += new System.EventHandler(this.Details7_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Phone";
            // 
            // details6
            // 
            this.details6.Location = new System.Drawing.Point(148, 220);
            this.details6.Name = "details6";
            this.details6.Size = new System.Drawing.Size(141, 20);
            this.details6.TabIndex = 36;
            this.details6.TextChanged += new System.EventHandler(this.details6_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Password";
            // 
            // Details4
            // 
            this.Details4.Location = new System.Drawing.Point(148, 150);
            this.Details4.Name = "Details4";
            this.Details4.Size = new System.Drawing.Size(141, 20);
            this.Details4.TabIndex = 33;
            this.Details4.UseSystemPasswordChar = true;
            this.Details4.TextChanged += new System.EventHandler(this.Details4_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Last Name";
            // 
            // Details3
            // 
            this.Details3.Location = new System.Drawing.Point(148, 111);
            this.Details3.Name = "Details3";
            this.Details3.Size = new System.Drawing.Size(141, 20);
            this.Details3.TabIndex = 31;
            this.Details3.TextChanged += new System.EventHandler(this.Details3_TextChanged);
            // 
            // Details2
            // 
            this.Details2.Location = new System.Drawing.Point(148, 76);
            this.Details2.Name = "Details2";
            this.Details2.Size = new System.Drawing.Size(141, 20);
            this.Details2.TabIndex = 30;
            this.Details2.TextChanged += new System.EventHandler(this.Details2_TextChanged);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(40, 41);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(58, 13);
            this.ID.TabIndex = 29;
            this.ID.Text = "Student ID";
            // 
            // Details1
            // 
            this.Details1.Location = new System.Drawing.Point(148, 41);
            this.Details1.Name = "Details1";
            this.Details1.Size = new System.Drawing.Size(141, 20);
            this.Details1.TabIndex = 28;
            this.Details1.TextChanged += new System.EventHandler(this.Details1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Expired Date ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "Medican Expired Date ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(87, 377);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(125, 36);
            this.Add.TabIndex = 46;
            this.Add.Text = "ADD";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(148, 291);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 47;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(148, 322);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 48;
            // 
            // AddStudentBySecratry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 499);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Details5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Details7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.details6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Details4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Details3);
            this.Controls.Add(this.Details2);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Details1);
            this.Name = "AddStudentBySecratry";
            this.Text = "AddRemoveStudentBySecratry";
            this.Load += new System.EventHandler(this.AddRemoveStudentBySecratry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Details5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Details7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox details6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Details4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Details3;
        private System.Windows.Forms.TextBox Details2;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox Details1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}