using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kontrolka1
{
    public enum Orientacja
    {
        SuwakLewo, SuwakPrawo
    }

    // FOR FUTURE APPENDIXES
    public partial class Panel_boczny : UserControl
    {

        private Orientacja orientacja;

        public Panel_boczny()
        {
            InitializeComponent();
            this.MinimumSize = new Size(tytul.Width + suwak.Width + (szerokosc_przyciskow()), wysokosc_przyciskow());
            

        }

        private int suwak_max_szerokosc()
        {
            int max = 0;

            if((przycisk_graj.Left + przycisk_graj.Width) >= (przycisk_ok.Left + przycisk_ok.Width))
            {
                max = przycisk_graj.Left + przycisk_graj.Width;
            }
            else
            {
                max = przycisk_ok.Left + przycisk_ok.Width;
            }

            return this.Width - max;


           
        }
        [Category("Side_Panel")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public decimal Stawka
        {
            get
            {
                return stawka_podaj.Value;
            }
            set
            {
                stawka_podaj.Value = value;
            }
        }
        [Category("Side_Panel")]
        public string Tytul
        {
            get
            {
                return tytul.Text;
            }
            set
            {
                tytul.Text = value;
            }
        }

        [Category("Side_Panel")]
        public string Przycisk1_tekst
        {

            get
            {

                return przycisk_graj.Text;
            }
            set
            {
                przycisk_graj.Text = value;
            }

        }
        [Category("Side_Panel")]
        public string Przycisk2_tekst
        {

            get
            {

                return przycisk_ok.Text;
            }
            set
            {
                przycisk_ok.Text = value;
            }
        }
        public void Max(decimal hajs)
        {
            stawka_podaj.Maximum = hajs;
            suwak.Maximum = (int)hajs;
        }

       
        private int szerokosc_przyciskow()
        {
            
            if (przycisk_graj.Left == przycisk_ok.Left)
            {
                if (przycisk_graj.Width >= przycisk_ok.Width)
                {
                    return przycisk_graj.Width;
                }
                else
                {
                    return przycisk_ok.Width;
                }
            }
            else if(przycisk_graj.Left< przycisk_ok.Left)
            {
                
                    return przycisk_ok.Left - przycisk_graj.Left + przycisk_ok.Width;
                
            }
            else
            {
                return przycisk_graj.Left - przycisk_ok.Left + przycisk_graj.Width;
            }
            
        }
        private int wysokosc_przyciskow()
        {
            return Height -przycisk_graj.Location.Y + tytul.Height+ tytul.Left + tytul.Top;
        }



        private void suwak_Scroll(object sender, ScrollEventArgs e)
        {
            stawka_podaj.Value = suwak.Value;
        }

        private void Panel_boczny_Load(object sender, EventArgs e)
        {
            Size max_szer = new Size();
            max_szer.Width = suwak_max_szerokosc();
            max_szer.Height = Height;
            suwak.MaximumSize = max_szer;

        }
        [Category("Side_Panel")]
        public Orientacja Suwak_dock
        {

            get { return orientacja; }
            set
            {
                orientacja = value;
                switch (orientacja)
                {
                    case Orientacja.SuwakLewo:

                        suwak.Dock = DockStyle.Left;
                        tytul.Left = Width - tytul.Width - 5;
                        tytul.Anchor = (AnchorStyles.Top | AnchorStyles.Right);

                        break;

                    case Orientacja.SuwakPrawo:

                        suwak.Dock = DockStyle.Right;
                        tytul.Left = 5;
                        tytul.Anchor = (AnchorStyles.Left | AnchorStyles.Top);
                        break;


                    default: break;

                }
            }
        }
        [Category("Side_Panel")]
        public int suwak_szerokosc
        {
            get
            {
                return suwak.Width;
            }
            set
            {
                suwak.Width = value;
            }



        }

        private void suwak_Resize(object sender, EventArgs e)
        {
            if(suwak.Width > suwak_max_szerokosc())
            {
                
            }
        }

        private void przycisk_graj_Resize(object sender, EventArgs e)
        {
            
        }
    }
}
 