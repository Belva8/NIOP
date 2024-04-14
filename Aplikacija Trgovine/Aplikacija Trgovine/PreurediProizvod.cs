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
    public partial class PreurediProizvod : Form
    {


        private int trenutniIndeks;
        public PreurediProizvod()
        {

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public void PostaviTrenutniIndeks(int indeks)
        {
            trenutniIndeks = indeks;
        }

        public void PostaviPodatke(string nazivProizvoda, string kategorija, string cijena, string kolicina)
        {
            textBox1.Text = nazivProizvoda;
            textBox2.Text = kategorija;
            textBox3.Text = cijena;
            textBox4.Text = kolicina;
        }

        public string DohvatiPodatkeZaSpremanje()
        {
            string podaciZaSpremanje = $"{textBox1.Text} {textBox2.Text}, {textBox3.Text}, {textBox4.Text}";
            return podaciZaSpremanje;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nazivProizvoda = textBox1.Text;
            string kategorija = textBox2.Text;
            string cijena= textBox3.Text;
            string kolicina = textBox4.Text;

            AzurirajPodatkeUDatoteci(nazivProizvoda, kategorija, cijena, kolicina, trenutniIndeks);

            this.Close();
        }
        private void AzurirajPodatkeUDatoteci(string nazivProizvoda, string kategorija, string cijena, string kolicina, int indeks)
        {
            string putanjaDoDatoteke = "Proizvod.txt";

            string[] linije = File.ReadAllLines(putanjaDoDatoteke);

            if (indeks >= 0 && indeks < linije.Length)
            {
                linije[indeks] = $"{nazivProizvoda},{kategorija},{cijena},{kolicina}";

                File.WriteAllLines(putanjaDoDatoteke, linije);
            }
            else
            {
                MessageBox.Show("Neispravan indeks.");
            }
        }

    }
}
