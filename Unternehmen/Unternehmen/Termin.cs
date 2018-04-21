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
            if (index == -1) return;
            btnLoschen.Visible = true;
            //Eintragen
            DateTime von = new DateTime(verwaltung.GetAngemeldetePerson().GetTerminVon(index).Year, verwaltung.GetAngemeldetePerson().GetTerminVon(index).Month, verwaltung.GetAngemeldetePerson().GetTerminVon(index).Day);
            DateTime bis = new DateTime(verwaltung.GetAngemeldetePerson().GetTerminBis(index).Year, verwaltung.GetAngemeldetePerson().GetTerminBis(index).Month, verwaltung.GetAngemeldetePerson().GetTerminBis(index).Day);
            dTPVon.Value = von;
            dTpBis.Value = bis;
            txBBeschreibung.Text = verwaltung.GetAngemeldetePerson().GetTerminBeschreibung(index);
            txBUhrzeitVon.Text = verwaltung.GetAngemeldetePerson().GetTerminVon(index).Hour + ":" + verwaltung.GetAngemeldetePerson().GetTerminVon(index).Minute;
            txBUhrzeitBis.Text = verwaltung.GetAngemeldetePerson().GetTerminBis(index).Hour + ":" + verwaltung.GetAngemeldetePerson().GetTerminBis(index).Minute;
        }

        private void btnLoschen_Click(object sender, EventArgs e)
        {
            verwaltung.GetAngemeldetePerson().DeleteTermin(index);
            Close();
        }

        private void btnFestlegen_Click(object sender, EventArgs e)
        {
            DateTime von = dTPVon.Value, bis = dTpBis.Value;
            von = von.AddHours(Convert.ToDouble(txBUhrzeitVon.Text.Split(':')[0]));
            bis = bis.AddHours(Convert.ToDouble(txBUhrzeitBis.Text.Split(':')[0]));
            if (index == -1)
                verwaltung.GetAngemeldetePerson().SetTermin(von.AddMinutes(Convert.ToDouble(txBUhrzeitVon.Text.Split(':')[1])), bis.AddMinutes(Convert.ToDouble(txBUhrzeitBis.Text.Split(':')[1])), txBBeschreibung.Text);
            else
                verwaltung.GetAngemeldetePerson().SetTermin(von.AddMinutes(Convert.ToDouble(txBUhrzeitVon.Text.Split(':')[1])), bis.AddMinutes(Convert.ToDouble(txBUhrzeitBis.Text.Split(':')[1])), txBBeschreibung.Text,index);
            Close();
        }

        private void dTPVon_ValueChanged(object sender, EventArgs e)
        {
            dTpBis.MinDate = dTPVon.Value;
        }
    }
}
