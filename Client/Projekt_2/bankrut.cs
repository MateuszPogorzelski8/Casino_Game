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
    public partial class bankrut : Form
    {
        private string pseudonim;


        public string text="JESTEŚ BANKRUTEM ";
        public string Pseudonim
        {
            get { return pseudonim; }
            set { pseudonim = value; }
        }
        public bankrut()
        {
            InitializeComponent();
        }

        private void bankrut_Load(object sender, EventArgs e)
        {
            button1.Text = text + Pseudonim;
        }
    }
}
