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
    public partial class OtodikFeladat : Form
    {
        public OtodikFeladat()
        {
            InitializeComponent();
        }

        private void OtodikFeladat_Load(object sender, EventArgs e)
        {
            Terep_GroupBox.Text = "Terep";            
            Sportag_GroupBox.Text = "Sportág";
            Sik_RadioButton.Text = "sík";
            Sik_RadioButton.Checked = true;
            Emelkedo_RadioButton.Text = "emelkedő";
            Gyaloglas_RadioButton.Text = "gyaloglás";
            Gyaloglas_RadioButton.Checked = true;
            Biciklizes_Radiobutton.Text = "biciklizés";
            Kocogas_RadioButton.Text = "kocogás";
            label1.Text = "Időtartam:";
            label2.Text = "perc";
            label3.Text = "Energia";
            label4.Text = "KJoule";
            Szamol_Gomb.Text = "Számol";            
            Energia_TextBox.ReadOnly = true;
        }

        public static int sportag_tenyezo;

        private void Szamol_Gomb_Click(object sender, EventArgs e)
        {
            try
            {
                if (Gyaloglas_RadioButton.Checked)
                {
                    sportag_tenyezo = 20;
                }
                else if (Biciklizes_Radiobutton.Checked)
                {
                    sportag_tenyezo = 24;
                }
                else if (Kocogas_RadioButton.Checked)
                {
                    sportag_tenyezo = 33;
                }
                switch (sportag_tenyezo)
                {
                    case 20:
                        if (Sik_RadioButton.Checked)
                        {
                            double Energia = int.Parse(Idotartam_TextBox.Text) * (1.5 + sportag_tenyezo) * 1.2;
                            Energia_TextBox.Text = Energia.ToString();
                        }
                        else if (Emelkedo_RadioButton.Checked)
                        {
                            double Energia = int.Parse(Idotartam_TextBox.Text) * (2 + sportag_tenyezo) * 1.7;
                            Energia_TextBox.Text = Energia.ToString();
                        }
                        break;
                    case 24:
                        if (Sik_RadioButton.Checked)
                        {
                            double Energia = int.Parse(Idotartam_TextBox.Text) * (1.5 + sportag_tenyezo) * 1.2;
                            Energia_TextBox.Text = Energia.ToString();
                        }
                        else if (Emelkedo_RadioButton.Checked)
                        {
                            double Energia = int.Parse(Idotartam_TextBox.Text) * (2 + sportag_tenyezo) * 1.7;
                            Energia_TextBox.Text = Energia.ToString();
                        }
                        break;
                    case 33:
                        if (Sik_RadioButton.Checked)
                        {
                            double Energia = int.Parse(Idotartam_TextBox.Text) * (1.5 + sportag_tenyezo) * 1.2;
                            Energia_TextBox.Text = Energia.ToString();
                        }
                        else if (Emelkedo_RadioButton.Checked)
                        {
                            double Energia = int.Parse(Idotartam_TextBox.Text) * (2 + sportag_tenyezo) * 1.7;
                            Energia_TextBox.Text = Energia.ToString();
                        }
                        break;
                       
                }
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Ellenőrizze, hogy a mezőkbe a megfelelő formátumú értéket adta meg!", "Hiba!", MessageBoxButtons.OK);                
            }            
        }

        private void OtodikFeladat_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 Fokepernyo = new Form1();
            this.Hide();
            Fokepernyo.ShowDialog();
            this.Close();
        }
    }
}
