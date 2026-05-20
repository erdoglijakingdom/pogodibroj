using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        private int tajniBroj;
        private int brojPokusaja;
        private Random rng = new Random();

        public Form1()
        {
            InitializeComponent();
            NovaIgra();
        }

        private void NovaIgra()
        {
            tajniBroj = rng.Next(1, 101);
            brojPokusaja = 0;
            lblRezultat.Text = "Rezultat";
            lblPokusaji.Text = "Broj pokušaja";
        }

        private void btnProveri_Click(object sender, EventArgs e)
        {
            int pogodak;
            if (!int.TryParse(txtBroj.Text, out pogodak) || pogodak < 1 || pogodak > 100)
            {
                lblRezultat.Text = "Unesite broj od 1 do 100!";
                return;
            }

            brojPokusaja++;
            lblPokusaji.Text = "Broj pokušaja: " + brojPokusaja;

            if (pogodak < tajniBroj)
            {
                lblRezultat.Text = "Premali broj!";
            }
            else if (pogodak > tajniBroj)
            {
                lblRezultat.Text = "Preveliki broj!";
            }
            else
            {
                lblRezultat.Text = "Tačno! Pogodio si za " + brojPokusaja + " pokušaja!";
                MessageBox.Show(
                    "Bravo! Pogodio si broj " + tajniBroj + " za " + brojPokusaja + " pokušaja!",
                    "Pobeda!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                NovaIgra();
            }

            txtBroj.Clear();
            txtBroj.Focus();
        }
    }
}