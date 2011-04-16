using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        private Button[] knappar = new Button[9];
        private int row = 0;
        private int spacing = 50;
        private int counter = 0;
        private int turn = 1;
        private Boolean gg = false;
        //private dataNShit[] dataz = new dataNShit[8];

        private dataNShit row1 = new dataNShit();
        private dataNShit row2 = new dataNShit();
        private dataNShit row3 = new dataNShit();
        private dataNShit col1 = new dataNShit();
        private dataNShit col2 = new dataNShit();
        private dataNShit col3 = new dataNShit();
        private dataNShit diag1 = new dataNShit();
        private dataNShit diag2 = new dataNShit();
        

        public Form1()
        {
            InitializeComponent();
            skapaKnappar();
        }
        public void skapaKnappar()
        {
            for (int k = 0; k < 3; k++)
            {
             for (int i = 0; i < 3; i++)
             {
                    knappar[counter] = new Button();
                    knappar[counter].Location = new System.Drawing.Point(spacing * i, 50 * row);
                    knappar[counter].Name = Convert.ToString(counter);
                    knappar[counter].Size = new System.Drawing.Size(50, 50);
                    knappar[counter].TabIndex = 0;
                    knappar[counter].Text = " ";
                    knappar[counter].UseVisualStyleBackColor = true;
                    knappar[counter].Click += new EventHandler(buttonDefaultClick);
                    Controls.Add(knappar[counter]);
                    counter++;
               }
             row++;
            }
        }
        private void buttonDefaultClick(object sender, EventArgs e)
        {
            Button temp = (Button)sender;
            int denKlickadeKnappen = Convert.ToInt32(temp.Name);

            if (knappar[denKlickadeKnappen].Text == " ")
            {
                if (turn == 1)
                {
                    
                    knappar[denKlickadeKnappen].Text = "O";
                    switch (denKlickadeKnappen)
                    {
                        case 0:
                            row1.setDataNShit("O", 1);
                            col1.setDataNShit("O", 1);
                            diag1.setDataNShit("O", 1);
                            break;
                        case 1:
                            row1.setDataNShit("O", 2);
                            col2.setDataNShit("O", 1);
                            break;
                        case 2:
                            row1.setDataNShit("O", 3);
                            col3.setDataNShit("O", 1);
                            diag2.setDataNShit("O", 1);
                            break;
                        case 3:
                            row2.setDataNShit("O", 1);
                            col1.setDataNShit("O", 2);
                            break;
                        case 4:
                            row2.setDataNShit("O", 2);
                            col2.setDataNShit("O", 2);
                            diag1.setDataNShit("O", 2);
                            diag2.setDataNShit("O", 2);
                            break;
                        case 5:
                            row2.setDataNShit("O", 3);
                            col3.setDataNShit("O", 2);
                            break;
                        case 6:
                            row3.setDataNShit("O", 1);
                            col1.setDataNShit("O", 3);
                            diag2.setDataNShit("O", 3);
                            break;
                        case 7:
                            row3.setDataNShit("O", 2);
                            col2.setDataNShit("O", 3);
                            break;
                        case 8:
                            row3.setDataNShit("O", 3);
                            col3.setDataNShit("O", 3);
                            diag1.setDataNShit("O", 3);
                            break;
                    }

                }
                else
                {

                    knappar[denKlickadeKnappen].Text = "X";
                    switch (denKlickadeKnappen)
                    {
                        case 0:
                            row1.setDataNShit("X", 1);
                            col1.setDataNShit("X", 1);
                            diag1.setDataNShit("X", 1);
                            break;
                        case 1:
                            row1.setDataNShit("X", 2);
                            col2.setDataNShit("X", 1);
                            break;
                        case 2:
                            row1.setDataNShit("X", 3);
                            col3.setDataNShit("X", 1);
                            diag2.setDataNShit("X", 1);
                            break;
                        case 3:
                            row2.setDataNShit("X", 1);
                            col1.setDataNShit("X", 2);
                            break;
                        case 4:
                            row2.setDataNShit("X", 2);
                            col2.setDataNShit("X", 2);
                            diag1.setDataNShit("X", 2);
                            diag2.setDataNShit("X", 2);
                            break;
                        case 5:
                            row2.setDataNShit("X", 3);
                            col3.setDataNShit("X", 2);
                            break;
                        case 6:
                            row3.setDataNShit("X", 1);
                            col1.setDataNShit("X", 3);
                            diag2.setDataNShit("X", 3);
                            break;
                        case 7:
                            row3.setDataNShit("X", 2);
                            col2.setDataNShit("X", 3);
                            break;
                        case 8:
                            row3.setDataNShit("X", 3);
                            col3.setDataNShit("X", 3);
                            diag1.setDataNShit("X", 3);
                            break;
                    }
                }
                GG();
                turn = turn * (-1);
            }
            else
            {

            }
        }
        private void GG()
        {
            Boolean noMovesLeft = true;
            for (int j = 0; j < knappar.Length; j++ )
            {
                if (knappar[j].Text == " ")
                {
                    noMovesLeft = false;
                }
                else 
                { 
                
                }
            }
            if (row1.andTheresTheGG() == true || row2.andTheresTheGG() == true || row3.andTheresTheGG() == true || col1.andTheresTheGG() == true || col2.andTheresTheGG() == true || col3.andTheresTheGG() == true || diag1.andTheresTheGG() == true || diag2.andTheresTheGG() == true)
            {
                gg = true;
            }
            
            if (noMovesLeft == false && gg == true)
            {
                inactivateButtons();
                if (turn == 1)
                {
                    label1.Text = "O vinner!";
                }
                else
                {
                    label1.Text = "X vinner!";
                }
            }
            else if (noMovesLeft == true && gg == true)
            {
                inactivateButtons();
                if(turn == 1)
                {
                    label1.Text = "O vinner!";
                }
                else
                {
                    label1.Text = "X vinner!";
                }
            }
            else if (noMovesLeft == true && gg == false)
            {
                inactivateButtons();
                //oavgjort
                label1.Text = "Oavgjort!";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            for (int i = 0; i < knappar.Length; i++)
            {
                knappar[i].Text = " ";
                knappar[i].Enabled = true;
            }
            row1.purge();
            row2.purge();
            row3.purge();
            col1.purge();
            col2.purge();
            col3.purge();
            diag1.purge();
            diag2.purge();
            gg = false;
            label1.Text = " ";
            turn = 1;
        }
        private void inactivateButtons()
        {
            for (int i = 0; i < knappar.Length; i++)
            {
                knappar[i].Enabled = false;
            }
        }

    }
}
