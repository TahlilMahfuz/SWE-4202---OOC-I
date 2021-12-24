namespace Hotel_Management_System_Extended
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
            this.RoomChoice = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.Departure = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Entry = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.UserID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.UserNameTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.UserAddressTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.UserIDTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Owner_statusTB = new System.Windows.Forms.ComboBox();
            this.Owner_BookingIDTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UserContactTB = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.CurrentBalanceLBL = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.SeeAddressLBL = new System.Windows.Forms.Label();
            this.SeeNameLBL = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.StatusLBL = new System.Windows.Forms.Label();
            this.RoomNoLBL = new System.Windows.Forms.Label();
            this.AmountLBL = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.AddressLBL = new System.Windows.Forms.Label();
            this.UserNameLBL = new System.Windows.Forms.Label();
            this.SeeBookingIDTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RoomChoice
            // 
            this.RoomChoice.FormattingEnabled = true;
            this.RoomChoice.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Suite Deluxe"});
            this.RoomChoice.Location = new System.Drawing.Point(1933, 200);
            this.RoomChoice.Name = "RoomChoice";
            this.RoomChoice.Size = new System.Drawing.Size(337, 37);
            this.RoomChoice.TabIndex = 105;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(2317, 196);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 29);
            this.label13.TabIndex = 104;
            this.label13.Text = "Quantity :";
            // 
            // Quantity
            // 
            this.Quantity.FormattingEnabled = true;
            this.Quantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.Quantity.Location = new System.Drawing.Point(2462, 188);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(337, 37);
            this.Quantity.TabIndex = 103;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(2043, 455);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(454, 46);
            this.button3.TabIndex = 102;
            this.button3.Text = "Place Booking";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.PlaceBookingOnClick);
            // 
            // Departure
            // 
            this.Departure.Location = new System.Drawing.Point(1933, 359);
            this.Departure.Name = "Departure";
            this.Departure.Size = new System.Drawing.Size(337, 35);
            this.Departure.TabIndex = 99;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1696, 368);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(188, 29);
            this.label11.TabIndex = 98;
            this.label11.Text = "Departure Date :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1696, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 29);
            this.label8.TabIndex = 96;
            this.label8.Text = "Room Choice :";
            // 
            // Entry
            // 
            this.Entry.Location = new System.Drawing.Point(1933, 271);
            this.Entry.Name = "Entry";
            this.Entry.Size = new System.Drawing.Size(337, 35);
            this.Entry.TabIndex = 95;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1696, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 29);
            this.label9.TabIndex = 94;
            this.label9.Text = "Entry Date :";
            // 
            // UserID
            // 
            this.UserID.Location = new System.Drawing.Point(1933, 119);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(337, 35);
            this.UserID.TabIndex = 93;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1696, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 29);
            this.label10.TabIndex = 92;
            this.label10.Text = "User ID :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1150, 455);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(454, 46);
            this.button2.TabIndex = 91;
            this.button2.Text = "Create Account";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.CreateAccountOnClick);
            // 
            // UserNameTB
            // 
            this.UserNameTB.Location = new System.Drawing.Point(1267, 194);
            this.UserNameTB.Name = "UserNameTB";
            this.UserNameTB.Size = new System.Drawing.Size(337, 35);
            this.UserNameTB.TabIndex = 90;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1088, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 29);
            this.label7.TabIndex = 89;
            this.label7.Text = "Name :";
            // 
            // UserAddressTB
            // 
            this.UserAddressTB.Location = new System.Drawing.Point(1267, 343);
            this.UserAddressTB.Name = "UserAddressTB";
            this.UserAddressTB.Size = new System.Drawing.Size(337, 35);
            this.UserAddressTB.TabIndex = 88;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1088, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 29);
            this.label6.TabIndex = 87;
            this.label6.Text = "Address :";
            // 
            // UserIDTB
            // 
            this.UserIDTB.Location = new System.Drawing.Point(1267, 122);
            this.UserIDTB.Name = "UserIDTB";
            this.UserIDTB.Size = new System.Drawing.Size(337, 35);
            this.UserIDTB.TabIndex = 86;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1088, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 29);
            this.label4.TabIndex = 85;
            this.label4.Text = "User ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1836, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 36);
            this.label5.TabIndex = 84;
            this.label5.Text = "User Selection";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(454, 42);
            this.button1.TabIndex = 83;
            this.button1.Text = "Set Status";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SetStatusOnClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 29);
            this.label3.TabIndex = 82;
            this.label3.Text = "Status :";
            // 
            // Owner_statusTB
            // 
            this.Owner_statusTB.FormattingEnabled = true;
            this.Owner_statusTB.Items.AddRange(new object[] {
            "Pending ",
            "Confirmed"});
            this.Owner_statusTB.Location = new System.Drawing.Point(149, 180);
            this.Owner_statusTB.Name = "Owner_statusTB";
            this.Owner_statusTB.Size = new System.Drawing.Size(337, 37);
            this.Owner_statusTB.TabIndex = 81;
            // 
            // Owner_BookingIDTB
            // 
            this.Owner_BookingIDTB.Location = new System.Drawing.Point(149, 110);
            this.Owner_BookingIDTB.Name = "Owner_BookingIDTB";
            this.Owner_BookingIDTB.Size = new System.Drawing.Size(337, 35);
            this.Owner_BookingIDTB.TabIndex = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 29);
            this.label2.TabIndex = 79;
            this.label2.Text = "Booking ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(381, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 36);
            this.label1.TabIndex = 78;
            this.label1.Text = "Owner Selection";
            // 
            // UserContactTB
            // 
            this.UserContactTB.Location = new System.Drawing.Point(1267, 268);
            this.UserContactTB.Name = "UserContactTB";
            this.UserContactTB.Size = new System.Drawing.Size(337, 35);
            this.UserContactTB.TabIndex = 112;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1088, 268);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(150, 29);
            this.label17.TabIndex = 111;
            this.label17.Text = "Contact No. :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 553);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(197, 29);
            this.label12.TabIndex = 113;
            this.label12.Text = "Current Balance :";
            // 
            // CurrentBalanceLBL
            // 
            this.CurrentBalanceLBL.AutoSize = true;
            this.CurrentBalanceLBL.Location = new System.Drawing.Point(289, 553);
            this.CurrentBalanceLBL.Name = "CurrentBalanceLBL";
            this.CurrentBalanceLBL.Size = new System.Drawing.Size(197, 29);
            this.CurrentBalanceLBL.TabIndex = 114;
            this.CurrentBalanceLBL.Text = "Current Balance :";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 29;
            this.listBox.Location = new System.Drawing.Point(294, 650);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(825, 352);
            this.listBox.TabIndex = 115;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(462, 1065);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(454, 42);
            this.button4.TabIndex = 116;
            this.button4.Text = "Show Room Details";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ShowRoomsOnClick);
            // 
            // SeeAddressLBL
            // 
            this.SeeAddressLBL.AutoSize = true;
            this.SeeAddressLBL.Location = new System.Drawing.Point(1262, 863);
            this.SeeAddressLBL.Name = "SeeAddressLBL";
            this.SeeAddressLBL.Size = new System.Drawing.Size(106, 29);
            this.SeeAddressLBL.TabIndex = 120;
            this.SeeAddressLBL.Text = "Amount :";
            // 
            // SeeNameLBL
            // 
            this.SeeNameLBL.AutoSize = true;
            this.SeeNameLBL.Location = new System.Drawing.Point(2156, 650);
            this.SeeNameLBL.Name = "SeeNameLBL";
            this.SeeNameLBL.Size = new System.Drawing.Size(147, 29);
            this.SeeNameLBL.TabIndex = 119;
            this.SeeNameLBL.Text = "User Name :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(1262, 791);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(134, 29);
            this.label20.TabIndex = 118;
            this.label20.Text = "Room No. :";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(1262, 650);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(141, 29);
            this.label21.TabIndex = 117;
            this.label21.Text = "booking ID :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1262, 721);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 29);
            this.label15.TabIndex = 121;
            this.label15.Text = "Status :";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1734, 1065);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(454, 42);
            this.button5.TabIndex = 122;
            this.button5.Text = "See Order Details";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.SeeOrderOnClick);
            // 
            // StatusLBL
            // 
            this.StatusLBL.AutoSize = true;
            this.StatusLBL.Location = new System.Drawing.Point(1445, 721);
            this.StatusLBL.Name = "StatusLBL";
            this.StatusLBL.Size = new System.Drawing.Size(91, 29);
            this.StatusLBL.TabIndex = 124;
            this.StatusLBL.Text = "Status :";
            // 
            // RoomNoLBL
            // 
            this.RoomNoLBL.AutoSize = true;
            this.RoomNoLBL.Location = new System.Drawing.Point(1445, 791);
            this.RoomNoLBL.Name = "RoomNoLBL";
            this.RoomNoLBL.Size = new System.Drawing.Size(91, 29);
            this.RoomNoLBL.TabIndex = 125;
            this.RoomNoLBL.Text = "Status :";
            // 
            // AmountLBL
            // 
            this.AmountLBL.AutoSize = true;
            this.AmountLBL.Location = new System.Drawing.Point(1445, 863);
            this.AmountLBL.Name = "AmountLBL";
            this.AmountLBL.Size = new System.Drawing.Size(91, 29);
            this.AmountLBL.TabIndex = 126;
            this.AmountLBL.Text = "Status :";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(2156, 721);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(114, 29);
            this.label23.TabIndex = 127;
            this.label23.Text = "Address :";
            // 
            // AddressLBL
            // 
            this.AddressLBL.AutoSize = true;
            this.AddressLBL.Location = new System.Drawing.Point(2350, 721);
            this.AddressLBL.Name = "AddressLBL";
            this.AddressLBL.Size = new System.Drawing.Size(114, 29);
            this.AddressLBL.TabIndex = 129;
            this.AddressLBL.Text = "Address :";
            // 
            // UserNameLBL
            // 
            this.UserNameLBL.AutoSize = true;
            this.UserNameLBL.Location = new System.Drawing.Point(2350, 650);
            this.UserNameLBL.Name = "UserNameLBL";
            this.UserNameLBL.Size = new System.Drawing.Size(147, 29);
            this.UserNameLBL.TabIndex = 128;
            this.UserNameLBL.Text = "User Name :";
            // 
            // SeeBookingIDTB
            // 
            this.SeeBookingIDTB.Location = new System.Drawing.Point(1450, 644);
            this.SeeBookingIDTB.Name = "SeeBookingIDTB";
            this.SeeBookingIDTB.Size = new System.Drawing.Size(337, 35);
            this.SeeBookingIDTB.TabIndex = 130;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2874, 1259);
            this.Controls.Add(this.SeeBookingIDTB);
            this.Controls.Add(this.AddressLBL);
            this.Controls.Add(this.UserNameLBL);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.AmountLBL);
            this.Controls.Add(this.RoomNoLBL);
            this.Controls.Add(this.StatusLBL);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.SeeAddressLBL);
            this.Controls.Add(this.SeeNameLBL);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.CurrentBalanceLBL);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.UserContactTB);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.RoomChoice);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Departure);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Entry);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.UserNameTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.UserAddressTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.UserIDTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Owner_statusTB);
            this.Controls.Add(this.Owner_BookingIDTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox RoomChoice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox Quantity;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox Departure;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Entry;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox UserID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox UserNameTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox UserAddressTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox UserIDTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Owner_statusTB;
        private System.Windows.Forms.TextBox Owner_BookingIDTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserContactTB;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label CurrentBalanceLBL;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label SeeAddressLBL;
        private System.Windows.Forms.Label SeeNameLBL;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label StatusLBL;
        private System.Windows.Forms.Label RoomNoLBL;
        private System.Windows.Forms.Label AmountLBL;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label AddressLBL;
        private System.Windows.Forms.Label UserNameLBL;
        private System.Windows.Forms.TextBox SeeBookingIDTB;
    }
}

