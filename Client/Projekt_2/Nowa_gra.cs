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
    public partial class Nowa_gra : Form
    {
        private decimal kaska;
        public decimal Kaska
        {
            get { return kaska; }
            set { kaska = value; }
        }
        public Nowa_gra()
        {
            InitializeComponent();
        }

        

        public delegate void delegat3(decimal kasa);
        public event delegat3 przesyl3;

        private void Nowa_gra_Load(object sender, EventArgs e)
        {

            
        }
    }
}
