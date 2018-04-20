using System;
using System.Windows.Forms;

namespace Unternehmen
{
    public partial class Menue_standart : Form
    {
        Verwaltung verwaltung;
        public Menue_standart(Verwaltung verwaltung)
        {
            this.verwaltung = verwaltung;
            InitializeComponent();
            StatusAbfrage();
            if (verwaltung.GetAngemeldetePerson().GetStatus() == "Anwesend")
                btnAnwesend.Enabled = false;
            else
                btnGehen.Enabled = false;
            numKrankentage.Value = verwaltung.GetAngemeldetePerson().GetKrankentage();
        }
        private void btnAnwesend_Click(object sender, EventArgs e)
        {
            btnGehen.Enabled = true;
            btnAnwesend.Enabled = false;
            verwaltung.GetAngemeldetePerson().Anwesend();
            StatusAbfrage();
        }

        private void btnGehen_Click(object sender, EventArgs e)
        {
            btnGehen.Enabled = false;
            btnAnwesend.Enabled = true;
            verwaltung.GetAngemeldetePerson().Gehen();
            StatusAbfrage();
        }
        private void StatusAbfrage()
        {
            lbStatus.Text = verwaltung.GetAngemeldetePerson().GetStatus();
        }

        private void btnZeiten_Click(object sender, EventArgs e)
        {
            MessageBox.Show(verwaltung.GetAngemeldetePerson().GetZeiten());
        }

        private void btnKrankentage_Click(object sender, EventArgs e)
        {
            verwaltung.GetAngemeldetePerson().SetKrankentage((int)numKrankentage.Value);
            StatusAbfrage();
            for (int f = 0; f < (int)numKrankentage.Value; f++)
                verwaltung.GetFirma().Uerberprufung(DateTime.Today.AddDays(f));
        }
    }
}
