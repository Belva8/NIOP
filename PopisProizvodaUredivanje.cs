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
    public partial class PopisProizvodaUredivanje : Form
    {
        public PopisProizvodaUredivanje()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        UcitajPodatkeOKupcu();
        }


        private void UcitajPodatkeOKupcu()
        {
            using (StreamReader reader = new StreamReader("Proizvod.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] podaci = line.Split(',');
                    string KupacPodaci = $"{podaci[0]}, {podaci[1]}, {podaci[2]}, {podaci[3]}, ";
                    listBox1.Items.Add(KupacPodaci);
                }
            }
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UrediProizvod();
        }


        public void UrediProizvod()
        {
            if (listBox1.SelectedItem != null)
            {
                int indeks = listBox1.SelectedIndex;
                string odabraniPodaci = listBox1.SelectedItem.ToString();

                string[] podaci = odabraniPodaci.Split(new[] { ", " }, StringSplitOptions.None);

                if (podaci.Length >= 4)
                {
                   PreurediProizvod formEditProizvod = new PreurediProizvod();

                    formEditProizvod.PostaviPodatke(podaci[0], podaci[1], podaci[2], podaci[3]);
                    formEditProizvod.PostaviTrenutniIndeks(indeks);
                    if (formEditProizvod.ShowDialog() == DialogResult.OK)
                    {
                        string[] linije = File.ReadAllLines("Proizvod.txt");

                        linije[indeks] = $"{formEditProizvod.DohvatiPodatkeZaSpremanje()}";

                        File.WriteAllLines("Proizvod.txt", linije);
                    }
                }
            }
        }

    }
}
