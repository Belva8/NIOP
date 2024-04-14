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
    public partial class DodavanjeKupca : Form
    {

        Kupac kupac = new Kupac();

        private PopisKupaca formPrikaziKupce;


        public DodavanjeKupca()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;


            textBox3.TextChanged += textBox3_TextChanged;
            formPrikaziKupce = new PopisKupaca();

        }




        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {


            string dashText = textBox3.Text.Replace("-", "");

            if (dashText.Length >= 3)
            {
                dashText = dashText.Insert(3, "-");
                if (dashText.Length == 4)
                    textBox3.SelectionStart = 4;
            }
            if (dashText.Length >= 7)
            {
                dashText = dashText.Insert(7, "-");
                if (dashText.Length == 8)
                    textBox3.SelectionStart = 8;

            }
            textBox3.Text = dashText;

            if (textBox3.Text.Length > 12)
            {
                textBox3.Text = textBox3.Text.Substring(0, 12);
                textBox3.SelectionStart = textBox3.Text.Length;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kupac.Ime = textBox1.Text;
            kupac.Prezime = textBox2.Text;
            kupac.OIB = textBox3.Text;
            kupac.Godine = int.Parse(textBox4.Text);

            using (StreamWriter sw = new StreamWriter("Kupac.txt", true))
            {
                sw.WriteLine($"{kupac.Ime},{kupac.Prezime},{kupac.OIB},{kupac.Godine}");


            }
            if (textBox1.Text.ToString() == "" || textBox2.Text.ToString() == "" || textBox3.Text.ToString() == "" || textBox4.Text.ToString() == "")
            {
                MessageBox.Show("Niste unijeli sve");
            }
            else
            {
                PodatkovniKontekst podatkovniKontekstKupac = new PodatkovniKontekst();
                String varijabla = $"{textBox1.Text} - {textBox2.Text} - {textBox3.Text} - {textBox4.Text}";
                podatkovniKontekstKupac.DodavanjeKupcacs(varijabla);
            }

        }

    
        

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = null;
            textBox4.Text = string.Empty;
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            string dashText = textBox3.Text.Replace("-", "");

            if (dashText.Length >= 3)
            {
                dashText = dashText.Insert(3, "-");
                if (dashText.Length == 4)
                    textBox3.SelectionStart = 4;
            }
            if (dashText.Length >= 7)
            {
                dashText = dashText.Insert(7, "-");
                if (dashText.Length == 8)
                    textBox3.SelectionStart = 8;

            }
            textBox3.Text = dashText;

            if (textBox3.Text.Length > 12)
            {
                textBox3.Text = textBox3.Text.Substring(0, 12);
                textBox3.SelectionStart = textBox3.Text.Length;
            }
        }

        internal static void OsvjeziTextBoxove()
        {
            throw new NotImplementedException();
        }
    }
    }


    


    

