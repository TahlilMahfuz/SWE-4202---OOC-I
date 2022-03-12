using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        string mode, letter,letterC,t;
        bool turn=true;
        int turnCount = 0;
        int playerScore=0, computerScore=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void StartOnClick(object sender, EventArgs e)
        {
            mode = ModeCB.Text;
            letter = LetterCB.Text;
            t=TurnCB.Text;
            if (letter == "X")
            {
                letterC = "O";
            }
            else { letterC = "X"; }
            if (t == "1")
            {
                turn = true;
            }
            else { A.Text = letterC; A.Enabled = false; }
            MessageBox.Show("LET'S START THE GAME!");
        }

        private void ResetOnClick(object sender, EventArgs e)
        {
            mode = ""; letter = ""; letterC = ""; t="";
            turn = true;
            turnCount = 0;
            foreach(Control c in Controls)
            {
                c.Enabled = true;
                if(c.Text=="X"|| c.Text == "O") { c.Text = ""; }
                ModeCB.Text = "";
                LetterCB.Text = "";
                TurnCB.Text = "";
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(mode == "PlayerVsComputer")
            {
                if (turn)//Player
                {
                    button.Text = letter;
                    button.Enabled = false;
                    turn=!turn;
                    turnCount++;

                    for(int i = 0; i < 100000; i++)
                    {
                        Random r = new Random();
                        int num = r.Next(0, 9);
                        if(num==0 && A.Text=="")
                        {
                            A.Text = letterC;
                            A.Enabled = false; turn = !turn; turnCount++;
                            break;
                        }
                        else if(num==1&& B.Text=="")
                        {
                            B.Text=letterC;
                            B.Enabled = false; turn = !turn; turnCount++;
                            break;
                        }
                        else if (num == 2 && C.Text == "")
                        {
                            C.Text = letterC;
                            C.Enabled = false; turn = !turn; turnCount++;
                            break;
                        }
                        else if (num == 3 && D.Text == "")
                        {
                            D.Text = letterC;
                            D.Enabled = false; turn = !turn; turnCount++;
                            break;
                        }
                        else if (num == 4 && E.Text == "")
                        {
                            E.Text = letterC;
                            E.Enabled = false; turn = !turn; turnCount++;
                            break;
                        }
                        else if (num == 5 && F.Text == "")
                        {
                            F.Text = letterC;
                            F.Enabled = false; turn = !turn; turnCount++;
                            break;
                        }
                        else if (num == 6 && G.Text == "")
                        {
                            G.Text = letterC;
                            G.Enabled = false; turn = !turn; turnCount++;
                            break;
                        }
                        else if (num == 7 && H.Text == "")
                        {
                            H.Text = letterC;
                            H.Enabled = false; turn = !turn; turnCount++;
                            break;
                        }
                        else if (num == 8 && I.Text == "")
                        {
                            I.Text = letterC;
                            I.Enabled = false; turn = !turn; turnCount++;
                            break;
                        }
                    }
                }
                else//computer
                {
                    for (int i=0;i<100000 ;i++ )
                    {
                        Random r = new Random();
                        int num = r.Next(0, 9);
                        if (num == 0 && A.Text == "")
                        {
                            A.Text = letterC;
                            A.Enabled = false; turn = !turn; turnCount++;
                            break;
                        }
                        else if (num == 1 && B.Text == "")
                        {
                            B.Text = letterC;
                            B.Enabled = false; turn = !turn; turnCount++;
                            break;
                        }
                        else if (num == 2 && C.Text == "")
                        {
                            C.Text = letterC;
                            C.Enabled = false; turn = !turn; turnCount++;
                            break;
                        }
                        else if (num == 3 && D.Text == "")
                        {
                            D.Text = letterC;
                            D.Enabled = false; turn = !turn; turnCount++;
                            break;
                        }
                        else if (num == 4 && E.Text == "")
                        {
                            E.Text = letterC;
                            E.Enabled = false; turn = !turn; turnCount++;
                            break;
                        }
                        else if (num == 5 && F.Text == "")
                        {
                            F.Text = letterC;
                            F.Enabled = false; turn = !turn; turnCount++;
                            break;
                        }
                        else if (num == 6 && G.Text == "")
                        {
                            G.Text = letterC;
                            G.Enabled = false; turn = !turn; turnCount++;
                            break;
                        }
                        else if (num == 7 && H.Text == "")
                        {
                            H.Text = letterC;
                            H.Enabled = false; turn = !turn; turnCount++;
                            break;
                        }
                        else if (num == 8 && I.Text == "")
                        {
                            I.Text = letterC;
                            I.Enabled = false; turn = !turn; turnCount++;
                            break;
                        }
                    }
                }
                string s = CheckWinner();
                if (s == "X") 
                {
                    foreach (Control c in Controls)
                    {
                        if (c.Text != "RESET")
                        {
                            c.Enabled = false;
                        }
                    }
                    MessageBox.Show("X is the winner");
                    if (letterC == "X") { computerScore++; } else { playerScore++; } PSLBL.Text = Convert.ToString(playerScore);CSLBL.Text = Convert.ToString(computerScore); 
                }
                else if (s == "O") 
                {
                    foreach (Control c in Controls)
                    {
                        if (c.Text != "RESET")
                        {
                            c.Enabled = false;
                        }
                    }
                    MessageBox.Show("O is the winner"); if (letterC == "O") { computerScore++; } else { playerScore++; } PSLBL.Text = Convert.ToString(playerScore); CSLBL.Text = Convert.ToString(computerScore); }
                else if (s == "D") 
                {
                    foreach (Control c in Controls)
                    {
                        if (c.Text != "RESET")
                        {
                            c.Enabled = false;
                        }
                    }
                    MessageBox.Show("Its a draw!"); 
                }
                else if (s == "") {; }
            }
            if(mode == "PlayerVsDefensiveAI")
            {
                if(turn)//player
                {
                    button.Text = letter;
                    button.Enabled = false;
                    turn = !turn;
                    turnCount++;

                    if(t=="1" && (A.Text==letter || C.Text == letter ||G.Text == letter || I.Text == letter) && turnCount==1 && E.Text =="")
                    {
                        turnCount++;
                        E.Text = letterC;
                        E.Enabled=false;
                        turn = !turn;
                    }
                    else if(t == "1" && (A.Text == letter || C.Text == letter || G.Text == letter || I.Text == letter) && turnCount == 1 && E.Text == letter)
                    {
                        for (int i = 0; i < 100000; i++)
                        {
                            Random r = new Random();
                            int num = r.Next(0, 9);
                            if (num == 0 && A.Text == "")
                            {
                                A.Text = letterC;
                                A.Enabled = false; turn = !turn; turnCount++;
                                break;
                            }
                            else if (num == 1 && B.Text == "")
                            {
                                B.Text = letterC;
                                B.Enabled = false; turn = !turn; turnCount++;
                                break;
                            }
                            else if (num == 2 && C.Text == "")
                            {
                                C.Text = letterC;
                                C.Enabled = false; turn = !turn; turnCount++;
                                break;
                            }
                            else if (num == 3 && D.Text == "")
                            {
                                D.Text = letterC;
                                D.Enabled = false; turn = !turn; turnCount++;
                                break;
                            }
                            else if (num == 4 && E.Text == "")
                            {
                                E.Text = letterC;
                                E.Enabled = false; turn = !turn; turnCount++;
                                break;
                            }
                            else if (num == 5 && F.Text == "")
                            {
                                F.Text = letterC;
                                F.Enabled = false; turn = !turn; turnCount++;
                                break;
                            }
                            else if (num == 6 && G.Text == "")
                            {
                                G.Text = letterC;
                                G.Enabled = false; turn = !turn; turnCount++;
                                break;
                            }
                            else if (num == 7 && H.Text == "")
                            {
                                H.Text = letterC;
                                H.Enabled = false; turn = !turn; turnCount++;
                                break;
                            }
                            else if (num == 8 && I.Text == "")
                            {
                                I.Text = letterC;
                                I.Enabled = false; turn = !turn; turnCount++;
                                break;
                            }
                        }

                    }
                    else
                    {
                        int ctw = ComputerToWin();
                        if (ctw == 0 && A.Text == "") { A.Text = letterC; turnCount++; }
                        else if (ctw == 1 && B.Text == "") { B.Text = letterC; B.Enabled = false; turnCount++;turn = !turn; }
                        else if (ctw == 2 && C.Text == "") { C.Text = letterC; C.Enabled = false; turnCount++; turn = !turn; }
                        else if (ctw == 3 && D.Text == "") { D.Text = letterC; D.Enabled = false; turnCount++; turn = !turn; }
                        else if (ctw == 4 && E.Text == "") { E.Text = letterC; E.Enabled = false; turnCount++; turn = !turn; }
                        else if (ctw == 5 && F.Text == "") { F.Text = letterC; F.Enabled = false; turnCount++; turn = !turn; }
                        else if (ctw == 6 && G.Text == "") { G.Text = letterC; G.Enabled = false; turnCount++; turn = !turn; }
                        else if (ctw == 7 && H.Text == "") { H.Text = letterC; H.Enabled = false; turnCount++; turn = !turn; }
                        else if (ctw == 8 && I.Text == "") { I.Text = letterC; I.Enabled = false; turnCount++; turn = !turn; }
                        else if (ctw == 15)
                        {
                            for (int i = 0; i < 100000; i++)
                            {
                                Random r = new Random();
                                int num = r.Next(0, 9);
                                if (num == 0 && A.Text == "")
                                {
                                    A.Text = letterC;
                                    A.Enabled = false; turn = !turn; turnCount++;
                                    break;
                                }
                                else if (num == 1 && B.Text == "")
                                {
                                    B.Text = letterC;
                                    B.Enabled = false; turn = !turn; turnCount++;
                                    break;
                                }
                                else if (num == 2 && C.Text == "")
                                {
                                    C.Text = letterC;
                                    C.Enabled = false; turn = !turn; turnCount++;
                                    break;
                                }
                                else if (num == 3 && D.Text == "")
                                {
                                    D.Text = letterC;
                                    D.Enabled = false; turn = !turn; turnCount++;
                                    break;
                                }
                                else if (num == 4 && E.Text == "")
                                {
                                    E.Text = letterC;
                                    E.Enabled = false; turn = !turn; turnCount++;
                                    break;
                                }
                                else if (num == 5 && F.Text == "")
                                {
                                    F.Text = letterC;
                                    F.Enabled = false; turn = !turn; turnCount++;
                                    break;
                                }
                                else if (num == 6 && G.Text == "")
                                {
                                    G.Text = letterC;
                                    G.Enabled = false; turn = !turn; turnCount++;
                                    break;
                                }
                                else if (num == 7 && H.Text == "")
                                {
                                    H.Text = letterC;
                                    H.Enabled = false; turn = !turn; turnCount++;
                                    break;
                                }
                                else if (num == 8 && I.Text == "")
                                {
                                    I.Text = letterC;
                                    I.Enabled = false; turn = !turn; turnCount++;
                                    break;
                                }
                            }
                        }
                        else
                        {
                            for (int i = 0; i < 100000; i++)
                            {
                                Random r = new Random();
                                int num = r.Next(0, 9);
                                if (num == 0 && A.Text == "")
                                {
                                    A.Text = letterC;
                                    A.Enabled = false; turn = !turn; turnCount++;
                                    break;
                                }
                                else if (num == 1 && B.Text == "")
                                {
                                    B.Text = letterC;
                                    B.Enabled = false; turn = !turn; turnCount++;
                                    break;
                                }
                                else if (num == 2 && C.Text == "")
                                {
                                    C.Text = letterC;
                                    C.Enabled = false; turn = !turn; turnCount++;
                                    break;
                                }
                                else if (num == 3 && D.Text == "")
                                {
                                    D.Text = letterC;
                                    D.Enabled = false; turn = !turn; turnCount++;
                                    break;
                                }
                                else if (num == 4 && E.Text == "")
                                {
                                    E.Text = letterC;
                                    E.Enabled = false; turn = !turn; turnCount++;
                                    break;
                                }
                                else if (num == 5 && F.Text == "")
                                {
                                    F.Text = letterC;
                                    F.Enabled = false; turn = !turn; turnCount++;
                                    break;
                                }
                                else if (num == 6 && G.Text == "")
                                {
                                    G.Text = letterC;
                                    G.Enabled = false; turn = !turn; turnCount++;
                                    break;
                                }
                                else if (num == 7 && H.Text == "")
                                {
                                    H.Text = letterC;
                                    H.Enabled = false; turn = !turn; turnCount++;
                                    break;
                                }
                                else if (num == 8 && I.Text == "")
                                {
                                    I.Text = letterC;
                                    I.Enabled = false; turn = !turn; turnCount++;
                                    break;
                                }
                            }
                        }
                    }
                }
                else//computer
                {
                    int ctw = ComputerToWin();
                    if (ctw == 0 && A.Text == "") { A.Text = letterC;turnCount++; }
                    else if (ctw == 1 && B.Text == "") { B.Text = letterC; B.Enabled = false; turnCount++; }
                    else if (ctw == 2 && C.Text == "") { C.Text = letterC; C.Enabled = false; turnCount++; }
                    else if (ctw == 3 && D.Text == "") { D.Text = letterC; D.Enabled = false; turnCount++; }
                    else if (ctw == 4 && E.Text == "") { E.Text = letterC; E.Enabled = false; turnCount++; }
                    else if (ctw == 5 && F.Text == "") { F.Text = letterC; F.Enabled = false; turnCount++; }
                    else if (ctw == 6 && G.Text == "") { G.Text = letterC; G.Enabled = false; turnCount++; }
                    else if (ctw == 7 && H.Text == "") { H.Text = letterC; H.Enabled = false; turnCount++; }
                    else if (ctw == 8 && I.Text == "") { I.Text = letterC; I.Enabled = false; turnCount++; }
                    else if (ctw == 15)
                    {
                        MessageBox.Show("random");
                        for (int i = 0; i < 100000; i++)
                        {
                            Random r = new Random();
                            int num = r.Next(0, 9);
                            if (num == 0 && A.Text == "")
                            {
                                A.Text = letterC;
                                A.Enabled = false; turn = !turn; turnCount++;
                                break;
                            }
                            else if (num == 1 && B.Text == "")
                            {
                                B.Text = letterC;
                                B.Enabled = false; turn = !turn; turnCount++;
                                break;
                            }
                            else if (num == 2 && C.Text == "")
                            {
                                C.Text = letterC;
                                C.Enabled = false; turn = !turn; turnCount++;
                                break;
                            }
                            else if (num == 3 && D.Text == "")
                            {
                                D.Text = letterC;
                                D.Enabled = false; turn = !turn; turnCount++;
                                break;
                            }
                            else if (num == 4 && E.Text == "")
                            {
                                E.Text = letterC;
                                E.Enabled = false; turn = !turn; turnCount++;
                                break;
                            }
                            else if (num == 5 && F.Text == "")
                            {
                                F.Text = letterC;
                                F.Enabled = false; turn = !turn; turnCount++;
                                break;
                            }
                            else if (num == 6 && G.Text == "")
                            {
                                G.Text = letterC;
                                G.Enabled = false; turn = !turn; turnCount++;
                                break;
                            }
                            else if (num == 7 && H.Text == "")
                            {
                                H.Text = letterC;
                                H.Enabled = false; turn = !turn; turnCount++;
                                break;
                            }
                            else if (num == 8 && I.Text == "")
                            {
                                I.Text = letterC;
                                I.Enabled = false; turn = !turn; turnCount++;
                                break;
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < 100000; i++)
                        {
                            Random r = new Random();
                            int num = r.Next(0, 9);
                            if (num == 0 && A.Text == "")
                            {
                                A.Text = letterC;
                                A.Enabled = false; turn = !turn; turnCount++;
                                break;
                            }
                            else if (num == 1 && B.Text == "")
                            {
                                B.Text = letterC;
                                B.Enabled = false; turn = !turn; turnCount++;
                                break;
                            }
                            else if (num == 2 && C.Text == "")
                            {
                                C.Text = letterC;
                                C.Enabled = false; turn = !turn; turnCount++;
                                break;
                            }
                            else if (num == 3 && D.Text == "")
                            {
                                D.Text = letterC;
                                D.Enabled = false; turn = !turn; turnCount++;
                                break;
                            }
                            else if (num == 4 && E.Text == "")
                            {
                                E.Text = letterC;
                                E.Enabled = false; turn = !turn; turnCount++;
                                break;
                            }
                            else if (num == 5 && F.Text == "")
                            {
                                F.Text = letterC;
                                F.Enabled = false; turn = !turn; turnCount++;
                                break;
                            }
                            else if (num == 6 && G.Text == "")
                            {
                                G.Text = letterC;
                                G.Enabled = false; turn = !turn; turnCount++;
                                break;
                            }
                            else if (num == 7 && H.Text == "")
                            {
                                H.Text = letterC;
                                H.Enabled = false; turn = !turn; turnCount++;
                                break;
                            }
                            else if (num == 8 && I.Text == "")
                            {
                                I.Text = letterC;
                                I.Enabled = false; turn = !turn; turnCount++;
                                break;
                            }
                        }
                    }
                }
                string s = CheckWinner();
                if (s == "X")
                {
                    foreach (Control c in Controls)
                    {
                        if (c.Text != "RESET")
                        {
                            c.Enabled = false;
                        }
                    }
                    MessageBox.Show("X is the winner");
                    if (letterC == "X") { computerScore++; } else { playerScore++; }
                    PSLBL.Text = Convert.ToString(playerScore); CSLBL.Text = Convert.ToString(computerScore);
                }
                else if (s == "O")
                {
                    foreach (Control c in Controls)
                    {
                        if (c.Text != "RESET")
                        {
                            c.Enabled = false;
                        }
                    }
                    MessageBox.Show("O is the winner"); if (letterC == "O") { computerScore++; } else { playerScore++; }
                    PSLBL.Text = Convert.ToString(playerScore); CSLBL.Text = Convert.ToString(computerScore);
                }
                else if (s == "D")
                {
                    foreach (Control c in Controls)
                    {
                        if (c.Text != "RESET")
                        {
                            c.Enabled = false;
                        }
                    }
                    MessageBox.Show("Its a draw!");
                }
                else if (s == "") {; }
            }
        }
        private string CheckWinner()
        {
            if(A.Text==B.Text && B.Text==C.Text && C.Text!="")
            {
                return A.Text;
            }
            else if (D.Text == E.Text && E.Text == F.Text && D.Text != "")
            {
                return D.Text;
            }
            else if (G.Text == H.Text && H.Text == I.Text && G.Text != "")
            {
                return G.Text;
            }

            else if (A.Text ==D.Text && D.Text == G.Text && G.Text != "")
            {
                return A.Text;
            }
            else if (B.Text == E.Text && E.Text == H.Text && H.Text != "")
            {
                return B.Text;
            }
            else if (C.Text == F.Text && F.Text == I.Text && I.Text != "")
            {
                return C.Text;
            }

            else if (A.Text == E.Text && E.Text == I.Text && E.Text != "")
            {
                return E.Text;
            }
            else if (C.Text == E.Text && E.Text == G.Text && G.Text != "")
            {
                return G.Text;
            }


            if (turnCount==9)
            {
                return "D";
            }

            return "";
        }
        private int ComputerToWin()
        {
            if (A.Text == B.Text && C.Text == "" && A.Text!="")
            {
                return 2;
            }
            else if (A.Text == C.Text && B.Text == "" && A.Text != "")
            {
                return 1;
            }
            else if (B.Text == C.Text && A.Text == "" && B.Text != "")
            {
                return 0;
            }
            else if (D.Text == E.Text && F.Text == "" && D.Text != "")
            {
                return 5;
            }
            else if (E.Text == F.Text && D.Text == "" && E.Text != "")
            {
                return 3;
            }
            else if (F.Text == D.Text && E.Text == "" && F.Text != "")
            {
                return 4;
            }
            else if (G.Text == H.Text && I.Text == "" && G.Text != "")
            {
                return 8;
            }
            else if (I.Text == H.Text && G.Text == "" && I.Text != "")
            {
                return 6;
            }
            else if (I.Text == G.Text && H.Text == "" && I.Text != "")
            {
                return 7;
            }



            else if (A.Text == D.Text && G.Text == "" && A.Text != "")
            {
                return 6;
            }
            else if (G.Text == D.Text && A.Text == "" && G.Text != "")
            {
                return 0;
            }
            else if (G.Text == A.Text && D.Text == "" && G.Text != "")
            {
                return 3;
            }
            else if (B.Text == E.Text && H.Text == "" && B.Text != "")
            {
                return 7;
            }
            else if (B.Text == H.Text && E.Text == "" && B.Text != "")
            {
                return 4;
            }
            else if (E.Text == H.Text && B.Text == "" && E.Text != "")
            {
                return 1;
            }
            else if (C.Text == F.Text && I.Text == "" && C.Text != "")
            {
                return 8;
            }
            else if (C.Text == I.Text && F.Text == "" && C.Text != "")
            {
                return 5;
            }
            else if (F.Text == I.Text && C.Text == "" && F.Text != "")
            {
                return 2;
            }




            else if (A.Text == E.Text && I.Text== "" && A.Text!="")
            {
                return 8;
            }
            else if (A.Text == I.Text && E.Text == "" && A.Text != "")
            {
                return 4;
            }
            else if (I.Text == E.Text && A.Text == "" && I.Text != "")
            {
                return 0;
            }
            else if (C.Text == E.Text && G.Text != "" && C.Text != "")
            {
                return 6;
            }
            else if (G.Text == E.Text && C.Text != "" && G.Text != "")
            {
                return 2;
            }
            else if (C.Text == G.Text && E.Text != "" && C.Text != "")
            {
                return 4;
            }
            return 15;
        }
    }
}
