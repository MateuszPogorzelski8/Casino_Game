namespace Kontrolka1
{
    partial class Panel_boczny
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.stawka_podaj = new System.Windows.Forms.NumericUpDown();
            this.tytul = new System.Windows.Forms.Label();
            this.przycisk_graj = new System.Windows.Forms.Button();
            this.suwak = new System.Windows.Forms.VScrollBar();
            this.przycisk_ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stawka_podaj)).BeginInit();
            this.SuspendLayout();
            // 
            // stawka_podaj
            // 
            this.stawka_podaj.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stawka_podaj.Location = new System.Drawing.Point(0, 391);
            this.stawka_podaj.Name = "stawka_podaj";
            this.stawka_podaj.Size = new System.Drawing.Size(316, 20);
            this.stawka_podaj.TabIndex = 1;
            // 
            // tytul
            // 
            this.tytul.AutoSize = true;
            this.tytul.Location = new System.Drawing.Point(5, 25);
            this.tytul.Name = "tytul";
            this.tytul.Size = new System.Drawing.Size(50, 13);
            this.tytul.TabIndex = 2;
            this.tytul.Text = "Tytul_gry";
            // 
            // przycisk_graj
            // 
            this.przycisk_graj.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.przycisk_graj.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.przycisk_graj.Location = new System.Drawing.Point(125, 133);
            this.przycisk_graj.Name = "przycisk_graj";
            this.przycisk_graj.Size = new System.Drawing.Size(75, 23);
            this.przycisk_graj.TabIndex = 3;
            this.przycisk_graj.Text = "button1";
            this.przycisk_graj.UseVisualStyleBackColor = true;
            this.przycisk_graj.Resize += new System.EventHandler(this.przycisk_graj_Resize);
            // 
            // suwak
            // 
            this.suwak.Dock = System.Windows.Forms.DockStyle.Right;
            this.suwak.Location = new System.Drawing.Point(280, 0);
            this.suwak.Name = "suwak";
            this.suwak.Size = new System.Drawing.Size(36, 391);
            this.suwak.TabIndex = 4;
            this.suwak.Scroll += new System.Windows.Forms.ScrollEventHandler(this.suwak_Scroll);
            this.suwak.Resize += new System.EventHandler(this.suwak_Resize);
            // 
            // przycisk_ok
            // 
            this.przycisk_ok.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.przycisk_ok.Location = new System.Drawing.Point(125, 245);
            this.przycisk_ok.Name = "przycisk_ok";
            this.przycisk_ok.Size = new System.Drawing.Size(75, 23);
            this.przycisk_ok.TabIndex = 5;
            this.przycisk_ok.Text = "button2";
            this.przycisk_ok.UseVisualStyleBackColor = true;
            // 
            // Panel_boczny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.przycisk_ok);
            this.Controls.Add(this.suwak);
            this.Controls.Add(this.przycisk_graj);
            this.Controls.Add(this.tytul);
            this.Controls.Add(this.stawka_podaj);
            this.MinimumSize = new System.Drawing.Size(150, 0);
            this.Name = "Panel_boczny";
            this.Size = new System.Drawing.Size(316, 411);
            this.Load += new System.EventHandler(this.Panel_boczny_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stawka_podaj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown stawka_podaj;
        private System.Windows.Forms.Label tytul;
        private System.Windows.Forms.Button przycisk_graj;
        private System.Windows.Forms.VScrollBar suwak;
        private System.Windows.Forms.Button przycisk_ok;
    }
}
