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
    public partial class NegyedikFeladat : Form
    {
        public NegyedikFeladat()
        {
            InitializeComponent();
        }

        private void NegyedikFeladat_Load(object sender, EventArgs e)
        {
            this.Text = "Áfás számla";
            this.ActiveControl = Netto_Textbox;
            this.AcceptButton = Szamol_Gomb;
            Szamol_Gomb.Text = "Számol";
            label1.Text = "Áfa kulcs:";
            label2.Text = "Nettó ár:";
            label3.Text = "Áfa érték:";
            label4.Text = "Bruttó ár:";
            label5.Text = "Ft";
            label6.Text = "Ft";
            label7.Text = "Ft";
            Afa_Textbox.ReadOnly = true;
            Brutto_TextBox.ReadOnly = true;
            Afa27_RadioButton.Text = "27%";
            Afa18_RadioButton.Text = "18%";
            Afa5_RadioButton.Text = "5%";
            Afa0_RadioButton.Text = "0%";
        }

        private void Szamol_Gomb_Click(object sender, EventArgs e)
        {
            try
            {
                if (Netto_Textbox.Text == "")
                {
                    MessageBox.Show("A nettó ár mezőbe nem írt értéket!", "Hiba!", MessageBoxButtons.OK);
                }
                if (Afa27_RadioButton.Checked)
                {
                    double Netto = double.Parse(Netto_Textbox.Text);
                    double Afa = Netto * 0.27;
                    Afa_Textbox.Text = Afa.ToString();
                    double Brutto = Netto + Afa;
                    Brutto_TextBox.Text = Brutto.ToString();
                }
                if (Afa18_RadioButton.Checked)
                {
                    double Netto = double.Parse(Netto_Textbox.Text);
                    double Afa = Netto * 0.18;
                    Afa_Textbox.Text = Afa.ToString();
                    double Brutto = Netto + Afa;
                    Brutto_TextBox.Text = Brutto.ToString();
                }
                if (Afa5_RadioButton.Checked)
                {
                    double Netto = double.Parse(Netto_Textbox.Text);
                    double Afa = Netto * 0.05;
                    Afa_Textbox.Text = Afa.ToString();
                    double Brutto = Netto + Afa;
                    Brutto_TextBox.Text = Brutto.ToString();
                }
                if (Afa0_RadioButton.Checked)
                {
                    double Netto = double.Parse(Netto_Textbox.Text);
                    double Afa = Netto * 0;
                    Afa_Textbox.Text = Afa.ToString();
                    double Brutto = Netto + Afa;
                    Brutto_TextBox.Text = Brutto.ToString();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Kérem ellenőrizze, hogy minden mezőben megfelelő formátumot írt be!", "Hiba!", MessageBoxButtons.OK);                
            }
        }

        private void Torles()
        {
            Afa_Textbox.Clear();
            Brutto_TextBox.Clear();
        }        

        private void Afa27_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Torles();
        }

        private void NegyedikFeladat_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 Fokepernyo = new Form1();
            this.Hide();
            Fokepernyo.ShowDialog();
            this.Close();
        }
    }
}
