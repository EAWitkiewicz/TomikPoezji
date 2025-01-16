using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace tomik
{
    public class ListaDwukierunkowa
    {
        private Wezel pierwszy;
        private Wezel ostatni;
        private Wezel aktualny { get; set; }
        

        public ListaDwukierunkowa()
        {
            pierwszy = null;
            ostatni = null;
            aktualny = null;
        }


        public void DodajWiersz(Wiersz wiersz)
        {
            Wezel nowyWezel = new Wezel(wiersz);
            if (pierwszy == null)
            {
                pierwszy=nowyWezel;
                ostatni=nowyWezel;
                aktualny = pierwszy;
            }
            else
            {
                ostatni.Nastepny = nowyWezel;
                nowyWezel.Poprzedni = ostatni;
                ostatni = nowyWezel;
            }
            AktualizujNumeryStron();
        }

        public void UsunWiersz(int numerStrony)
        {
            Wezel obecny = pierwszy;

            while (obecny != null)
            {
                if (obecny.Wiersz.NumerStrony == numerStrony)
                {
                    if (obecny.Poprzedni == null && obecny.Nastepny == null)
                    {
                        pierwszy = null;
                        ostatni = null;
                        aktualny = null;
                    }
                    else if (obecny.Poprzedni != null) 
                    {
                        obecny.Poprzedni.Nastepny = obecny.Nastepny;

                        if (obecny.Nastepny != null)
                        {
                            obecny.Nastepny.Poprzedni = obecny.Poprzedni;
                        }
                        else
                        {
                            ostatni = obecny.Poprzedni;
                        }

                        aktualny = obecny.Poprzedni;
                    }
                    else if (obecny.Nastepny != null)
                    {
                        obecny.Nastepny.Poprzedni = null;
                        pierwszy = obecny.Nastepny;
                        aktualny = obecny.Nastepny;
                    }

                    
                    AktualizujNumeryStron();
                    return;
                }

                obecny = obecny.Nastepny;
            }
        }


        public Wiersz PobierzAktualny()
        {
            if (aktualny != null)
            {
                return aktualny.Wiersz;
            }
            else
            {
                return null;
            }
        }

        public void PrzejdzDoNastepnego()
        {
            if (aktualny != null && aktualny.Nastepny != null)
            {
                aktualny = aktualny.Nastepny;
            }
            else
            {
               MessageBox.Show( "To już koniec");
            }
        }

        public void PrzejdzDoPoprzedniego()
        {
            if (aktualny != null && aktualny.Poprzedni != null)
            {
                aktualny = aktualny.Poprzedni;
                
            }
            else
            {
                MessageBox.Show( "To początek");
            }
        }

        private void AktualizujNumeryStron()
        {
            Wezel obecny = pierwszy;
            int numerStrony = 1;

            while (obecny != null)
            {
                obecny.Wiersz.NumerStrony = numerStrony;
                numerStrony++;
                obecny = obecny.Nastepny;
            }
        }
        public List<Wiersz> PobierzWszystkieWiersze()
        {
            List<Wiersz> wiersze = new List<Wiersz>();
            Wezel obecny = pierwszy;

            while (obecny != null)
            {
                wiersze.Add(obecny.Wiersz);
                obecny = obecny.Nastepny;
            }

            return wiersze;
        }

    }
}
