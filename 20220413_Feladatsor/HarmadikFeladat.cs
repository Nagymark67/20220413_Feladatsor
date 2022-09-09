using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.IO;

namespace _20220413_Feladatsor
{
    public partial class HarmadikFeladat : Form
    {
        public HarmadikFeladat()
        {
            InitializeComponent();
        }

        public struct jelentkezo
        {
            public string Nev;
            public int SzulEv;
            public string Nyelv;
            public string Szint;
        }
        List<jelentkezo> ListJelentkezok = new List<jelentkezo>(); 
        private void HarmadikFeladat_Load(object sender, EventArgs e)
        {
            this.Text = "Nyelvtanfolyam - jelentkezés";
            label1.Text = "Név:";
            label2.Text = "Születési év:";
            label3.Text = "Nyelv:";
            label4.Text = "Szint:";
            Adatbevitel_Gomb.Text = "Adatbevitel";
            Valogatas_Gomb.Text = "Válogatás, kíírás";
            Nyelv_ComboBox.Items.Add("angol");
            Nyelv_ComboBox.Items.Add("német");
            Nyelv_ComboBox.Items.Add("francia");
            Szint_ComboBox.Items.Add("kezdő");
            Szint_ComboBox.Items.Add("középhaladó");
            Szint_ComboBox.Items.Add("haladó");
        }

        private void Adatbevitel_Gomb_Click(object sender, EventArgs e)
        {
            try
            {
                jelentkezo lista = new jelentkezo();
                lista.Nev = Nev_TextBox.Text.ToString();
                lista.SzulEv = int.Parse(SzulEv_TextBox.Text);
                lista.Nyelv = Nyelv_ComboBox.SelectedItem.ToString();
                lista.Szint = Szint_ComboBox.SelectedItem.ToString();
                ListJelentkezok.Add(lista);
                Nev_TextBox.Text = "";
                SzulEv_TextBox.Text = "";
                Nyelv_ComboBox.ResetText();
                Szint_ComboBox.ResetText();
            }
            catch (FormatException)
            {
                MessageBox.Show("Kérem ellenőrizze, hogy az összes adatot a megfelelő formátumban adta meg!", "Hiba!", MessageBoxButtons.OK);                
            }
        }

        private void Valogatas_Gomb_Click(object sender, EventArgs e)
        {            
            StreamWriter angol = new StreamWriter("angol.txt");
            StreamWriter nemet = new StreamWriter("nemet.txt");
            StreamWriter francia = new StreamWriter("francia.txt");            
            for (int i = 0; i < ListJelentkezok.Count; i++)
            {
                if (ListJelentkezok[i].Nyelv == "angol")
                {
                    angol.WriteLine("{0}, {1}, {2}, {3}", ListJelentkezok[i].Nev, ListJelentkezok[i].SzulEv, ListJelentkezok[i].Nyelv, ListJelentkezok[i].Szint);
                }
                if (ListJelentkezok[i].Nyelv == "német")
                {
                    nemet.WriteLine("{0}, {1}, {2}, {3}", ListJelentkezok[i].Nev, ListJelentkezok[i].SzulEv, ListJelentkezok[i].Nyelv, ListJelentkezok[i].Szint);
                }
                if (ListJelentkezok[i].Nyelv == "francia")
                {
                    francia.WriteLine("{0}, {1}, {2}, {3}", ListJelentkezok[i].Nev, ListJelentkezok[i].SzulEv, ListJelentkezok[i].Nyelv, ListJelentkezok[i].Szint);
                }
            }
            angol.Close();
            nemet.Close();
            francia.Close();
        }

        private void HarmadikFeladat_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 Fokepernyo = new Form1();
            this.Hide();
            Fokepernyo.ShowDialog();
            this.Close();
        }

        private void FajlMegjelenites_Gomb_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"D:\vs_repos\20220413_Feladatsor\20220413_Feladatsor\bin\Debug";
            openFileDialog.ShowDialog();
            string Fajlnev = openFileDialog.FileName.ToString(); 
                        
        }        
    }
}
