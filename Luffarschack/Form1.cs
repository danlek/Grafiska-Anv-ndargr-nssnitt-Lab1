using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Luffarschack
{
    public partial class Form1 : Form
    {
       // private System.Windows.Forms.Button button2;
        public Form1()
        {
            
            InitializeComponent();
            skapaKnappar();
        }
        public void skapaKnappar()
        {
            button2 = new System.Windows.Forms.Button();
            button2.Location = new System.Drawing.Point(100, 100);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += new System.EventHandler(this.button1_Click_1);
           // MessageBox.Show("Skapat");
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            skapaKnappar();
            MessageBox.Show("tryckt");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //skapaKnappar();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            skapaKnappar();
            MessageBox.Show("tryckt");
        }

    }
}
