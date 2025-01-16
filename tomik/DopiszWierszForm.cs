using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tomik
{
    public partial class DopiszWierszForm : Form
    {
        public string Tytul { get; private set; }
        public string Tresc { get; private set; }
        public DopiszWierszForm()
        {
            InitializeComponent();
            przezoczystosc();

        }
        private void przezoczystosc()
        {
            btnZapisz.FlatStyle = FlatStyle.Flat;
            btnZapisz.FlatAppearance.BorderSize = 0;
            btnZapisz.BackColor = Color.Transparent;
            btnZapisz.Parent = this;
            btnZapisz.UseVisualStyleBackColor = true;

            btnWyrwij.FlatStyle = FlatStyle.Flat;
            btnWyrwij.FlatAppearance.BorderSize = 0;
            btnWyrwij.BackColor = Color.Transparent;
            btnWyrwij.Parent = this;
            btnWyrwij.UseVisualStyleBackColor = true;

        }
        private void btnZapisz_Click(object sender, EventArgs e)
        {
            Tytul = rtxtTytulDWF.Text;
            Tresc = rtxtTrescDWF.Text;

            if ( string.IsNullOrWhiteSpace(Tresc))
            {
                MessageBox.Show("Wiersz musi zawierać treść");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
