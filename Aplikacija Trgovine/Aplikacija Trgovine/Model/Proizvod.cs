using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija_Trgovine.Model
{
    internal class Proizvod : IComparable
    {

        public string NazivProizvoda { get; set; }

        public string Kategorija { get; set; }

        public string Cijena { get; set; }

        public int Kolicina { get; set; }

        public override string ToString()
        {
            return "Naziv Proizvoda " + NazivProizvoda + "Kategorija " + Kategorija + " Cijena " + Cijena + " Kolicina " + Cijena;

        }


        public int CompareTo(object obj)
        {
            int rez = this.NazivProizvoda.CompareTo(((Proizvod)obj).NazivProizvoda);
            if (rez == 0)
                rez = this.NazivProizvoda.CompareTo(((Proizvod)obj).NazivProizvoda);
            return rez;
        }
    }
}
