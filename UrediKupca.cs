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
    public partial class UrediKupca : Form
    {
        public UrediKupca()
        {
            InitializeComponent();
            UcitajPodatkeOKupcima();
        }

        public void UcitajPodatkeOKupcima()
        {
            using (StreamReader reader = new StreamReader("Kupac.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] podaci = line.Split(',');
                    string gostPodaci = $"{podaci[0]} {podaci[1]}, {podaci[2]}, {podaci[3]}";
                    listBox1.Items.Add(gostPodaci);
                }
            }
        }




        private void urediKupca()
        {
            if (listBox1.SelectedItem != null)
            {
                string odabraniPodaci = listBox1.SelectedItem.ToString();
                string[] podaci = odabraniPodaci.Split(' ');

                if (podaci.Length >= 4)
                {
                   PreurediKupca formEditKupac = new PreurediKupca();

                    formEditKupac.PostaviPodatke(podaci[0], podaci[1].TrimEnd(','), podaci[2], podaci[3]);

                    if (formEditKupac.ShowDialog() == DialogResult.OK)
                    {
                        List<string> linije = new List<string>();
                        using (StreamReader sr = new StreamReader("Kupac.txt"))
                        {
                            while (!sr.EndOfStream)
                            {
                                linije.Add(sr.ReadLine());
                            }
                        }

                        linije[listBox1.SelectedIndex] = formEditKupac.DohvatiPodatkeZaSpremanje();
                        using (StreamWriter sw = new StreamWriter("Kupac.txt", false))
                        {
                            foreach (string linija in linije)
                            {
                                sw.WriteLine(linija);
                            }
                        }
                    }
                }
            }
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            urediKupca();

        }

       
    }

     }

