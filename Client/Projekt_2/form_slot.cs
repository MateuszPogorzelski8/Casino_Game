using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_2
{
    public partial class form_slot : Form
    {
        

        private decimal kasa;
        public decimal Kasa
        {
            get { return kasa; }
            set { kasa = value; }
        }
        public form_slot()
        {
            InitializeComponent();
        }

       




        private void button2_Click(object sender, EventArgs e)
        {

            Automat_Obliczenia a = new Automat_Obliczenia();
            int[] numery=a.Automat_Obliczenia_exe();

            Symbole_automat b = new Symbole_automat();
            string[] symbole = b.Obrazki(numery);

  
            Automat_gra c = new Automat_gra();
            decimal wynik = c.Wygrana(numery,stawka.Value);

            Kasa += wynik;
            // Picture boxy ktorych używamy
            List<PictureBox> pictureboxarray = new List<PictureBox>();
            pictureboxarray.Add(pictureBox1);
            pictureboxarray.Add(pictureBox2);
            pictureboxarray.Add(pictureBox3);
            

            for(int i=0; i < pictureboxarray.Count; i++)
            {
                pictureboxarray[i].Image = Image.FromFile(symbole[i]);
            }

            automat_baner d = new automat_baner();
            baner.Text = d.Baner(numery);

            baner.Visible = true;
            przesyl2?.Invoke(Kasa);
            button1.Visible = true;
            button2.Visible = false;
        }




        public delegate void delegat2(decimal kasa);
        public event delegat2 przesyl2;

        private void stawka_ValueChanged(object sender, EventArgs e)
        {
            if (stawka.Value > 0 && stawka.Value <= Kasa)
            {
                button2.Visible = true;
            }
            else { }

        }

        private void form_slot_Load(object sender, EventArgs e)
        {
            stawka.Maximum = Kasa;
            
            
        }

       
    }
}
