namespace tomik
{
    partial class DopiszWierszForm
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
            this.rtxtTytulDWF = new System.Windows.Forms.RichTextBox();
            this.rtxtTrescDWF = new System.Windows.Forms.RichTextBox();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.btnWyrwij = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxtTytulDWF
            // 
            this.rtxtTytulDWF.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.rtxtTytulDWF.Font = new System.Drawing.Font("Ink Free", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.rtxtTytulDWF.Location = new System.Drawing.Point(12, 12);
            this.rtxtTytulDWF.Name = "rtxtTytulDWF";
            this.rtxtTytulDWF.Size = new System.Drawing.Size(561, 119);
            this.rtxtTytulDWF.TabIndex = 0;
            this.rtxtTytulDWF.Text = "Tu wpisz tytuł";
            // 
            // rtxtTrescDWF
            // 
            this.rtxtTrescDWF.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.rtxtTrescDWF.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtxtTrescDWF.Location = new System.Drawing.Point(13, 137);
            this.rtxtTrescDWF.Name = "rtxtTrescDWF";
            this.rtxtTrescDWF.Size = new System.Drawing.Size(560, 498);
            this.rtxtTrescDWF.TabIndex = 1;
            this.rtxtTrescDWF.Text = "Tu wpisz zawartość";
            // 
            // btnZapisz
            // 
            this.btnZapisz.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnZapisz.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold);
            this.btnZapisz.Location = new System.Drawing.Point(300, 641);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(273, 60);
            this.btnZapisz.TabIndex = 2;
            this.btnZapisz.Text = "zapisz";
            this.btnZapisz.UseVisualStyleBackColor = false;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // btnWyrwij
            // 
            this.btnWyrwij.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnWyrwij.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold);
            this.btnWyrwij.Location = new System.Drawing.Point(13, 641);
            this.btnWyrwij.Name = "btnWyrwij";
            this.btnWyrwij.Size = new System.Drawing.Size(281, 60);
            this.btnWyrwij.TabIndex = 3;
            this.btnWyrwij.Text = "zrezygnuj";
            this.btnWyrwij.UseVisualStyleBackColor = false;
            this.btnWyrwij.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // DopiszWierszForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(585, 713);
            this.Controls.Add(this.btnWyrwij);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.rtxtTrescDWF);
            this.Controls.Add(this.rtxtTytulDWF);
            this.Name = "DopiszWierszForm";
            this.ShowIcon = false;
            this.Text = "Dopisz nowy wiersz";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtTytulDWF;
        private System.Windows.Forms.RichTextBox rtxtTrescDWF;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Button btnWyrwij;
    }
}