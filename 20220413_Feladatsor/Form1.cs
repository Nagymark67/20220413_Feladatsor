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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "1. Feladat";
            button2.Text = "2. Feladat";
            button3.Text = "3. Feladat";
            button4.Text = "4. Feladat";
            button5.Text = "5. Feladat";
            button6.Text = "Nincs kész!";
            button6.Enabled = false;
            button7.Text = "7. Feladat";
            button8.Text = "8. Feladat";
            //asdasd
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ElsoFeladat Elso = new ElsoFeladat();
            this.Hide();
            Elso.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MasodikFeladat Masodik = new MasodikFeladat();
            this.Hide();
            Masodik.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HarmadikFeladat Harmadik = new HarmadikFeladat();
            this.Hide();
            Harmadik.ShowDialog();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NegyedikFeladat Negyedik = new NegyedikFeladat();
            this.Hide();
            Negyedik.ShowDialog();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OtodikFeladat Otodik = new OtodikFeladat();
            this.Hide();
            Otodik.ShowDialog();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            HatodikFeladat Hatodik = new HatodikFeladat();
            this.Hide();
            Hatodik.ShowDialog();
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Biztos, hogy be szeretnéd zárni ezt az ablakot?", "Kilépés", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Environment.Exit(1);
                }
                else
                {
                    e.Cancel = true;
                }
            }            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            HetedikFeladat Hetedik = new HetedikFeladat();
            this.Hide();
            Hetedik.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NyolcadikFeladat Nyolcadik = new NyolcadikFeladat();
            this.Hide();
            Nyolcadik.ShowDialog();
        }
    }
}
