using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomik
{
    public class Wezel
    {
        public Wiersz Wiersz { get; set; }
        public Wezel Nastepny{get;set;}
        public Wezel Poprzedni { get; set; }

        public Wezel (Wiersz wiersz)
        {
            Wiersz = wiersz;
            Nastepny = null;
            Poprzedni = null;
        }
    }
}
