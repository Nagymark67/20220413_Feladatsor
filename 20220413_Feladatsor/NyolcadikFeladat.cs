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
    public partial class NyolcadikFeladat : Form
    {
        public NyolcadikFeladat()
        {
            InitializeComponent();
        }

        private void NyolcadikFeladat_Load(object sender, EventArgs e)
        {
            label1.Text = "Fizetendő:";
            Italok_GroupBox.Text = "Italok";
            Hozzavalok_GroupBox.Text = "Hozzávalók";
            Kave_RadioButton.Text = "Kávé";
            Kakao_RadioButton.Text = "Kakaó";
            Tea_RadioButton.Text = "Tea";
            Cukor_CheckBox.Text = "Cukor";
            Citrom_CheckBox.Text = "Citrom";            
            Tej_CheckBox.Text = "Tej";
            Ok_Gomb.Text = "OK";
        }

        public static int HozzavaloAr;

        private void Ok_Gomb_Click(object sender, EventArgs e)
        {            
            if (Kave_RadioButton.Checked)
            {               
                if (Cukor_CheckBox.Checked)
                {
                    HozzavaloAr += 60;
                }                
                if (Tej_CheckBox.Checked)
                {
                    HozzavaloAr += 60;
                }
                switch (HozzavaloAr)
                {
                    case 60:
                        textBox1.Text = (120 + HozzavaloAr).ToString();
                        break;
                    case 120:
                        textBox1.Text = (120 + HozzavaloAr).ToString();
                        break;
                }
            }
            if (Kakao_RadioButton.Checked)
            {                
                if (Cukor_CheckBox.Checked)
                {
                    HozzavaloAr += 60;
                }                
                if (Tej_CheckBox.Checked)
                {
                    HozzavaloAr += 60;
                }
                switch (HozzavaloAr)
                {
                    case 60:
                        textBox1.Text = (120 + HozzavaloAr).ToString();
                        break;
                    case 120:
                        textBox1.Text = (120 + HozzavaloAr).ToString();
                        break;
                }
            }
            if (Tea_RadioButton.Checked)
            {               
                if (Cukor_CheckBox.Checked)
                {
                    HozzavaloAr += 60;
                }
                if (Citrom_CheckBox.Checked)
                {
                    HozzavaloAr += 60;
                }
                if (Tej_CheckBox.Checked)
                {
                    HozzavaloAr += 60;
                }
                switch (HozzavaloAr)
                {
                    case 60:
                        textBox1.Text = (80 + HozzavaloAr).ToString();
                        break;
                    case 120:
                        textBox1.Text = (80 + HozzavaloAr).ToString();
                        break;
                    case 180:
                        textBox1.Text = (80 + HozzavaloAr).ToString();
                        break;
                }
            }
        }

        private void Kave_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Kave_RadioButton.Checked)
            {
                Citrom_CheckBox.Enabled = false;
            }
        }

        private void Kakao_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Kakao_RadioButton.Checked)
            {
                Citrom_CheckBox.Enabled = false;
            }
        }

        private void Tea_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Tea_RadioButton.Checked)
            {
                Citrom_CheckBox.Enabled = true;
            }
        }

        private void NyolcadikFeladat_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 Fokepernyo = new Form1();
            this.Hide();
            Fokepernyo.ShowDialog();
            this.Close();
        }
    }
}
