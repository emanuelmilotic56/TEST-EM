using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_E
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            foreach (Brkovi brk in lista)
            {
                if (brk.Pod4 == "M")
                {
                    brk.Dodatak = "Ima brkove.";
                }
                else
                {
                    brk.Dodatak = "Nema brkove";
                }
            }
        }
    }

        private void Button1_Click(object sender, EventArgs e)
        {



            try
            {

                Brkovi brk = new Brkovi(textBox1.Text, textBox2.Text,
                    Convert.ToInt32(textBox3.Text),
                    Convert.ToString(cmbPodatak4.Text));


                lista.Add(brk);


                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
             catch(Exception greska)
            {


                MessageBox.Show("Pogrešan unos!\r\n" + greska.Message,
                  "Greška", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);

            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {

            richTextBox1.Text = "Podatak 1" + "\tPodatak 2"
                + "\tPodatak 3" + "\tPodatak 4" + "\tDodatak\r\n";


            foreach (Brkovi brk in lista)
            {
                richTextBox1.AppendText(brk.ToString());
            }

        }
    }
}
