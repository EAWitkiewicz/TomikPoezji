using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace tomik
{
    public partial class Form1 : Form
    {
        private ListaDwukierunkowa listaWierszy;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listaWierszy = new ListaDwukierunkowa();

            deserializacja();

            Wiersz aktualnyWiersz = listaWierszy.PobierzAktualny();


            if (aktualnyWiersz != null)
            {
                lbTytul.Text = aktualnyWiersz.Tytul;
                lbTresc.Text = aktualnyWiersz.Zawartosc;
                lbNrStrony.Text = aktualnyWiersz.NumerStrony.ToString();
            }

            przezoczystosc();
        }

        public void deserializacja()
        {
            String ile = "";
            uint i = 0;
            XmlSerializer serializer = new XmlSerializer(typeof(String));
            try
            {
                using (FileStream fs = new FileStream(path: Environment.CurrentDirectory + "\\Ile.xml", FileMode.Open, FileAccess.Read))
                {
                    ile = serializer.Deserialize(fs) as String;
                    if (ile != null)
                    {
                        i = uint.Parse(ile);
                    }
                   
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                return;
            }
            Wiersz[] tablica = new Wiersz[i];
            serializer = new XmlSerializer(typeof(Wiersz[]));
            using (FileStream fs = new FileStream(path: Environment.CurrentDirectory + "\\wiersz.xml", FileMode.Open, FileAccess.Read))
            {
                tablica = serializer.Deserialize(fs) as Wiersz[];
            }
            for (uint j = 0; j < i; j++)
            {
               
                this.listaWierszy.DodajWiersz(new Wiersz(tablica[j].Tytul, tablica[j].Zawartosc));
            }
        }


        private void przezoczystosc()
        {
            btnDopisz.FlatStyle = FlatStyle.Flat;
            btnDopisz.FlatAppearance.BorderSize = 0;
            btnDopisz.BackColor = Color.Transparent;
            btnDopisz.Parent = this;
            btnDopisz.UseVisualStyleBackColor = true;

            btnNastepny.FlatStyle = FlatStyle.Flat;
            btnNastepny.FlatAppearance.BorderSize = 0;
            btnNastepny.BackColor = Color.Transparent;
            btnNastepny.Parent = this;
            btnNastepny.UseVisualStyleBackColor = true;

            btnPoprzedni.FlatStyle = FlatStyle.Flat;
            btnPoprzedni.FlatAppearance.BorderSize = 0;
            btnPoprzedni.BackColor = Color.Transparent;
            btnPoprzedni.Parent = this;
            btnPoprzedni.UseVisualStyleBackColor = true;

            btnWyrwij.FlatStyle = FlatStyle.Flat;
            btnWyrwij.FlatAppearance.BorderSize = 0;
            btnWyrwij.BackColor = Color.Transparent;
            btnWyrwij.Parent = this;
            btnWyrwij.UseVisualStyleBackColor = true;

            lbNrStrony.FlatStyle = FlatStyle.Flat;
            lbNrStrony.BackColor = Color.Transparent;
            lbNrStrony.Parent = this;

            lbNrStrony.FlatStyle = FlatStyle.Flat;
            lbNrStrony.BackColor = Color.Transparent;
            lbNrStrony.Parent = this;

            lbNrStrony.FlatStyle = FlatStyle.Flat;
            lbNrStrony.BackColor = Color.Transparent;
            lbNrStrony.Parent = this;

            lbTytul.FlatStyle = FlatStyle.Flat;
            lbTytul.BackColor = Color.Transparent;
            lbTytul.Parent = this;

            lbNrStrony.FlatStyle = FlatStyle.Flat;
            lbNrStrony.BackColor = Color.Transparent;
            lbNrStrony.Parent = this;

            lbTresc.FlatStyle = FlatStyle.Flat;
            lbTresc.BackColor = Color.Transparent;
            lbTresc.Parent = this;
        }
        private void btnPoprzedni_Click(object sender, EventArgs e)
        {
            listaWierszy.PrzejdzDoPoprzedniego();

          
            Wiersz aktualnyWiersz = listaWierszy.PobierzAktualny();

            
            if (aktualnyWiersz != null)
            {
                lbTytul.Text = aktualnyWiersz.Tytul;
                lbTresc.Text = aktualnyWiersz.Zawartosc;
                lbNrStrony.Text = aktualnyWiersz.NumerStrony.ToString();
            }
        }

        private void btnNastepny_Click(object sender, EventArgs e)
        {
            
            listaWierszy.PrzejdzDoNastepnego();

            
            Wiersz aktualnyWiersz = listaWierszy.PobierzAktualny();

            
            if (aktualnyWiersz != null)
            {
                lbTytul.Text = aktualnyWiersz.Tytul;
                lbTresc.Text = aktualnyWiersz.Zawartosc;
                lbNrStrony.Text = aktualnyWiersz.NumerStrony.ToString();
            }
        }

        private void btnDopisz_Click(object sender, EventArgs e)
        {
            using (DopiszWierszForm dopiszWierszForm = new DopiszWierszForm())
            {
                if (dopiszWierszForm.ShowDialog() == DialogResult.OK)
                {
                    string tytul = dopiszWierszForm.Tytul;
                    string tresc = dopiszWierszForm.Tresc;

                    Wiersz nowyWiersz = new Wiersz(tytul, tresc);
                    listaWierszy.DodajWiersz(nowyWiersz);
            

                    listaWierszy.PrzejdzDoNastepnego();
                    Wiersz aktualnyWiersz = listaWierszy.PobierzAktualny();
                    if (aktualnyWiersz != null)
                    {
                        lbTytul.Text = aktualnyWiersz.Tytul;
                        lbTresc.Text = aktualnyWiersz.Zawartosc;
                        lbNrStrony.Text = aktualnyWiersz.NumerStrony.ToString();
                    }

                    // Informacja o sukcesie
                    //MessageBox.Show("Nowy wiersz został dodany!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnWyrwij_Click(object sender, EventArgs e)
        {
            Wiersz aktualnyWiersz = listaWierszy.PobierzAktualny();

            if (aktualnyWiersz == null)
            {
                MessageBox.Show("Nie ma kartek do wyrwania!");
                return;
            }

            listaWierszy.UsunWiersz(aktualnyWiersz.NumerStrony);

            Wiersz nowyAktualnyWiersz = listaWierszy.PobierzAktualny();

            if (nowyAktualnyWiersz != null)
            {
                lbTytul.Text =nowyAktualnyWiersz.Tytul;
                lbTresc.Text = nowyAktualnyWiersz.Zawartosc;
                lbNrStrony.Text = nowyAktualnyWiersz.NumerStrony.ToString();
            }
            else
            {
               MessageBox.Show("To początek", "Informacja");
                lbTytul.Text = "Brak weny";
                lbTresc.Text = "";
                lbNrStrony.Text = "";
            }
        }

        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Wiersz[])); //utworzenie serializatora (no aby mógł zczytać)
            Wiersz[] tablica = new Wiersz[listaWierszy.ile]; //utworzenie tablicy Mockupów produktowych. czyli klasa a'la NodeL, tylko bez prev, next, bo tego nie chcemy zapisać do xmla, bo mogło by się wyjebać.
            Wezel wiersz = listaWierszy.pierwszy; //ustawienie "indeksu"
            for (int i = 0; i < listaWierszy.ile; i++)
            {

                tablica[i] = new Wiersz(wiersz.Wiersz.Tytul,wiersz.Wiersz.Zawartosc); // przerzucenie z produktu do mockupa
                wiersz = wiersz.Nastepny; //przejście dalej
            }
            using (FileStream fs = new FileStream(path: Environment.CurrentDirectory + "\\wiersz.xml", FileMode.Create, FileAccess.Write))
            {
                serializer.Serialize(fs, tablica);//serializacja tablicy


            }
            serializer = new XmlSerializer(typeof(String));
            using (FileStream fs = new FileStream(path: Environment.CurrentDirectory + "\\Ile.xml", FileMode.Create, FileAccess.Write))
            {
                serializer.Serialize(fs, listaWierszy.ile.ToString());//serializacja ile elementów było
            }

        }
    }
}
