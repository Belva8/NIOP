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
                        string menuPodaci = $"NazivProizvoda: {podaci[0]}, Kategorija: {podaci[1]}, Cijena: {podaci[2]}, Kolicina: {podaci[3]}";
                        listBox1.Items.Add(menuPodaci);
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
    }
}
