using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biletci_Ahmet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                int biletAdet = 0, colaAdet = 0, misirAdet = 0, cipsAdet = 0, toplam;

            

                biletAdet = Convert.ToInt16(textBox1.Text);
                colaAdet = Convert.ToInt16(textBox2.Text);
                misirAdet = Convert.ToInt16(textBox3.Text);
                cipsAdet = Convert.ToInt16(textBox4.Text);

                toplam = ((100 * biletAdet) + (25 * colaAdet) + (50 * misirAdet) + (50 * cipsAdet));

                label14.Text = (toplam.ToString() + " TL");
                listBox1.Items.Add(("Film: " + comboBox1.Text)
                    + (" Kisi (adet): " + textBox1.Text)
                    + (" Cola Adet: " + textBox2.Text)
                    + (" Misir Adet: " + textBox3.Text)
                    + (" Cips Adet: " + textBox4.Text));

                //MessageBox.Show(Convert.ToString(toplam));
            


        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
