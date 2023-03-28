
namespace Projekt_2
{
    partial class form_ruletka
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.zagraj = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.stawka_wpis = new System.Windows.Forms.NumericUpDown();
            this.Liczby = new System.Windows.Forms.ComboBox();
            this.Kolory = new System.Windows.Forms.ComboBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.stawka_napis = new System.Windows.Forms.Label();
            this.zdjecie_ruletki = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stawka_wpis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zdjecie_ruletki)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.zagraj);
            this.panel1.Controls.Add(this.ok);
            this.panel1.Controls.Add(this.stawka_wpis);
            this.panel1.Controls.Add(this.Liczby);
            this.panel1.Controls.Add(this.Kolory);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.stawka_napis);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 494);
            this.panel1.TabIndex = 0;
            // 
            // zagraj
            // 
            this.zagraj.Location = new System.Drawing.Point(116, 438);
            this.zagraj.Name = "zagraj";
            this.zagraj.Size = new System.Drawing.Size(75, 23);
            this.zagraj.TabIndex = 13;
            this.zagraj.Text = "Zagraj";
            this.zagraj.UseVisualStyleBackColor = true;
            this.zagraj.Visible = false;
            this.zagraj.Click += new System.EventHandler(this.zagraj_Click);
            // 
            // ok
            // 
            this.ok.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ok.Location = new System.Drawing.Point(26, 438);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 12;
            this.ok.Text = "ok";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Visible = false;
            // 
            // stawka_wpis
            // 
            this.stawka_wpis.Location = new System.Drawing.Point(35, 87);
            this.stawka_wpis.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.stawka_wpis.Name = "stawka_wpis";
            this.stawka_wpis.Size = new System.Drawing.Size(120, 20);
            this.stawka_wpis.TabIndex = 11;
            this.stawka_wpis.ValueChanged += new System.EventHandler(this.stawka_wpis_ValueChanged);
            // 
            // Liczby
            // 
            this.Liczby.FormattingEnabled = true;
            this.Liczby.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.Liczby.Location = new System.Drawing.Point(34, 284);
            this.Liczby.Name = "Liczby";
            this.Liczby.Size = new System.Drawing.Size(121, 21);
            this.Liczby.TabIndex = 9;
            this.Liczby.Visible = false;
            this.Liczby.SelectedIndexChanged += new System.EventHandler(this.Liczby_SelectedIndexChanged);
            // 
            // Kolory
            // 
            this.Kolory.FormattingEnabled = true;
            this.Kolory.Items.AddRange(new object[] {
            "B",
            "R"});
            this.Kolory.Location = new System.Drawing.Point(34, 369);
            this.Kolory.Name = "Kolory";
            this.Kolory.Size = new System.Drawing.Size(121, 21);
            this.Kolory.TabIndex = 8;
            this.Kolory.Visible = false;
            this.Kolory.SelectedValueChanged += new System.EventHandler(this.Kolory_SelectedValueChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(51, 239);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(56, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Liczbe";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Visible = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(51, 203);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(49, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Kolor";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Visible = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(18, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Na co stawiasz?";
            // 
            // stawka_napis
            // 
            this.stawka_napis.AutoSize = true;
            this.stawka_napis.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stawka_napis.Location = new System.Drawing.Point(12, 34);
            this.stawka_napis.Name = "stawka_napis";
            this.stawka_napis.Size = new System.Drawing.Size(89, 28);
            this.stawka_napis.TabIndex = 0;
            this.stawka_napis.Text = "Stawka";
            // 
            // zdjecie_ruletki
            // 
            this.zdjecie_ruletki.Image = global::Projekt_2.Properties.Resources.too1;
            this.zdjecie_ruletki.Location = new System.Drawing.Point(197, 0);
            this.zdjecie_ruletki.Name = "zdjecie_ruletki";
            this.zdjecie_ruletki.Size = new System.Drawing.Size(579, 497);
            this.zdjecie_ruletki.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zdjecie_ruletki.TabIndex = 1;
            this.zdjecie_ruletki.TabStop = false;
            this.zdjecie_ruletki.Tag = "";
            this.zdjecie_ruletki.Paint += new System.Windows.Forms.PaintEventHandler(this.zdjecie_ruletki_Paint);
            // 
            // form_ruletka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 494);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.zdjecie_ruletki);
            this.Name = "form_ruletka";
            this.Text = "form_ruletka";
            this.Load += new System.EventHandler(this.form_ruletka_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stawka_wpis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zdjecie_ruletki)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label stawka_napis;
        private System.Windows.Forms.PictureBox zdjecie_ruletki;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Kolory;
        private System.Windows.Forms.ComboBox Liczby;
        private System.Windows.Forms.NumericUpDown stawka_wpis;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button zagraj;
    }
}