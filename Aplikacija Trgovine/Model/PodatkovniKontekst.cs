using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija_Trgovine.Model
{
    internal class PodatkovniKontekst
    {


        public List<Kupac> Kupci;
        public List<Proizvod> Proizvodi;
        public List<Narudzba> Narudzba;

        private void main(string[] args)
        {

        }


        public void DodavanjeKupcacs(String kupac1)
        {

            List<String> popisKupca = new List<string>();
            StreamReader streamReaderKupac = new StreamReader("Popis Kupaca.txt");
            while (!streamReaderKupac.EndOfStream)
            {
                popisKupca.Add(streamReaderKupac.ReadLine());
            }
            streamReaderKupac.Close();

            popisKupca.Add(kupac1);
            StreamWriter streamWriterKupac = new StreamWriter("Popis Kupaca.txt");
            foreach (string a in popisKupca)
            {
                streamWriterKupac.WriteLine(a);
            }
            streamWriterKupac.Close();
        }


        public void Dodajproizvod(String proizvod1)
        {
            List<String> popisproizvoda = new List<string>();

            StreamReader streamReaderProizvodi = new StreamReader("Popis proizvoda.txt");
            while (!streamReaderProizvodi.EndOfStream)
            {
                popisproizvoda.Add(streamReaderProizvodi.ReadLine());
            }
            streamReaderProizvodi.Close();

            StreamWriter streamWriterproizvodi = new StreamWriter("Popis proizvoda.txt");
            foreach (string a in popisproizvoda)
            {
                streamWriterproizvodi.WriteLine(a);
            }

            streamWriterproizvodi.Close();
        }


        public void CitanjeProizvoda()
        {
            StreamReader streamReaderProizvodi = new StreamReader("Popis proizvoda.txt");

        }

        public List<string> DohvacanjeKupaca()
        {
            int i = 0;
            List<String> popisKupca = new List<string>();
            StreamReader streamReaderKupac = new StreamReader("Popis Kupaca.txt");
            while (!streamReaderKupac.EndOfStream)
            {
                popisKupca.Add(streamReaderKupac.ReadLine());
            }
            streamReaderKupac.Close();
            return popisKupca;
        }


        public List<string> DohvacanjeProizvoda()
        {
            int i = 0;
            List<string> popisProizvoda = new List<string>();
            StreamReader streamReaderProizvoda = new StreamReader("Popis proizvoda.txt");
            while (!streamReaderProizvoda.EndOfStream)
            {
                popisProizvoda.Add(streamReaderProizvoda.ReadLine());
            }
            streamReaderProizvoda.Close();
            return popisProizvoda;
        }

       


    }
}
