using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija_Trgovine.Model
{
    internal class Narudzba : IComparable
    {

        public Kupac kupac { get; set; }
        public Proizvod proizvod { get; set; }

        public DateTime DatumNarudzbe { get; set; }



        public override string ToString()
        {
            return "Kupac" + kupac + "Proizvod " + proizvod + " DatumNarudzbe" + DatumNarudzbe;
        }


        public int CompareTo(object obj)
        {
            int rez = this.DatumNarudzbe.CompareTo(((Narudzba)obj).DatumNarudzbe);
            if (rez == 0)
                rez = this.kupac.CompareTo(((Narudzba)obj).kupac);
            return rez;
        }
    }
}
