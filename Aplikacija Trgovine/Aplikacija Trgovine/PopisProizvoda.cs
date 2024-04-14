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
    public partial class PopisProizvoda : Form
    {
        public PopisProizvoda()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            PodatkovniKontekst podatkovnikontekstProizvod = new PodatkovniKontekst();
            
        }


        public void Popis()
        {
            if (File.Exists("Proizvod.txt"))
            {
                using (StreamReader reader = new StreamReader("Proizvod.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] podaci = line.Split(',');
                        string ProizvodPodaci = $"NazivProizvoda: {podaci[0]}, Kategorija: {podaci[1]}, Cijena: {podaci[2]}, Kolicina: {podaci[3]}";
                        listBox1.Items.Add(ProizvodPodaci);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PopisProizvodaUredivanje UrediProizvod = new PopisProizvodaUredivanje();
            UrediProizvod.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodavanjeProizvoda DodajProizvod = new DodavanjeProizvoda();
            DodajProizvod.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PopisProizvodaBrisanje IzbrisiProizvod = new PopisProizvodaBrisanje();
            IzbrisiProizvod.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool filterJelo = !string.IsNullOrWhiteSpace(textBoxCJ1.Text) && !string.IsNullOrWhiteSpace(textBoxCJ2.Text);
            bool filterPice = !string.IsNullOrWhiteSpace(textBoxCP1.Text) && !string.IsNullOrWhiteSpace(textBoxCP2.Text);

            listBox1.Items.Clear();

            if (File.Exists("Menu.txt"))
            {
                using (StreamReader reader = new StreamReader("Proizvod.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] podaci = line.Split(',');

                        if (filterJelo)
                        {
                            int cijenaJela = int.Parse(podaci[1]);
                            int cijenaJelaMin = int.Parse(textBoxCJ1.Text);
                            int cijenaJelaMax = int.Parse(textBoxCJ2.Text);

                            if (cijenaJela < cijenaJelaMin || cijenaJela > cijenaJelaMax)
                                continue;
                        }

                        if (filterPice)
                        {
                            int cijenaPica = int.Parse(podaci[3]);
                            int cijenaPicaMin = int.Parse(textBoxCP1.Text);
                            int cijenaPicaMax = int.Parse(textBoxCP2.Text);

                            if (cijenaPica < cijenaPicaMin || cijenaPica > cijenaPicaMax)
                                continue;
                        }

                        string menuPodaci = $"Jelo: {podaci[0]}, Cijena: {podaci[1]}, Piće: {podaci[2]}, Cijena pića: {podaci[3]}";
                        listBox1.Items.Add(menuPodaci);
                    }
                }
            }
            else
            {
                MessageBox.Show("Datoteka s jelima i pićima ne postoji!");
            }
        }

       
            private void buttonFilter_Click(object sender, EventArgs e)
            {
                bool filterJelo = !string.IsNullOrWhiteSpace(textBoxCJ1.Text) && !string.IsNullOrWhiteSpace(textBoxCJ2.Text);
                bool filterPice = !string.IsNullOrWhiteSpace(textBoxCP1.Text) && !string.IsNullOrWhiteSpace(textBoxCP2.Text);

                listBox1.Items.Clear();

                if (File.Exists("Menu.txt"))
                {
                    using (StreamReader reader = new StreamReader("Menu.txt"))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] podaci = line.Split(',');

                            if (filterJelo)
                            {
                                int cijenaJela = int.Parse(podaci[1]);
                                int cijenaJelaMin = int.Parse(textBoxCJ1.Text);
                                int cijenaJelaMax = int.Parse(textBoxCJ2.Text);

                                if (cijenaJela < cijenaJelaMin || cijenaJela > cijenaJelaMax)
                                    continue;
                            }

                            if (filterPice)
                            {
                                int cijenaPica = int.Parse(podaci[3]);
                                int cijenaPicaMin = int.Parse(textBoxCP1.Text);
                                int cijenaPicaMax = int.Parse(textBoxCP2.Text);

                                if (cijenaPica < cijenaPicaMin || cijenaPica > cijenaPicaMax)
                                    continue;
                            }

                            string menuPodaci = $"Jelo: {podaci[0]}, Cijena: {podaci[1]}, Piće: {podaci[2]}, Cijena pića: {podaci[3]}";
                            listBox1.Items.Add(menuPodaci);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Datoteka s jelima i pićima ne postoji!");
                }
            }
    }
}
