using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomik
{
    public class Wiersz
    {
        public string Tytul { get; set; }
        public string Zawartosc { get; set; }
        public int NumerStrony { get; set; }

        public Wiersz()
        {
        }
        public Wiersz(string tytul, string zawartosc)
        {
            Tytul = tytul;
            Zawartosc = zawartosc;
        }   
    }
}
