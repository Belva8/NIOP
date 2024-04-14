using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija_Trgovine.Model
{
    public class Kupac : IComparable
    {





        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string OIB { get; set; }
        public int Godine{ get; set; }







        public override string ToString()
        {
            return Ime + " " + Prezime;
        }
        public int CompareTo(object obj)
        {
            int rez = this.Prezime.CompareTo(((Kupac)obj).Prezime);
            if (rez == 0)
                rez = this.Ime.CompareTo(((Kupac)obj).Ime);
            return rez;
        }





        
    }
}
