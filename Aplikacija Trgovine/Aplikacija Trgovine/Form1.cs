using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacija_Trgovine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            PopisKupaca FormKupac = new PopisKupaca();
            FormKupac.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            PopisProizvoda FormProizvod = new PopisProizvoda();

            FormProizvod.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajNarudzbu FormDodajNarudzbu = new DodajNarudzbu();

            FormDodajNarudzbu.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UrediNarudzbu FormUrediNarudzbu = new UrediNarudzbu();

            FormUrediNarudzbu.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ObrisiNarudzbu FormObrisiNarudzbu = new ObrisiNarudzbu();

            FormObrisiNarudzbu.ShowDialog();
        }
    }
}
