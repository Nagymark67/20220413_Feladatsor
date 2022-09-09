using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20220413_Feladatsor
{
    public partial class ElsoFeladat : Form
    {
        static Random rnd = new Random();
        public ElsoFeladat()
        {
            InitializeComponent();
        }

        public static int GondoltSzam;
        public static int TippekSzama = 0;
        public static int i = 0;

        private void ElsoFeladat_Load(object sender, EventArgs e)
        {
            this.Text = "Gondoltam egy számra, találd ki!";
            button1.Text = "1";
            button2.Text = "2";
            button3.Text = "3";
            button4.Text = "4";
            button5.Text = "5";
            button6.Text = "6";
            button7.Text = "7";
            button8.Text = "8";
            button9.Text = "9";
            button10.Text = "10";
            button11.Text = "11";
            button12.Text = "12";
            button13.Text = "13";
            button14.Text = "14";
            button15.Text = "15";
            button16.Text = "16";
            button17.Text = "17";
            button18.Text = "18";
            button19.Text = "19";
            button20.Text = "20";
            GondoltSzam = rnd.Next(1, 21);
        }       

        private void button1_Click(object sender, EventArgs e)
        {
            i = 1;
            button1.Enabled = false;
            Szamolas();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i = 2;
            button2.Enabled = false;
            Szamolas();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            i = 3;
            button3.Enabled = false;
            Szamolas();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            i = 4;
            button4.Enabled = false;
            Szamolas();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            i = 5;
            button5.Enabled = false;
            Szamolas();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            i = 6;
            button6.Enabled = false;
            Szamolas();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            i = 7;
            button7.Enabled = false;
            Szamolas();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            i = 8;
            button8.Enabled = false;
            Szamolas();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            i = 9;
            button9.Enabled = false;
            Szamolas();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            i = 10;
            button10.Enabled = false;
            Szamolas();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            i = 11;
            button11.Enabled = false;
            Szamolas();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            i = 12;
            button12.Enabled = false;
            Szamolas();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            i = 13;
            button13.Enabled = false;
            Szamolas();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            i = 14;
            button14.Enabled = false;
            Szamolas();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            i = 15;
            button15.Enabled = false;
            Szamolas();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            i = 16;
            button16.Enabled = false;
            Szamolas();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            i = 17;
            button17.Enabled = false;
            Szamolas();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            i = 18;
            button18.Enabled = false;
            Szamolas();

        }

        private void button19_Click(object sender, EventArgs e)
        {
            i = 19;
            button19.Enabled = false;
            Szamolas();

        }

        private void button20_Click(object sender, EventArgs e)
        {
            i = 20;
            button20.Enabled = false;
            Szamolas();

        }

        private void Szamolas()
        {
            if (GondoltSzam == i)
            {
                TippekSzama++;
                MessageBox.Show("Gratulálok, eltaláltad!\nTippek száma: " + TippekSzama, "Játék vége!", MessageBoxButtons.OK);
                UjJatek();
            }
            else if (GondoltSzam < i)
            {
                MessageBox.Show("Nem talált, a kitalálandó szám kisebb!", "", MessageBoxButtons.OK);
                TippekSzama++;
            }
            else
            {
                MessageBox.Show("Nem talált, a kitalálandó szám nagyobb!", "", MessageBoxButtons.OK);
                TippekSzama++;
            }
        }

        private void UjJatek()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button btn)
                {
                    btn.Enabled = true;
                }
            }
            this.ActiveControl = button1;
            GondoltSzam = rnd.Next(1, 21);
        }

        private void ElsoFeladat_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 Fokepernyo = new Form1();
            this.Hide();
            Fokepernyo.ShowDialog();
            this.Close();
            
        }
    }
}
