namespace TicTacToe
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
            this.A = new System.Windows.Forms.Button();
            this.B = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.F = new System.Windows.Forms.Button();
            this.E = new System.Windows.Forms.Button();
            this.D = new System.Windows.Forms.Button();
            this.I = new System.Windows.Forms.Button();
            this.H = new System.Windows.Forms.Button();
            this.G = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ModeCB = new System.Windows.Forms.ComboBox();
            this.LetterCB = new System.Windows.Forms.ComboBox();
            this.TurnCB = new System.Windows.Forms.ComboBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CSLBL = new System.Windows.Forms.Label();
            this.PSLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(329, 250);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(59, 49);
            this.A.TabIndex = 0;
            this.A.UseVisualStyleBackColor = true;
            this.A.Click += new System.EventHandler(this.ButtonClick);
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(394, 250);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(59, 49);
            this.B.TabIndex = 1;
            this.B.UseVisualStyleBackColor = true;
            this.B.Click += new System.EventHandler(this.ButtonClick);
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(459, 250);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(59, 49);
            this.C.TabIndex = 2;
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.ButtonClick);
            // 
            // F
            // 
            this.F.Location = new System.Drawing.Point(459, 305);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(59, 49);
            this.F.TabIndex = 5;
            this.F.UseVisualStyleBackColor = true;
            this.F.Click += new System.EventHandler(this.ButtonClick);
            // 
            // E
            // 
            this.E.Location = new System.Drawing.Point(394, 305);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(59, 49);
            this.E.TabIndex = 4;
            this.E.UseVisualStyleBackColor = true;
            this.E.Click += new System.EventHandler(this.ButtonClick);
            // 
            // D
            // 
            this.D.Location = new System.Drawing.Point(329, 305);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(59, 49);
            this.D.TabIndex = 3;
            this.D.UseVisualStyleBackColor = true;
            this.D.Click += new System.EventHandler(this.ButtonClick);
            // 
            // I
            // 
            this.I.Location = new System.Drawing.Point(459, 360);
            this.I.Name = "I";
            this.I.Size = new System.Drawing.Size(59, 49);
            this.I.TabIndex = 8;
            this.I.UseVisualStyleBackColor = true;
            this.I.Click += new System.EventHandler(this.ButtonClick);
            // 
            // H
            // 
            this.H.Location = new System.Drawing.Point(394, 360);
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(59, 49);
            this.H.TabIndex = 7;
            this.H.UseVisualStyleBackColor = true;
            this.H.Click += new System.EventHandler(this.ButtonClick);
            // 
            // G
            // 
            this.G.Location = new System.Drawing.Point(329, 360);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(59, 49);
            this.G.TabIndex = 6;
            this.G.UseVisualStyleBackColor = true;
            this.G.Click += new System.EventHandler(this.ButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mode : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Letter : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Turn : ";
            // 
            // ModeCB
            // 
            this.ModeCB.FormattingEnabled = true;
            this.ModeCB.Items.AddRange(new object[] {
            "PlayerVsComputer",
            "PlayerVsDefensiveAI"});
            this.ModeCB.Location = new System.Drawing.Point(61, 46);
            this.ModeCB.Name = "ModeCB";
            this.ModeCB.Size = new System.Drawing.Size(178, 21);
            this.ModeCB.TabIndex = 13;
            // 
            // LetterCB
            // 
            this.LetterCB.FormattingEnabled = true;
            this.LetterCB.Items.AddRange(new object[] {
            "X",
            "O"});
            this.LetterCB.Location = new System.Drawing.Point(61, 83);
            this.LetterCB.Name = "LetterCB";
            this.LetterCB.Size = new System.Drawing.Size(178, 21);
            this.LetterCB.TabIndex = 14;
            // 
            // TurnCB
            // 
            this.TurnCB.FormattingEnabled = true;
            this.TurnCB.Items.AddRange(new object[] {
            "1",
            "2"});
            this.TurnCB.Location = new System.Drawing.Point(61, 119);
            this.TurnCB.Name = "TurnCB";
            this.TurnCB.Size = new System.Drawing.Size(178, 21);
            this.TurnCB.TabIndex = 15;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(94, 164);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 16;
            this.button10.Text = "START";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.StartOnClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 35);
            this.button1.TabIndex = 17;
            this.button1.Text = "RESET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ResetOnClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Computer Score :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(326, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Player Score:";
            // 
            // CSLBL
            // 
            this.CSLBL.AutoSize = true;
            this.CSLBL.Location = new System.Drawing.Point(430, 80);
            this.CSLBL.Name = "CSLBL";
            this.CSLBL.Size = new System.Drawing.Size(0, 13);
            this.CSLBL.TabIndex = 21;
            // 
            // PSLBL
            // 
            this.PSLBL.AutoSize = true;
            this.PSLBL.Location = new System.Drawing.Point(430, 46);
            this.PSLBL.Name = "PSLBL";
            this.PSLBL.Size = new System.Drawing.Size(0, 13);
            this.PSLBL.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 509);
            this.Controls.Add(this.CSLBL);
            this.Controls.Add(this.PSLBL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.TurnCB);
            this.Controls.Add(this.LetterCB);
            this.Controls.Add(this.ModeCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.I);
            this.Controls.Add(this.H);
            this.Controls.Add(this.G);
            this.Controls.Add(this.F);
            this.Controls.Add(this.E);
            this.Controls.Add(this.D);
            this.Controls.Add(this.C);
            this.Controls.Add(this.B);
            this.Controls.Add(this.A);
            this.Name = "Form1";
            this.Text = "TicTacToe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button A;
        private System.Windows.Forms.Button B;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button F;
        private System.Windows.Forms.Button E;
        private System.Windows.Forms.Button D;
        private System.Windows.Forms.Button I;
        private System.Windows.Forms.Button H;
        private System.Windows.Forms.Button G;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ModeCB;
        private System.Windows.Forms.ComboBox LetterCB;
        private System.Windows.Forms.ComboBox TurnCB;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label CSLBL;
        private System.Windows.Forms.Label PSLBL;
    }
}

