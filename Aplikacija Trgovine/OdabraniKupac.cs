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
    public partial class OdabraniKupac : Form
    {
        public int IndexOdabraneStavke { get; set; }
        public OdabraniKupac(Kupac kupac)
        {
            InitializeComponent();
            PrikaziPodatke();

            textBox1.Text = kupac.Ime;
            textBox2.Text = kupac.Prezime;
            textBox3.Text = kupac.OIB;
            kupac.Godine = int.Parse(textBox4.Text);
        }

        private void PrikaziPodatke()
        {
            using (StreamReader reader = new StreamReader("Kupac.txt"))
            {
                textBox1.Text = reader.ReadLine();
                textBox2.Text = reader.ReadLine();
                textBox3.Text = reader.ReadLine();
                textBox4.Text = reader.ReadLine();
               
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("Kupac.txt", true))
            {
                writer.WriteLine(textBox1.Text);
                writer.WriteLine(textBox2.Text);
                writer.WriteLine(textBox3.Text);
                writer.WriteLine(textBox4.Text);
            }
        }
    }
}
