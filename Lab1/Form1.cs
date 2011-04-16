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
        private logicNShit logic;
        
        public Form1()
        {
            InitializeComponent();
            skapaKnappar();
            logic = new logicNShit(this);
        }
        public void skapaKnappar()
        {
            for (int k = 0; k < 3; k++)
            {
             for (int i = 0; i < 3; i++)
             {
                    knappar[counter] = new Button();
                    knappar[counter].Location = new System.Drawing.Point(spacing * i + 25, 50 * row + 25);
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
        public void buttonDefaultClick(object sender, EventArgs e)
        {
            Button temp = (Button)sender;
            int denKlickadeKnappen = Convert.ToInt32(temp.Name);
            String knappensText = knappar[denKlickadeKnappen].Text;
            knappar[denKlickadeKnappen].Text = logic.gameLogic(denKlickadeKnappen, knappensText);
        }
        public void button1_Click(object sender, EventArgs e)
        {
            logic.Reset();
            for (int i = 0; i < knappar.Length; i++)
            {
                knappar[i].Text = " ";
                knappar[i].Enabled = true;
            }
            activateButtons();
            changeText("");
        }
        public void inactivateButtons()
        {
            for (int i = 0; i < knappar.Length; i++)
            {
                knappar[i].Enabled = false;
            }
        }
        public void activateButtons()
        {
            for (int i = 0; i < knappar.Length; i++)
            {
                knappar[i].Enabled = true;
            }
        }
        public void changeText(String outPut)
        {
            label1.Text = outPut;
        }
    }
}
