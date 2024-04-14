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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Aplikacija_Trgovine
{
    public partial class DodavanjeProizvoda : Form
    {

        Proizvod proizvod = new Proizvod();

        private int trenutniIndeks;

        public DodavanjeProizvoda()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
        }





        private void button1_Click(object sender, EventArgs e)
        {

            string NazivProizvoda = textBox1.Text;
            string Kategorija = textBox2.Text;
            string Cijena = textBox3.Text;
            string Kolicina = textBox4.Text;



            using (StreamWriter sw = new StreamWriter("Menu.txt", true))
            {
                sw.WriteLine($"{proizvod.NazivProizvoda},{proizvod.Kategorija},{proizvod.Cijena},{proizvod.Kolicina}");
            }



        }




    }
}