using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Windows.Forms;
using Projekt_2.Server_Service;

namespace Projekt_2
{
    public partial class Form1 : Form
    {
        Server_Service.Service1Client game = new Service1Client();
        Player[] players = new Player[0];

        public string token;
        private decimal kaska;
        public decimal Kaska
        {
            get { return kaska; }
            set { kaska = value; }
        }


        public Form1()
        {

            InitializeComponent();


        }



        private void RuletkaZdjecie_Click(object sender, EventArgs e)
        {
            try
            {
                form_ruletka ruletka = new form_ruletka();
                ruletka.Kasa = stan_konta.Value;
                ruletka.przesyl += przesylanie;


                ruletka.ShowDialog();
            }
            catch
            {
                System.Environment.Exit(1);
            }
        }

        private void SlotZdjecie_Click(object sender, EventArgs e)
        {
            try
            {


                form_slot slot = new form_slot();
                slot.Kasa = stan_konta.Value;
                slot.przesyl2 += przesylanie;

                slot.ShowDialog();
            }
            catch
            {
               System.Environment.Exit(1);
            }

        }




        private void przesylanie(decimal wartosc)
        {
            if (wartosc <= 0)
            {
                stan_konta.Value = 0;
                bankrut bankrut = new bankrut();
                bankrut.Pseudonim = pseudo_wpis.Text;
                if (bankrut.ShowDialog() == DialogResult.OK)
                {

                    System.Environment.Exit(1);


                }

            }
            else { stan_konta.Value = wartosc; }
        }



        private void pseudo_wpis_Enter(object sender, EventArgs e)
        {
            wplata.Visible = true;
            wplata_podaj.Visible = true;
        }


        private void login_button_Click(object sender, EventArgs e)
        {
            


        token = game.Login(pseudo_wpis.Text, haslo_wpis.Text);


            if (token != string.Empty)
            {



                if (token == "BAN")
                {
                    bankrut bankrut = new bankrut();
                    bankrut.Pseudonim = pseudo_wpis.Text;
                    bankrut.text = "JESTEŚ ZBANOWANY";
                    if (bankrut.ShowDialog() == DialogResult.OK)
                    {

                        System.Environment.Exit(1);


                    }



                }
                else
                {
                    Player player = new Player();
                    player = game.GetPlayer(pseudo_wpis.Text);
                    stan_konta.Value = player.Cash;

                    // Formularz
                    stan_konta.Visible = true;
                    RuletkaZdjecie.Visible = true;
                    PokerZdjecie.Visible = true;
                    SlotZdjecie.Visible = true;
                    deposit_button.Visible = false;
                    label1.Text = "Witaj " + pseudo_wpis.Text;
                    label1.Visible = true;
                    Home.Visible = true;
                    bilans_słupek2.Visible = true;
                    bilans_słupek2.MaxValue = (float)stan_konta.Value;
                    bilans_słupek2.Value = (float)stan_konta.Value;
                    wplata_podaj.Visible = false;
                    wplata.Visible = false;
                    podaj_pseudo.Visible = false;
                    pseudo_wpis.Visible = false;
                    login_button.Visible = false;
                    label2.Visible = false;
                    haslo_wpis.Visible = false;
                }
                    
            }
            else {
                pseudo_wpis.Clear();
                haslo_wpis.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stan_konta.Value = wplata_podaj.Value;
            stan_konta.Visible = true;
            wplata.Visible = false;
            wplata_podaj.Visible = false;
            RuletkaZdjecie.Visible = true;
            PokerZdjecie.Visible = true;
            SlotZdjecie.Visible = true;
            deposit_button.Visible = false;
            label1.Text = "Witaj " + pseudo_wpis.Text;
            label1.Visible = true;
            Home.Visible = true;
            bilans_słupek2.Visible = true;
            bilans_słupek2.MaxValue = (float)stan_konta.Value;
            bilans_słupek2.Value = (float)stan_konta.Value;




        }

        private void wplata_podaj_ValueChanged(object sender, EventArgs e)
        {
            deposit_button.Visible = false;
        }

        private void stan_konta_ValueChanged(object sender, EventArgs e)
        {
            if (stan_konta.Value <= 0)
            {

                bankrut bankrut = new bankrut();
                bankrut.Pseudonim = pseudo_wpis.Text;


                if (bankrut.ShowDialog() == DialogResult.OK)
                {

                    System.Environment.Exit(1);

                }

            }
            
            bilans_słupek2.Value = (float)stan_konta.Value;


            game.Update_Money(token, stan_konta.Value);
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                players = game.GetPlayers();
            }
            catch 
            {
                System.Environment.Exit(1);
            }
        }



        private void PokerZdjecie_Click(object sender, EventArgs e)
        {

            try
            {


                Nowa_gra gierka = new Nowa_gra();
                gierka.Kaska = stan_konta.Value;
                gierka.przesyl3 += przesylanie;

                gierka.ShowDialog();
            }
            catch
            {
                System.Environment.Exit(1);
            }
        }



        private void Home_Click(object sender, EventArgs e)
        {
            
            Close();
              
                
            
        }
    }
}


