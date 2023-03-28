using System;
using System.Drawing;
using System.Windows.Forms;

namespace Projekt_2
{
    
    public partial class form_ruletka : Form
    {
        double t;

        private decimal kasa;
        public decimal Kasa
        {
            get { return kasa; }
            set { kasa = value; }
        }

        public form_ruletka()
        {
            InitializeComponent();

        }
        private void form_ruletka_Load(object sender, EventArgs e)
        {
            stawka_wpis.Maximum = Kasa;
        }
       
        

        private void zdjecie_ruletki_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TranslateTransform(279, 240);
            e.Graphics.RotateTransform((float)t) ;
            e.Graphics.FillRectangle(Brushes.Green, 0, 0, 20, 120);

        }



        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Kolory.Visible = true;
            Liczby.Visible = false;
        }



        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Liczby.Visible = true;
            Kolory.Visible = false;
        }



        private void Kolory_SelectedValueChanged(object sender, EventArgs e)
        {
            zagraj.Visible = true;
        }

        private void Liczby_SelectedIndexChanged(object sender, EventArgs e)
        {
            zagraj.Visible = true;


        }

      


        private void zagraj_Click(object sender, EventArgs e)
        {


            

            Ruletka_klasyczna gram1 = new Ruletka_klasyczna();
            int[] liczby = gram1.Dane_gry_liczby();


            Ruletka_obliczenia a = new Ruletka_obliczenia();
            int wylosowana_liczba = a.Obliczenia(liczby.Length);

            Wzkaznik w = new Wzkaznik();
            t = w.wskaznik(wylosowana_liczba);

            decimal wynik;

            if (radioButton1.Checked)
            {
                Ruletka_klasyczna gram = new Ruletka_klasyczna();
                string[] kolory = gram.Dane_gry_kolory();

                

                Ruletka_obliczenia b = new Ruletka_obliczenia();
                string wylosowany_kolor = b.Obliczenia_kolory(kolory, wylosowana_liczba);

                int liczba_kolorow = b.Kolory_prawdopodobienstwo(kolory);

                Ruletka_gra c = new Ruletka_gra();
                wynik = c.kolor_gra(wylosowany_kolor, stawka_wpis.Value, Kolory.Text, liczba_kolorow);

                

                Kasa += wynik;

            }


            if (radioButton2.Checked)
            {
                

                Ruletka_gra d = new Ruletka_gra();
                wynik= d.liczba_gra(wylosowana_liczba, stawka_wpis.Value, Liczby.SelectedIndex, liczby.Length) ;
                Kasa += wynik;

            }
            
            this.Refresh();
            przesyl?.Invoke(Kasa);
            zagraj.Visible = false;
            ok.Visible = true;

        }
        





        public delegate void delegat(decimal kasa);

        public event delegat przesyl;


        private void stawka_wpis_Enter(object sender, EventArgs e)
        {
            
        }

        private void stawka_wpis_ValueChanged(object sender, EventArgs e)
        {
            if (stawka_wpis.Value > 0 && stawka_wpis.Value <= Kasa)
            {
                radioButton1.Visible = true;
                radioButton2.Visible = true;
            }
        }
    }
}
