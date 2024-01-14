using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacija_Trgovine
{
    public partial class PreurediKupca : Form
    {
        public PreurediKupca()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private int trenutniIndeks;

        public void PostaviTrenutniIndeks(int indeks)
        {
            trenutniIndeks = indeks;
        }


        public void PostaviPodatke(string ime, string prezime, string OIB, string Godine)
        {
            textBox1.Text = ime;
            textBox2.Text = prezime;
            textBox3.Text = OIB;
            textBox4.Text = Godine;
        }

        public string DohvatiPodatkeZaSpremanje()
        {
            string podaciZaSpremanje = $"{textBox1.Text} {textBox2.Text}, {textBox3.Text}, {textBox4.Text}";
            return podaciZaSpremanje;
        }


        private void button1_Click(object sender, EventArgs e)
        {

            string ime = textBox1.Text;
            string prezime = textBox2.Text;
            string OIB = textBox3.Text;
            string Godine = textBox4.Text;

            AzurirajPodatkeUDatoteci(ime, prezime, OIB, Godine, trenutniIndeks);

            this.Close();

        }

        private void AzurirajPodatkeUDatoteci(string ime, string prezime, string OIB, string Godine, int indeks)
        {
            string putanjaDoDatoteke = "Kupac.txt";

            string[] linije = File.ReadAllLines(putanjaDoDatoteke);

            if (indeks >= 0 && indeks < linije.Length)
            {
                linije[indeks] = $"{ime},{prezime},{OIB},{Godine}";

                File.WriteAllLines(putanjaDoDatoteke, linije);
            }


        }

        private void PreurediKupca_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string dashText = textBox3.Text.Replace("-", "");

            if (dashText.Length >= 3)
            {
                dashText = dashText.Insert(3, "-");
                if (dashText.Length == 4)
                    textBox3.SelectionStart = 4;
            }
            if (dashText.Length >= 7)
            {
                dashText = dashText.Insert(7, "-");
                if (dashText.Length == 8)
                    textBox3.SelectionStart = 8;

            }
            textBox3.Text = dashText;

            if (textBox3.Text.Length > 12)
            {
                textBox3.Text = textBox3.Text.Substring(0, 12);
                textBox3.SelectionStart = textBox3.Text.Length;
            }
        }
    }
    }

