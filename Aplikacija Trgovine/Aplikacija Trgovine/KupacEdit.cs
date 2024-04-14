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
    public partial class KupacEdit : Form
    {

        DodavanjeKupca DodajKupca = new DodavanjeKupca();
        PopisKupaca FormKupac = new PopisKupaca();

        public KupacEdit()
        {
            InitializeComponent();
        }


        public void Uredjivanje()
        {
            using (StreamWriter streamWrite = new StreamWriter("Kupac.txt", true))
            {
                streamWrite.WriteLine(textBox1.Text);
                streamWrite.WriteLine(textBox2.Text);
                streamWrite.WriteLine(textBox3.Text);
                streamWrite.WriteLine(textBox4.Text);
                streamWrite.WriteLine();

                FormKupac.Show();
                this.Close();
            }

           DodavanjeKupca.OsvjeziTextBoxove();
        }


        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
