using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kontrolka1
{
    // SIDE BAR
    public partial class Bilans_słupek : UserControl
    {
        private int szerokosc = 30;
        private float value;
        private float maxvalue ;
        private float minvalue = 0;
        private int padding = 4;

        private Color kolor_slupka;
        private Color kolor_tla;

        [Category("Apperance")]
        public Color Kolor_slupka
        {
            get { return kolor_slupka; }
            set { kolor_slupka = value; Invalidate(); }
        }
        [Category("Apperance")]
        public Color Kolor_tla
        {
            get { return kolor_tla; }
            set { kolor_tla = value; Invalidate(); }
        }
        [Category("Behavior")]
        public float Value
        {
            get { return value; }
            set { this.value = value; Invalidate(); }
        }
        [Category("Behavior")]
        public float MaxValue
        {
            get { return maxvalue; }
            set { maxvalue = value; Invalidate(); }
        }
        [Category("Behavior")]
        public float MinValue
        {
            get { return minvalue; }
            set { minvalue = value; Invalidate(); }
        }
        [Category("Layout")]
        public int Szerokosc
        {
            get { return szerokosc; }
            set { szerokosc = value; Invalidate(); }
        }
        [Category("Layout")]
        public int Padding
        {
            get { return padding; }
            set { padding = value; Invalidate(); }
        }
        public Bilans_słupek()
        {
            InitializeComponent();
            maxvalue = value;
        }

        public override string Text {
            get => base.Text;
        set { base.Text = value ; Invalidate(); }
 }
        protected override void OnPaint(PaintEventArgs e)
        {
            Rysowanie(e.Graphics);
            base.OnPaint(e);
        }

        protected virtual void Rysowanie(Graphics graphics)
        {
            Point poczatek = new Point(Width/2,Height);
            Point koniec = new Point(Width/2,0);


            



            
            Pen foreground, background;

            float scale = Height/maxvalue;

            float wysokosc_napisu = graphics.MeasureString(value.ToString(), Font).Height;

            background = new Pen(Brushes.White, szerokosc);
            foreground = new Pen(Brushes.Green, background.Width-padding);

            foreground.Color = kolor_slupka;
            background.Color = kolor_tla;

            
            
            //Tło
            graphics.DrawLine(background, poczatek, koniec);
            //Stan_konta
            graphics.DrawLine(foreground, poczatek.X, poczatek.Y, koniec.X, poczatek.Y-(value*scale));

            if ( wysokosc_napisu >  (value * scale))
            {
                graphics.DrawString(value.ToString(), Font, new SolidBrush(Color.Red), koniec.X - (szerokosc / 2), poczatek.Y -wysokosc_napisu);
            }

            else if((value*scale) > Height){

                graphics.DrawString(value.ToString(), Font, new SolidBrush(Color.Red), koniec.X - (szerokosc / 2), 0);

            }
            else
            {
                graphics.DrawString(value.ToString(), Font, new SolidBrush(Color.Red), koniec.X - (szerokosc / 2), poczatek.Y - (value * scale));


            }



        }
        public void Max(decimal hajs)
        {
            maxvalue= (float)hajs;
            value = (float)hajs;
            minvalue = 0;
        }
    }
}
