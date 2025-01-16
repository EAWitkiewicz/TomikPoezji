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


        

            przezoczystosc();
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
            
            
        }
    }
}
