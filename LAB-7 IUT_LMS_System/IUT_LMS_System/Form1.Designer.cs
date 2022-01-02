namespace IUT_LMS_System
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TNameTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TTypeCB = new System.Windows.Forms.ComboBox();
            this.CTypeCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CCodeTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CSemesterCB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CTitleTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CTeacherCB = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SSemesterCB = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SNameTB = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.SCourseCB = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listBoxStudent = new System.Windows.Forms.ListBox();
            this.LBCBStudent = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.LBCBTeacher = new System.Windows.Forms.ComboBox();
            this.listBoxTeacher = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teacher Info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name :";
            // 
            // TNameTB
            // 
            this.TNameTB.Location = new System.Drawing.Point(201, 91);
            this.TNameTB.Name = "TNameTB";
            this.TNameTB.Size = new System.Drawing.Size(375, 35);
            this.TNameTB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Teacher Type :";
            // 
            // TTypeCB
            // 
            this.TTypeCB.FormattingEnabled = true;
            this.TTypeCB.Items.AddRange(new object[] {
            "Professore",
            "Lecturer"});
            this.TTypeCB.Location = new System.Drawing.Point(201, 172);
            this.TTypeCB.Name = "TTypeCB";
            this.TTypeCB.Size = new System.Drawing.Size(375, 37);
            this.TTypeCB.TabIndex = 5;
            // 
            // CTypeCB
            // 
            this.CTypeCB.FormattingEnabled = true;
            this.CTypeCB.Items.AddRange(new object[] {
            "Lab",
            "Thoery"});
            this.CTypeCB.Location = new System.Drawing.Point(957, 172);
            this.CTypeCB.Name = "CTypeCB";
            this.CTypeCB.Size = new System.Drawing.Size(375, 37);
            this.CTypeCB.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(768, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Course Type :";
            // 
            // CCodeTB
            // 
            this.CCodeTB.Location = new System.Drawing.Point(957, 91);
            this.CCodeTB.Name = "CCodeTB";
            this.CCodeTB.Size = new System.Drawing.Size(375, 35);
            this.CCodeTB.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(768, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Course Code :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(846, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 40);
            this.label6.TabIndex = 6;
            this.label6.Text = "Course Info";
            // 
            // CSemesterCB
            // 
            this.CSemesterCB.FormattingEnabled = true;
            this.CSemesterCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.CSemesterCB.Location = new System.Drawing.Point(957, 326);
            this.CSemesterCB.Name = "CSemesterCB";
            this.CSemesterCB.Size = new System.Drawing.Size(375, 37);
            this.CSemesterCB.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(768, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "Semester :";
            // 
            // CTitleTB
            // 
            this.CTitleTB.Location = new System.Drawing.Point(957, 245);
            this.CTitleTB.Name = "CTitleTB";
            this.CTitleTB.Size = new System.Drawing.Size(375, 35);
            this.CTitleTB.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(768, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 29);
            this.label8.TabIndex = 11;
            this.label8.Text = "Course Title :";
            // 
            // CTeacherCB
            // 
            this.CTeacherCB.FormattingEnabled = true;
            this.CTeacherCB.Location = new System.Drawing.Point(957, 410);
            this.CTeacherCB.Name = "CTeacherCB";
            this.CTeacherCB.Size = new System.Drawing.Size(375, 37);
            this.CTeacherCB.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(768, 410);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 29);
            this.label9.TabIndex = 15;
            this.label9.Text = "Teacher :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1517, 248);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 29);
            this.label12.TabIndex = 22;
            this.label12.Text = "Course :";
            // 
            // SSemesterCB
            // 
            this.SSemesterCB.FormattingEnabled = true;
            this.SSemesterCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.SSemesterCB.Location = new System.Drawing.Point(1706, 172);
            this.SSemesterCB.Name = "SSemesterCB";
            this.SSemesterCB.Size = new System.Drawing.Size(375, 37);
            this.SSemesterCB.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1517, 172);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 29);
            this.label13.TabIndex = 20;
            this.label13.Text = "Semester :";
            // 
            // SNameTB
            // 
            this.SNameTB.Location = new System.Drawing.Point(1706, 91);
            this.SNameTB.Name = "SNameTB";
            this.SNameTB.Size = new System.Drawing.Size(375, 35);
            this.SNameTB.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1517, 94);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 29);
            this.label14.TabIndex = 18;
            this.label14.Text = "Name :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1595, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(222, 40);
            this.label15.TabIndex = 17;
            this.label15.Text = "Student Info";
            // 
            // SCourseCB
            // 
            this.SCourseCB.FormattingEnabled = true;
            this.SCourseCB.Location = new System.Drawing.Point(1706, 245);
            this.SCourseCB.Name = "SCourseCB";
            this.SCourseCB.Size = new System.Drawing.Size(375, 37);
            this.SCourseCB.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 56);
            this.button1.TabIndex = 24;
            this.button1.Text = "ADD TEACHER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddTeacherOnClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1694, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 43);
            this.button2.TabIndex = 25;
            this.button2.Text = "ADD STUDENT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AddStudentOnClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(988, 531);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(229, 42);
            this.button3.TabIndex = 26;
            this.button3.Text = "ADD COURSE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.AddCourse);
            // 
            // listBoxStudent
            // 
            this.listBoxStudent.FormattingEnabled = true;
            this.listBoxStudent.ItemHeight = 29;
            this.listBoxStudent.Location = new System.Drawing.Point(34, 660);
            this.listBoxStudent.Name = "listBoxStudent";
            this.listBoxStudent.Size = new System.Drawing.Size(986, 323);
            this.listBoxStudent.TabIndex = 27;
            // 
            // LBCBStudent
            // 
            this.LBCBStudent.FormattingEnabled = true;
            this.LBCBStudent.Location = new System.Drawing.Point(34, 1047);
            this.LBCBStudent.Name = "LBCBStudent";
            this.LBCBStudent.Size = new System.Drawing.Size(364, 37);
            this.LBCBStudent.TabIndex = 28;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(583, 1047);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(437, 56);
            this.button4.TabIndex = 29;
            this.button4.Text = "Show Student Info";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ShowStudentInfo);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(2101, 1047);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(437, 56);
            this.button5.TabIndex = 32;
            this.button5.Text = "Show Teacher Info";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ShowTeacherInfo);
            // 
            // LBCBTeacher
            // 
            this.LBCBTeacher.FormattingEnabled = true;
            this.LBCBTeacher.Location = new System.Drawing.Point(1552, 1047);
            this.LBCBTeacher.Name = "LBCBTeacher";
            this.LBCBTeacher.Size = new System.Drawing.Size(364, 37);
            this.LBCBTeacher.TabIndex = 31;
            // 
            // listBoxTeacher
            // 
            this.listBoxTeacher.FormattingEnabled = true;
            this.listBoxTeacher.ItemHeight = 29;
            this.listBoxTeacher.Location = new System.Drawing.Point(1552, 660);
            this.listBoxTeacher.Name = "listBoxTeacher";
            this.listBoxTeacher.Size = new System.Drawing.Size(986, 323);
            this.listBoxTeacher.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2884, 1246);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.LBCBTeacher);
            this.Controls.Add(this.listBoxTeacher);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.LBCBStudent);
            this.Controls.Add(this.listBoxStudent);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SCourseCB);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.SSemesterCB);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.SNameTB);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.CTeacherCB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CSemesterCB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CTitleTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CTypeCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CCodeTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TTypeCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TNameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "IUT LMS SYSTEM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TNameTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TTypeCB;
        private System.Windows.Forms.ComboBox CTypeCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CCodeTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CSemesterCB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CTitleTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CTeacherCB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox SSemesterCB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox SNameTB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox SCourseCB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBoxStudent;
        private System.Windows.Forms.ComboBox LBCBStudent;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox LBCBTeacher;
        private System.Windows.Forms.ListBox listBoxTeacher;
    }
}

