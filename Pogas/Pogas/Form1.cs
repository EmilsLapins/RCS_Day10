using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pogas
{
    public partial class Form1 : Form
    {
       private int skaitlis1 = 0;
       private int skaitlis2 = 0;




        public Form1()
        {
            InitializeComponent();
        }
        
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChangeLabel (string cipars) // 
        {
            label1.Text = cipars;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //int a = 5;
            string Ievade = button1.Text;
            ChangeLabel(Ievade);

            //label1.Text = Ievade;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string Ievade = button5.Text;
            ChangeLabel(Ievade);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string Ievade = button2.Text;
            ChangeLabel(Ievade);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Ievade = button3.Text;
            ChangeLabel(Ievade);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Ievade = button4.Text;
            ChangeLabel(Ievade);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string Ievade = button6.Text;
            ChangeLabel(Ievade);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string Ievade = button7.Text;
            ChangeLabel(Ievade);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string Ievade = button8.Text;
            ChangeLabel(Ievade);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string Ievade = button9.Text;
            ChangeLabel(Ievade);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string Ievade = button10.Text;
            ChangeLabel(Ievade);
        }

        private void button11_Click(object sender, EventArgs e) //+
        {
            string vertiba = label1.Text;
            skaitlis1 = Convert.ToInt16(vertiba);
            

        }

        private void button12_Click(object sender, EventArgs e) //-
        {

            // private string kura saglabajam izveli + -> string a = "+"  if(name == "+")
            string vertiba = label1.Text; 
            skaitlis1 = Convert.ToInt16(vertiba);
        }

        private void button13_Click(object sender, EventArgs e) // =
        {
            string vertiba = label1.Text;
            skaitlis2 = Convert.ToInt16(vertiba);
            label1.Text =  Kalkulacija.Saskaita(skaitlis1, skaitlis2);
            
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
// Sataisit pogas no 0 - 9 , nospiezot pogu paradas sis cipars!