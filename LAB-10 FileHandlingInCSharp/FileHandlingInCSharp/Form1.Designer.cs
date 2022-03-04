namespace FileHandlingInCSharp
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EmpEmail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.FirstNameTB = new System.Windows.Forms.TextBox();
            this.LastNameTB = new System.Windows.Forms.TextBox();
            this.AddressTB = new System.Windows.Forms.TextBox();
            this.CityTB = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.Phone1 = new System.Windows.Forms.TextBox();
            this.Zip = new System.Windows.Forms.TextBox();
            this.StateTB = new System.Windows.Forms.TextBox();
            this.CountryTB = new System.Windows.Forms.TextBox();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 29;
            this.listBox.Location = new System.Drawing.Point(41, 85);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(1518, 932);
            this.listBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1599, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Emoployee Email :";
            // 
            // EmpEmail
            // 
            this.EmpEmail.Location = new System.Drawing.Point(1839, 94);
            this.EmpEmail.Name = "EmpEmail";
            this.EmpEmail.Size = new System.Drawing.Size(609, 35);
            this.EmpEmail.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1951, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(288, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ShowEmployeeOnCLick);
            // 
            // FirstNameTB
            // 
            this.FirstNameTB.Location = new System.Drawing.Point(1839, 297);
            this.FirstNameTB.Name = "FirstNameTB";
            this.FirstNameTB.Size = new System.Drawing.Size(609, 35);
            this.FirstNameTB.TabIndex = 4;
            // 
            // LastNameTB
            // 
            this.LastNameTB.Location = new System.Drawing.Point(1839, 382);
            this.LastNameTB.Name = "LastNameTB";
            this.LastNameTB.Size = new System.Drawing.Size(609, 35);
            this.LastNameTB.TabIndex = 5;
            // 
            // AddressTB
            // 
            this.AddressTB.Location = new System.Drawing.Point(1839, 462);
            this.AddressTB.Name = "AddressTB";
            this.AddressTB.Size = new System.Drawing.Size(609, 35);
            this.AddressTB.TabIndex = 7;
            // 
            // CityTB
            // 
            this.CityTB.Location = new System.Drawing.Point(1839, 549);
            this.CityTB.Name = "CityTB";
            this.CityTB.Size = new System.Drawing.Size(609, 35);
            this.CityTB.TabIndex = 8;
            this.CityTB.TextChanged += new System.EventHandler(this.CityTB_TextChanged);
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(1839, 985);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(609, 35);
            this.Phone.TabIndex = 13;
            // 
            // Phone1
            // 
            this.Phone1.Location = new System.Drawing.Point(1839, 884);
            this.Phone1.Name = "Phone1";
            this.Phone1.Size = new System.Drawing.Size(609, 35);
            this.Phone1.TabIndex = 12;
            // 
            // Zip
            // 
            this.Zip.Location = new System.Drawing.Point(1839, 799);
            this.Zip.Name = "Zip";
            this.Zip.Size = new System.Drawing.Size(609, 35);
            this.Zip.TabIndex = 11;
            // 
            // StateTB
            // 
            this.StateTB.Location = new System.Drawing.Point(1839, 713);
            this.StateTB.Name = "StateTB";
            this.StateTB.Size = new System.Drawing.Size(609, 35);
            this.StateTB.TabIndex = 10;
            // 
            // CountryTB
            // 
            this.CountryTB.Location = new System.Drawing.Point(1839, 639);
            this.CountryTB.Name = "CountryTB";
            this.CountryTB.Size = new System.Drawing.Size(609, 35);
            this.CountryTB.TabIndex = 9;
            // 
            // EmailTB
            // 
            this.EmailTB.Location = new System.Drawing.Point(1839, 1071);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(609, 35);
            this.EmailTB.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2671, 1255);
            this.Controls.Add(this.EmailTB);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Phone1);
            this.Controls.Add(this.Zip);
            this.Controls.Add(this.StateTB);
            this.Controls.Add(this.CountryTB);
            this.Controls.Add(this.CityTB);
            this.Controls.Add(this.AddressTB);
            this.Controls.Add(this.LastNameTB);
            this.Controls.Add(this.FirstNameTB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EmpEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmpEmail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox FirstNameTB;
        private System.Windows.Forms.TextBox LastNameTB;
        private System.Windows.Forms.TextBox AddressTB;
        private System.Windows.Forms.TextBox CityTB;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.TextBox Phone1;
        private System.Windows.Forms.TextBox Zip;
        private System.Windows.Forms.TextBox StateTB;
        private System.Windows.Forms.TextBox CountryTB;
        private System.Windows.Forms.TextBox EmailTB;
    }
}

