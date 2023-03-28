
namespace Projekt_2
{
    partial class Form1
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Stan_konta_Napis = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RuletkaZdjecie = new System.Windows.Forms.PictureBox();
            this.PokerZdjecie = new System.Windows.Forms.PictureBox();
            this.SlotZdjecie = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.stan_konta = new System.Windows.Forms.NumericUpDown();
            this.Home = new System.Windows.Forms.PictureBox();
            this.pseudo_wpis = new System.Windows.Forms.TextBox();
            this.podaj_pseudo = new System.Windows.Forms.Label();
            this.wplata = new System.Windows.Forms.Label();
            this.wplata_podaj = new System.Windows.Forms.NumericUpDown();
            this.login_button = new System.Windows.Forms.Button();
            this.deposit_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bilans_słupek2 = new Kontrolka1.Bilans_słupek();
            this.haslo_wpis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RuletkaZdjecie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PokerZdjecie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SlotZdjecie)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stan_konta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wplata_podaj)).BeginInit();
            this.SuspendLayout();
            // 
            // Stan_konta_Napis
            // 
            this.Stan_konta_Napis.AutoSize = true;
            this.Stan_konta_Napis.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Stan_konta_Napis.Location = new System.Drawing.Point(115, 21);
            this.Stan_konta_Napis.Name = "Stan_konta_Napis";
            this.Stan_konta_Napis.Size = new System.Drawing.Size(214, 46);
            this.Stan_konta_Napis.TabIndex = 5;
            this.Stan_konta_Napis.Text = "Stan Konta";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.RuletkaZdjecie);
            this.panel1.Controls.Add(this.PokerZdjecie);
            this.panel1.Controls.Add(this.SlotZdjecie);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 555);
            this.panel1.TabIndex = 6;
            // 
            // RuletkaZdjecie
            // 
            this.RuletkaZdjecie.Image = global::Projekt_2.Properties.Resources.zdjecie_ruletki;
            this.RuletkaZdjecie.Location = new System.Drawing.Point(0, 12);
            this.RuletkaZdjecie.Name = "RuletkaZdjecie";
            this.RuletkaZdjecie.Size = new System.Drawing.Size(200, 171);
            this.RuletkaZdjecie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RuletkaZdjecie.TabIndex = 2;
            this.RuletkaZdjecie.TabStop = false;
            this.RuletkaZdjecie.Visible = false;
            this.RuletkaZdjecie.Click += new System.EventHandler(this.RuletkaZdjecie_Click);
            // 
            // PokerZdjecie
            // 
            this.PokerZdjecie.Image = global::Projekt_2.Properties.Resources.output_onlinepngtools__5_;
            this.PokerZdjecie.Location = new System.Drawing.Point(0, 189);
            this.PokerZdjecie.Name = "PokerZdjecie";
            this.PokerZdjecie.Size = new System.Drawing.Size(200, 183);
            this.PokerZdjecie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PokerZdjecie.TabIndex = 3;
            this.PokerZdjecie.TabStop = false;
            this.PokerZdjecie.Visible = false;
            // 
            // SlotZdjecie
            // 
            this.SlotZdjecie.Image = global::Projekt_2.Properties.Resources.PngItem_3698340;
            this.SlotZdjecie.Location = new System.Drawing.Point(0, 378);
            this.SlotZdjecie.Name = "SlotZdjecie";
            this.SlotZdjecie.Size = new System.Drawing.Size(200, 166);
            this.SlotZdjecie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SlotZdjecie.TabIndex = 4;
            this.SlotZdjecie.TabStop = false;
            this.SlotZdjecie.Visible = false;
            this.SlotZdjecie.Click += new System.EventHandler(this.SlotZdjecie_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.stan_konta);
            this.panel2.Controls.Add(this.Home);
            this.panel2.Controls.Add(this.Stan_konta_Napis);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(730, 84);
            this.panel2.TabIndex = 7;
            // 
            // stan_konta
            // 
            this.stan_konta.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.stan_konta.Location = new System.Drawing.Point(426, 40);
            this.stan_konta.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.stan_konta.Name = "stan_konta";
            this.stan_konta.ReadOnly = true;
            this.stan_konta.Size = new System.Drawing.Size(120, 20);
            this.stan_konta.TabIndex = 9;
            this.stan_konta.Value = new decimal(new int[] {
            666,
            0,
            0,
            0});
            this.stan_konta.Visible = false;
            this.stan_konta.ValueChanged += new System.EventHandler(this.stan_konta_ValueChanged);
            // 
            // Home
            // 
            this.Home.Dock = System.Windows.Forms.DockStyle.Right;
            this.Home.Image = global::Projekt_2.Properties.Resources._588a6758d06f6719692a2d22;
            this.Home.Location = new System.Drawing.Point(643, 0);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(87, 84);
            this.Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Home.TabIndex = 8;
            this.Home.TabStop = false;
            this.Home.Visible = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // pseudo_wpis
            // 
            this.pseudo_wpis.Location = new System.Drawing.Point(626, 250);
            this.pseudo_wpis.MaxLength = 32;
            this.pseudo_wpis.Name = "pseudo_wpis";
            this.pseudo_wpis.Size = new System.Drawing.Size(189, 20);
            this.pseudo_wpis.TabIndex = 8;
            // 
            // podaj_pseudo
            // 
            this.podaj_pseudo.AutoSize = true;
            this.podaj_pseudo.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.podaj_pseudo.Location = new System.Drawing.Point(297, 239);
            this.podaj_pseudo.Name = "podaj_pseudo";
            this.podaj_pseudo.Size = new System.Drawing.Size(289, 31);
            this.podaj_pseudo.TabIndex = 9;
            this.podaj_pseudo.Text = "Podaj swoj pseudonim";
            // 
            // wplata
            // 
            this.wplata.AutoSize = true;
            this.wplata.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wplata.Location = new System.Drawing.Point(297, 341);
            this.wplata.Name = "wplata";
            this.wplata.Size = new System.Drawing.Size(234, 31);
            this.wplata.TabIndex = 10;
            this.wplata.Text = "Ile chcesz wplacic?";
            this.wplata.Visible = false;
            // 
            // wplata_podaj
            // 
            this.wplata_podaj.Location = new System.Drawing.Point(626, 353);
            this.wplata_podaj.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.wplata_podaj.Name = "wplata_podaj";
            this.wplata_podaj.Size = new System.Drawing.Size(120, 20);
            this.wplata_podaj.TabIndex = 10;
            this.wplata_podaj.Visible = false;
            this.wplata_podaj.ValueChanged += new System.EventHandler(this.wplata_podaj_ValueChanged);
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(843, 250);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(40, 23);
            this.login_button.TabIndex = 11;
            this.login_button.Text = "OK";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // deposit_button
            // 
            this.deposit_button.Location = new System.Drawing.Point(829, 353);
            this.deposit_button.Name = "deposit_button";
            this.deposit_button.Size = new System.Drawing.Size(40, 23);
            this.deposit_button.TabIndex = 12;
            this.deposit_button.Text = "OK";
            this.deposit_button.UseVisualStyleBackColor = true;
            this.deposit_button.Visible = false;
            this.deposit_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(437, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 36);
            this.label1.TabIndex = 13;
            this.label1.Text = "Witaj";
            this.label1.Visible = false;
            // 
            // bilans_słupek2
            // 
            this.bilans_słupek2.Font = new System.Drawing.Font("Ravie", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bilans_słupek2.Kolor_slupka = System.Drawing.Color.Green;
            this.bilans_słupek2.Kolor_tla = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bilans_słupek2.Location = new System.Drawing.Point(200, 147);
            this.bilans_słupek2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bilans_słupek2.MaxValue = 100F;
            this.bilans_słupek2.MinValue = 0F;
            this.bilans_słupek2.Name = "bilans_słupek2";
            this.bilans_słupek2.Size = new System.Drawing.Size(91, 370);
            this.bilans_słupek2.Szerokosc = 35;
            this.bilans_słupek2.TabIndex = 14;
            this.bilans_słupek2.Value = 50F;
            this.bilans_słupek2.Visible = false;
            // 
            // haslo_wpis
            // 
            this.haslo_wpis.Location = new System.Drawing.Point(626, 276);
            this.haslo_wpis.MaxLength = 32;
            this.haslo_wpis.Name = "haslo_wpis";
            this.haslo_wpis.Size = new System.Drawing.Size(189, 20);
            this.haslo_wpis.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(297, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 31);
            this.label2.TabIndex = 17;
            this.label2.Text = "Podaj haslo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(930, 555);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.haslo_wpis);
            this.Controls.Add(this.bilans_słupek2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deposit_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.wplata_podaj);
            this.Controls.Add(this.wplata);
            this.Controls.Add(this.podaj_pseudo);
            this.Controls.Add(this.pseudo_wpis);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RuletkaZdjecie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PokerZdjecie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SlotZdjecie)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stan_konta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wplata_podaj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox RuletkaZdjecie;
        private System.Windows.Forms.PictureBox PokerZdjecie;
        private System.Windows.Forms.PictureBox SlotZdjecie;
        private System.Windows.Forms.Label Stan_konta_Napis;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox Home;
        private System.Windows.Forms.NumericUpDown stan_konta;
        private System.Windows.Forms.TextBox pseudo_wpis;
        private System.Windows.Forms.Label podaj_pseudo;
        private System.Windows.Forms.Label wplata;
        private System.Windows.Forms.NumericUpDown wplata_podaj;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button deposit_button;
        private System.Windows.Forms.Label label1;
        private Kontrolka1.Bilans_słupek bilans_słupek1;
        private Kontrolka1.Bilans_słupek bilans_słupek2;
        private System.Windows.Forms.TextBox haslo_wpis;
        private System.Windows.Forms.Label label2;
    }
}

