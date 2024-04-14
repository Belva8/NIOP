using Aplikacija_Trgovine.Model;
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
    public partial class PopisKupaca : Form
    {
        

        public PopisKupaca()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
         

        }


        public void Popis()
        {
            if (File.Exists("Kupac.txt"))
            {
                using (StreamReader reader = new StreamReader("Kupac.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] podaci = line.Split(',');
                        string gostPodaci = $"{podaci[0]} {podaci[1]}, OIB: {podaci[2]}, Godine: {podaci[3]}";
                        listBox1.Items.Add(gostPodaci);
                    }
                }
            }
            else
                MessageBox.Show("NEMA JE ");

        }


        private void button2_Click(object sender, EventArgs e)
        {
            UrediKupca UrediKupca = new UrediKupca();
            UrediKupca.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IzbrisiKupca IzbrisiKupca = new IzbrisiKupca();
            IzbrisiKupca.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodavanjeKupca DodajKupca = new DodavanjeKupca();
            DodajKupca.Show();
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FilterTextBox(TextBox textBox)
        {
            // Provjeri je li uneseni tekst broj
            if (!int.TryParse(textBox.Text, out _))
            {
                // Ako nije broj, obriši zadnji uneseni znak
                textBox.Text = textBox.Text.Length > 0 ? textBox.Text.Substring(0, textBox.Text.Length - 1) : "";
                // Postavi kursor na kraj polja
                textBox.SelectionStart = textBox.Text.Length;
            }
        }


        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (File.Exists("Kupac.txt"))
            {
                using (StreamReader reader = new StreamReader("Kupac.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] podaci = line.Split(',');
                        string gostPodaci = $"{podaci[0]} {podaci[1]}, Telefon: {podaci[2]}, Stol: {podaci[3]}";

                        if (gostPodaci.ToLower().Contains(searchBar.Text.ToLower()))
                        {
                            listBox1.Items.Add(gostPodaci);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Datoteka Kupca ne postoji!");
            }
        }


        private void buttonFilter_Click(object sender, EventArgs e)
        {

        }


        private void textBoxCS1_TextChanged(object sender, EventArgs e)
        {
            FilterTextBox(textBoxCS1);
        }

        private void textBoxCS2_TextChanged(object sender, EventArgs e)
        {
            FilterTextBox(textBoxCS2);
        }


        private void searchBar_Click(object sender, EventArgs e)
        {
            searchBar.Text = "";
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool filterNarudzbe = !string.IsNullOrWhiteSpace(textBoxCS1.Text) && !string.IsNullOrWhiteSpace(textBoxCS2.Text);
            int brojStolaMin = filterNarudzbe ? int.Parse(textBoxCS1.Text) : 0;
            int brojStolaMax = filterNarudzbe ? int.Parse(textBoxCS2.Text) : int.MaxValue;

            listBox1.Items.Clear();

            if (File.Exists("Kupac.txt"))
            {
                using (StreamReader reader = new StreamReader("Kupac.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] podaci = line.Split(',');
                        int brojStola = int.Parse(podaci[3]);

                        // Provjera da li broj stola nalazi unutar odabranog raspona
                        if (brojStola >= brojStolaMin && brojStola <= brojStolaMax)
                        {
                            string kupacPodaci = $"{podaci[0]} {podaci[1]}, Telefon: {podaci[2]}, Narudzbaid: {podaci[3]}";
                            listBox1.Items.Add(kupacPodaci);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Datoteka Kupca ne postoji!");
            }
        }

       
    }
}
