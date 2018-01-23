using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulačky
{
    public partial class Kalkulacky : Form
    {
        public Kalkulacky()
        {
            InitializeComponent();
        }

        private void benzinBTN_Click(object sender, EventArgs e)
        {

            // příprava proměnných

            double vzdalenost = Convert.ToDouble(vzdalenostNUD.Value);
            double spotreba = Convert.ToDouble(spotrebaNUD.Value);
            double cena = Convert.ToDouble(cenaNUD.Value);
            double vysledek = 0;

            // výpočet

            vysledek = vzdalenost * (spotreba / 100) * cena;

            // výpis

            benzinVysledekLBL.Text = vysledek.ToString() + " Kč";
            


        }

        private void energieBTN_Click(object sender, EventArgs e)
        {

            // příprava proměnných

            double prikon = Convert.ToDouble(prikonNUD.Value);
            double doba = Convert.ToDouble(dobaNUD.Value);
            double cenaEN = Convert.ToDouble(cenaKwhNUD.Value);

            double vysledekHned = 0;
            double vysledekMesic = 0;
            double vysledekRok = 0;

            // výpočet

            vysledekHned = (prikon / 1000) * doba * cenaEN;
            vysledekMesic = vysledekHned * 31;
            vysledekRok = vysledekHned * 365;

            // výpis

            energieVysledekHnedLBL.Text = vysledekHned.ToString() + " Kč/den";
            energieVysledekMesicLBL.Text = vysledekMesic.ToString() + " Kč/mm";
            energieVysledekRokLBL.Text = vysledekRok.ToString() + " Kč/rok";




        }
    }
}
