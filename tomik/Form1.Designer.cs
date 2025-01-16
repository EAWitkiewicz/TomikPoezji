namespace tomik
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTytul = new System.Windows.Forms.Label();
            this.lbTresc = new System.Windows.Forms.Label();
            this.btnPoprzedni = new System.Windows.Forms.Button();
            this.btnNastepny = new System.Windows.Forms.Button();
            this.btnWyrwij = new System.Windows.Forms.Button();
            this.btnDopisz = new System.Windows.Forms.Button();
            this.lbNrStrony = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTytul
            // 
            this.lbTytul.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbTytul.Font = new System.Drawing.Font("Ink Free", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbTytul.Location = new System.Drawing.Point(10, 9);
            this.lbTytul.Name = "lbTytul";
            this.lbTytul.Size = new System.Drawing.Size(569, 80);
            this.lbTytul.TabIndex = 0;
            this.lbTytul.Text = "Tytuł ładną czcionką";
            // 
            // lbTresc
            // 
            this.lbTresc.AutoSize = true;
            this.lbTresc.Font = new System.Drawing.Font("Ink Free", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbTresc.Location = new System.Drawing.Point(12, 89);
            this.lbTresc.Name = "lbTresc";
            this.lbTresc.Size = new System.Drawing.Size(186, 20);
            this.lbTresc.TabIndex = 1;
            this.lbTresc.Text = "Treść z sensem lub bez";
            // 
            // btnPoprzedni
            // 
            this.btnPoprzedni.Font = new System.Drawing.Font("Ink Free", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnPoprzedni.Location = new System.Drawing.Point(70, 798);
            this.btnPoprzedni.Name = "btnPoprzedni";
            this.btnPoprzedni.Size = new System.Drawing.Size(75, 41);
            this.btnPoprzedni.TabIndex = 2;
            this.btnPoprzedni.Text = "<";
            this.btnPoprzedni.UseVisualStyleBackColor = true;
            this.btnPoprzedni.Click += new System.EventHandler(this.btnPoprzedni_Click);
            // 
            // btnNastepny
            // 
            this.btnNastepny.Font = new System.Drawing.Font("Ink Free", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnNastepny.Location = new System.Drawing.Point(423, 798);
            this.btnNastepny.Name = "btnNastepny";
            this.btnNastepny.Size = new System.Drawing.Size(75, 41);
            this.btnNastepny.TabIndex = 3;
            this.btnNastepny.Text = ">";
            this.btnNastepny.UseVisualStyleBackColor = true;
            this.btnNastepny.Click += new System.EventHandler(this.btnNastepny_Click);
            // 
            // btnWyrwij
            // 
            this.btnWyrwij.Font = new System.Drawing.Font("Ink Free", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnWyrwij.Location = new System.Drawing.Point(151, 798);
            this.btnWyrwij.Name = "btnWyrwij";
            this.btnWyrwij.Size = new System.Drawing.Size(119, 41);
            this.btnWyrwij.TabIndex = 6;
            this.btnWyrwij.Text = "wrwij";
            this.btnWyrwij.UseVisualStyleBackColor = true;
            this.btnWyrwij.Click += new System.EventHandler(this.btnWyrwij_Click);
            // 
            // btnDopisz
            // 
            this.btnDopisz.Font = new System.Drawing.Font("Ink Free", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnDopisz.Location = new System.Drawing.Point(276, 798);
            this.btnDopisz.Name = "btnDopisz";
            this.btnDopisz.Size = new System.Drawing.Size(141, 41);
            this.btnDopisz.TabIndex = 7;
            this.btnDopisz.Text = "dopisz";
            this.btnDopisz.UseVisualStyleBackColor = true;
            this.btnDopisz.Click += new System.EventHandler(this.btnDopisz_Click);
            // 
            // lbNrStrony
            // 
            this.lbNrStrony.AutoSize = true;
            this.lbNrStrony.Font = new System.Drawing.Font("Ink Free", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbNrStrony.Location = new System.Drawing.Point(520, 769);
            this.lbNrStrony.Name = "lbNrStrony";
            this.lbNrStrony.Size = new System.Drawing.Size(33, 20);
            this.lbNrStrony.TabIndex = 8;
            this.lbNrStrony.Text = "44";
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.BackgroundImage = global::tomik.Properties.Resources._896c8d1d_6ff8_4659_835f_0f82ece3eb47;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(585, 851);
            this.Controls.Add(this.lbNrStrony);
            this.Controls.Add(this.btnDopisz);
            this.Controls.Add(this.btnWyrwij);
            this.Controls.Add(this.btnNastepny);
            this.Controls.Add(this.btnPoprzedni);
            this.Controls.Add(this.lbTresc);
            this.Controls.Add(this.lbTytul);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Tomik Wierszy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTytul;
        private System.Windows.Forms.Label lbTresc;
        private System.Windows.Forms.Button btnPoprzedni;
        private System.Windows.Forms.Button btnNastepny;
        private System.Windows.Forms.Button btnWyrwij;
        private System.Windows.Forms.Button btnDopisz;
        private System.Windows.Forms.Label lbNrStrony;
    }
}

