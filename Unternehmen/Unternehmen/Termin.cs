using System;
using System.Windows.Forms;

namespace Unternehmen
{
    public partial class Termin : Form
    {
        Verwaltung verwaltung;
        int index;
        public Termin(Verwaltung verwaltung,int index)
        {
            this.verwaltung = verwaltung;
            this.index = index;
            InitializeComponent();
            dTPVon.MinDate = dTpBis.MinDate = DateTime.Today;
            cBoxVonMin.SelectedIndex = cBoxBisMin.SelectedIndex = cBoxBisHour.SelectedIndex = cBoxVonHour.SelectedIndex = 0;
            if (index == -1) return;
            btnLoschen.Visible = true;
            //Eintragen
            DateTime von =verwaltung.GetAngemeldetePerson().GetTerminVon(index);
            DateTime bis = verwaltung.GetAngemeldetePerson().GetTerminBis(index);
            dTPVon.Value = von;
            dTpBis.Value = bis;
            txBBeschreibung.Text = verwaltung.GetAngemeldetePerson().GetTerminBeschreibung(index);
            cBoxVonHour.SelectedIndex = von.Hour;
            cBoxVonMin.SelectedIndex = von.Minute;
            cBoxBisHour.SelectedIndex = bis.Hour;
            cBoxBisMin.SelectedIndex = bis.Minute;
        }

        private void btnLoschen_Click(object sender, EventArgs e)
        {
            verwaltung.GetAngemeldetePerson().DeleteTermin(index);
            Close();
        }

        private void btnFestlegen_Click(object sender, EventArgs e)
        {
            DateTime von = dTPVon.Value, bis = dTpBis.Value;
                von = von.AddHours(cBoxVonHour.SelectedIndex).AddMinutes(cBoxVonMin.SelectedIndex);
                bis = bis.AddHours(cBoxBisHour.SelectedIndex).AddMinutes(cBoxBisMin.SelectedIndex);
            if (index == -1)
                verwaltung.GetAngemeldetePerson().SetTermin(von, bis, txBBeschreibung.Text);
            else
                verwaltung.GetAngemeldetePerson().SetTermin(von, bis, txBBeschreibung.Text, index);
            Close();
        }

        private void dTPVon_ValueChanged(object sender, EventArgs e)
        {
            dTpBis.MinDate = dTPVon.Value;
        }
    }
}
