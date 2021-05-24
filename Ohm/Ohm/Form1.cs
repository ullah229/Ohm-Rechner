using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Ohm
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }      

        private void StromButton_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "Spannung";
            label4.Text = "Widerstand";           
        }

        private void Spannungbutton_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "Strom";
            label4.Text = "Widerstand";           
        }

        private void WiderstandButton_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "Spannung";
            label4.Text = "Strom";                  
        }

        public void BerechnenButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Spannungbutton.Checked)
                {
                    label2.Text = (double.Parse(textBox1.Text) * double.Parse(textBox2.Text)).ToString() + " V";                   
                }
                if (WiderstandButton.Checked)
                {
                    label2.Text = (double.Parse(textBox1.Text) / double.Parse(textBox2.Text)).ToString() + " Ω";
                }
                if (StromButton.Checked)
                {
                    berechneStrom();
                }
            }
            catch
            {
                label2.Text = "Fehlermeldung!";
            }
        }

        public void berechneStrom()
        {
            label2.Text = (double.Parse(textBox1.Text) / double.Parse(textBox2.Text)).ToString() + " A";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Geschwindigkeit")
            {
                WiderstandButton.Text = "Geschwindigkeit";
                StromButton.Text = "Zeit";
                Spannungbutton.Text = "Strecke";
            } 
            else if(comboBox1.Text == "Ohmsches Gesetz")
            {
                WiderstandButton.Text = "Widerstand";
                StromButton.Text = "Strom";
                Spannungbutton.Text = "Spannung";
            }
        }
    }
}
