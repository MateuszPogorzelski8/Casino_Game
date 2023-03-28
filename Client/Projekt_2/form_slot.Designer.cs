
namespace Projekt_2
{
    partial class form_slot
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
            this.components = new System.ComponentModel.Container();
            this.button2 = new System.Windows.Forms.Button();
            this.stawka = new System.Windows.Forms.NumericUpDown();
            this.stawka_napis = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.maszyna = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.baner = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stawka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maszyna)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(67, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Zagraj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // stawka
            // 
            this.stawka.Location = new System.Drawing.Point(47, 112);
            this.stawka.Name = "stawka";
            this.stawka.Size = new System.Drawing.Size(120, 20);
            this.stawka.TabIndex = 8;
            this.stawka.ValueChanged += new System.EventHandler(this.stawka_ValueChanged);
            // 
            // stawka_napis
            // 
            this.stawka_napis.AutoSize = true;
            this.stawka_napis.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stawka_napis.Location = new System.Drawing.Point(39, 38);
            this.stawka_napis.Name = "stawka_napis";
            this.stawka_napis.Size = new System.Drawing.Size(157, 46);
            this.stawka_napis.TabIndex = 9;
            this.stawka_napis.Text = "Stawka:";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(67, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Projekt_2.Properties.Resources.symbol1;
            this.pictureBox3.Location = new System.Drawing.Point(435, 192);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(55, 105);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projekt_2.Properties.Resources.symbol2;
            this.pictureBox1.Location = new System.Drawing.Point(515, 192);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Projekt_2.Properties.Resources.symbol3;
            this.pictureBox2.Location = new System.Drawing.Point(594, 192);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 105);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // maszyna
            // 
            this.maszyna.Dock = System.Windows.Forms.DockStyle.Right;
            this.maszyna.Image = global::Projekt_2.Properties.Resources.slot;
            this.maszyna.Location = new System.Drawing.Point(321, 0);
            this.maszyna.Name = "maszyna";
            this.maszyna.Size = new System.Drawing.Size(522, 509);
            this.maszyna.TabIndex = 0;
            this.maszyna.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            // 
            // baner
            // 
            this.baner.AutoSize = true;
            this.baner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(90)))));
            this.baner.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.baner.Location = new System.Drawing.Point(477, 34);
            this.baner.Name = "baner";
            this.baner.Size = new System.Drawing.Size(135, 50);
            this.baner.TabIndex = 7;
            this.baner.Text = "label1";
            this.baner.Visible = false;
            // 
            // form_slot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(843, 509);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.stawka_napis);
            this.Controls.Add(this.stawka);
            this.Controls.Add(this.baner);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.maszyna);
            this.Name = "form_slot";
            this.Text = "slot";
            this.Load += new System.EventHandler(this.form_slot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stawka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maszyna)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox maszyna;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown stawka;
        private System.Windows.Forms.Label stawka_napis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label baner;
    }
}