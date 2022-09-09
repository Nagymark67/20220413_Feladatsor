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
    public partial class HetedikFeladat : Form
    {
        public HetedikFeladat()
        {
            InitializeComponent();
        }        

        private void HetedikFeladat_Load(object sender, EventArgs e)
        {
            label1.Text = "A szó elszáll, az" + Environment.NewLine + "írás megmarad.";
            label1.Font = new Font("Arial", 24, FontStyle.Regular);
            Vegrehajt_Gomb.Text = "Átalakít";
            Felkover_CheckBox.Text = "Félkövér";
            Dolt_CheckBox.Text = "Dőlt";
            Alahuzott_CheckBox.Text = "Aláhúzott";
        }                

        private void Vegrehajt_Gomb_Click(object sender, EventArgs e)
        {
            Font fnt = new Font(label1.Font.FontFamily, Font.Size, FontStyle.Regular);
            if (Felkover_CheckBox.Checked)
            {
                fnt = new Font(label1.Font, fnt.Style | FontStyle.Bold);                
            }
            if (Dolt_CheckBox.Checked)
            {
                fnt = new Font(label1.Font, fnt.Style | FontStyle.Italic);                
            }
            if (Alahuzott_CheckBox.Checked)
            {
                fnt = new Font(label1.Font, fnt.Style | FontStyle.Underline);                
            }
            label1.Font = fnt;
        }

        private void HetedikFeladat_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 Fokepernyo = new Form1();
            this.Hide();
            Fokepernyo.ShowDialog();
            this.Close();
        }
    }
}
