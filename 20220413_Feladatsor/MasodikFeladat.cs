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
    public partial class MasodikFeladat : Form
    {
        public MasodikFeladat()
        {
            InitializeComponent();
        }

        static Random rnd = new Random();        
        private void MasodikFeladat_Load(object sender, EventArgs e)
        {
            this.Text = "LOTTÓ";
            Valaszto_ComboBox.Text = "Válassz...";
            Valaszto_ComboBox.Items.Add("ötöslottó");
            Valaszto_ComboBox.Items.Add("hatoslottó");
            Valaszto_ComboBox.Items.Add("skandináv lottó");            
            label1.Location = new Point(this.Width/3, this.Height/2);
            label1.Text = "";
            label1.Visible = false;
            Sorsolas_Gomb.Text = "Sorsolás";            
            pictureBox1.Image = Image.FromFile("letöltés.jpg");
            pictureBox2.Image = Image.FromFile("letöltés2.jpg");
            pictureBox3.Image = Image.FromFile("letöltés3.jpg");
            pictureBox4.Image = Image.FromFile("letöltés4.jpg");
            pictureBox5.Image = Image.FromFile("letöltés5.jpg");
            pictureBox6.Image = Image.FromFile("letöltés6.jpg");
            pictureBox7.Image = Image.FromFile("letöltés7.jpg");
            pictureBox8.Image = Image.FromFile("letöltés8.jpg");
            pictureBox9.Image = Image.FromFile("letöltés9.jpg");
            pictureBox10.Image = Image.FromFile("letöltés10.jpg");
        }

        private void Sorsolas_Gomb_Click(object sender, EventArgs e)
        {
            if (Valaszto_ComboBox.SelectedItem.ToString() == "ötöslottó")
            {
                label1.Text = "";
                label1.Visible = true;
                foreach (Control controls in this.Controls)
                {                
                        if (controls is PictureBox ptb)
                        {
                            ptb.Visible = false;
                        }                 
                }
                int[] szam = new int[5];
                int[] szamok = new int[90];
                for (int i = 0; i < szamok.Length; i++)
                {
                    szamok[i] = i + 1;
                }                
                int HuzottSzam;
                for (int i = 0; i < 5; i++)
                {
                    HuzottSzam = rnd.Next(0, 90 - i);
                    szam[i] = szamok[HuzottSzam];
                    szamok[HuzottSzam] = szamok[89 - i];
                    szamok[89 - i] = szam[i];                    
                    
                }                
                Array.Sort(szam);
                for (int i = 0; i < 5; i++)
                {
                    label1.Text += szam[i]+", ";
                }
            }
            else if (Valaszto_ComboBox.SelectedItem.ToString() == "hatoslottó")
            {
                label1.Text = "";
                label1.Visible = true;
                foreach (Control controls in this.Controls)
                {
                    if (controls is PictureBox ptb)
                    {
                        ptb.Visible = false;
                    }
                }
                int[] szam = new int[6];
                int[] szamok = new int[45];
                for (int i = 0; i < szamok.Length; i++)
                {
                    szamok[i] = i + 1;
                }
                int HuzottSzam;
                for (int i = 0; i < 6; i++)
                {
                    HuzottSzam = rnd.Next(0, 45 - i);
                    szam[i] = szamok[HuzottSzam];
                    szamok[HuzottSzam] = szamok[44 - i];
                    szamok[44 - i] = szam[i];

                }
                Array.Sort(szam);
                for (int i = 0; i < 6; i++)
                {
                    label1.Text += szam[i] + ", ";
                }
            }
            else if (Valaszto_ComboBox.SelectedItem.ToString() == "skandináv lottó")
            {
                label1.Text = "";
                label1.Visible = true;
                foreach (Control controls in this.Controls)
                {
                    if (controls is PictureBox ptb)
                    {
                        ptb.Visible = false;
                    }
                }
                //Kézi húzás
                int[] szam = new int[7];
                int[] szamok = new int[35];
                for (int i = 0; i < szamok.Length; i++)
                {
                    szamok[i] = i + 1;
                }
                int HuzottSzam;
                for (int i = 0; i < 7; i++)
                {
                    HuzottSzam = rnd.Next(0, 35 - i);
                    szam[i] = szamok[HuzottSzam];
                    szamok[HuzottSzam] = szamok[34 - i];
                    szamok[34 - i] = szam[i];

                }
                Array.Sort(szam);
                label1.Text = "Kézi húzás: ";
                for (int i = 0; i < 7; i++)
                {
                    label1.Text += szam[i] + ", ";
                }
                //Gépi húzás
                int[] szam2 = new int[7];                
                label1.Text += Environment.NewLine;
                int[] szamok2 = new int[35];
                for (int i = 0; i < szamok2.Length; i++)
                {
                    szamok2[i] = i + 1;
                }
                int HuzottSzam2;
                for (int i = 0; i < 7; i++)
                {
                    HuzottSzam2 = rnd.Next(0, 35 - i);
                    szam2[i] = szamok2[HuzottSzam2];
                    szamok2[HuzottSzam2] = szamok2[34 - i];
                    szamok2[34 - i] = szam2[i];

                }
                Array.Sort(szam2);
                label1.Text += "Gépi húzás: ";
                for (int i = 0; i < 7; i++)
                {
                    label1.Text += szam2[i] + ", ";
                }
            }
            else
            {
                MessageBox.Show("Kérem válassza ki a sorsolás típusát!", "Hiba!", MessageBoxButtons.OK);
            }
        }

        private void Valaszto_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Visible = false;
            foreach (Control controls in this.Controls)
            {
                if (controls is PictureBox ptb)
                {
                    ptb.Visible = true;
                }
            }
        }

        private void MasodikFeladat_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 Fokepernyo = new Form1();
            this.Hide();
            Fokepernyo.ShowDialog();
            this.Close();
        }
    }
}
