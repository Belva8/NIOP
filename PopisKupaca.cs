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
    }
}
