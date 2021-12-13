namespace Pharmacy_Management_System
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.M_Name = new System.Windows.Forms.TextBox();
            this.M_Quantity = new System.Windows.Forms.TextBox();
            this.M_Price = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.B_Quantity = new System.Windows.Forms.TextBox();
            this.B_M_Name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.M_AvailableLBL = new System.Windows.Forms.Label();
            this.SearchName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.TotalSoldLBL = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medicine and Other Accessories";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price per quantity:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // M_Name
            // 
            this.M_Name.Location = new System.Drawing.Point(250, 96);
            this.M_Name.Name = "M_Name";
            this.M_Name.Size = new System.Drawing.Size(337, 35);
            this.M_Name.TabIndex = 7;
            // 
            // M_Quantity
            // 
            this.M_Quantity.Location = new System.Drawing.Point(250, 163);
            this.M_Quantity.Name = "M_Quantity";
            this.M_Quantity.Size = new System.Drawing.Size(337, 35);
            this.M_Quantity.TabIndex = 8;
            // 
            // M_Price
            // 
            this.M_Price.Location = new System.Drawing.Point(250, 241);
            this.M_Price.Name = "M_Price";
            this.M_Price.Size = new System.Drawing.Size(337, 35);
            this.M_Price.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 63);
            this.button1.TabIndex = 11;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddMedicineOrOthers);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(898, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 63);
            this.button2.TabIndex = 21;
            this.button2.Text = "TOTAL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ShowTotal);
            // 
            // B_Quantity
            // 
            this.B_Quantity.Location = new System.Drawing.Point(945, 233);
            this.B_Quantity.Name = "B_Quantity";
            this.B_Quantity.Size = new System.Drawing.Size(337, 35);
            this.B_Quantity.TabIndex = 18;
            // 
            // B_M_Name
            // 
            this.B_M_Name.Location = new System.Drawing.Point(945, 166);
            this.B_M_Name.Name = "B_M_Name";
            this.B_M_Name.Size = new System.Drawing.Size(337, 35);
            this.B_M_Name.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(707, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 29);
            this.label9.TabIndex = 14;
            this.label9.Text = "Quantity:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(707, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(224, 29);
            this.label10.TabIndex = 13;
            this.label10.Text = "Name of accessory:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(706, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(326, 36);
            this.label11.TabIndex = 12;
            this.label11.Text = "Buyer\'s Requirements";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(945, 99);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(337, 35);
            this.textBox5.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(707, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 29);
            this.label7.TabIndex = 22;
            this.label7.Text = "Buyer\'s Name:";
            // 
            // M_AvailableLBL
            // 
            this.M_AvailableLBL.AutoSize = true;
            this.M_AvailableLBL.Location = new System.Drawing.Point(246, 698);
            this.M_AvailableLBL.Name = "M_AvailableLBL";
            this.M_AvailableLBL.Size = new System.Drawing.Size(111, 29);
            this.M_AvailableLBL.TabIndex = 38;
            this.M_AvailableLBL.Text = "Available";
            // 
            // SearchName
            // 
            this.SearchName.Location = new System.Drawing.Point(251, 629);
            this.SearchName.Name = "SearchName";
            this.SearchName.Size = new System.Drawing.Size(337, 35);
            this.SearchName.TabIndex = 37;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 629);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(199, 29);
            this.label15.TabIndex = 36;
            this.label15.Text = "Name of Product:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(205, 822);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(189, 63);
            this.button4.TabIndex = 35;
            this.button4.Text = "SHOW";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.CheckAvailableAmount);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 698);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(117, 29);
            this.label16.TabIndex = 34;
            this.label16.Text = "Available:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(12, 558);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(483, 36);
            this.label17.TabIndex = 33;
            this.label17.Text = "Check the amount of accessories";
            // 
            // TotalSoldLBL
            // 
            this.TotalSoldLBL.AutoSize = true;
            this.TotalSoldLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSoldLBL.Location = new System.Drawing.Point(941, 629);
            this.TotalSoldLBL.Name = "TotalSoldLBL";
            this.TotalSoldLBL.Size = new System.Drawing.Size(0, 38);
            this.TotalSoldLBL.TabIndex = 44;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(899, 822);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(275, 63);
            this.button3.TabIndex = 41;
            this.button3.Text = "CHECK PROFIT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.CheckProfitOnClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(707, 629);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 38);
            this.label12.TabIndex = 40;
            this.label12.Text = "Amount:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(706, 558);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(267, 36);
            this.label14.TabIndex = 39;
            this.label14.Text = "Check Total Sold ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 965);
            this.Controls.Add(this.TotalSoldLBL);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.M_AvailableLBL);
            this.Controls.Add(this.SearchName);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.B_Quantity);
            this.Controls.Add(this.B_M_Name);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.M_Price);
            this.Controls.Add(this.M_Quantity);
            this.Controls.Add(this.M_Name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Pharmacy Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox M_Name;
        private System.Windows.Forms.TextBox M_Quantity;
        private System.Windows.Forms.TextBox M_Price;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox B_Quantity;
        private System.Windows.Forms.TextBox B_M_Name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label M_AvailableLBL;
        private System.Windows.Forms.TextBox SearchName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label TotalSoldLBL;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
    }
}

