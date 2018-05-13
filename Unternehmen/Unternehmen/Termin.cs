using System;
using System.Windows.Forms;

namespace Unternehmen
{
    public partial class Termin : Form
    {
        Verwaltung verwaltung;
        int index;
        public Termin(Verwaltung verwaltung,int index,DateTime date)
        {
            this.verwaltung = verwaltung;
            this.index = index;
            InitializeComponent();
            dTPVon.MinDate = dTpBis.MinDate = DateTime.Today;
            dTPVon.Value = date;
            cBoxVonMin.SelectedIndex = cBoxBisMin.SelectedIndex = cBoxBisHour.SelectedIndex = cBoxVonHour.SelectedIndex = 0;
            if (index == -1) return;
            btnLoschen.Visible = true;
            //Eintragen
            DateTime von =verwaltung.GetAngemeldetePerson().GetTerminVon(index);
            DateTime bis = verwaltung.GetAngemeldetePerson().GetTerminBis(index);
            dTPVon.Value = von.Date;
            dTpBis.Value = bis.Date;
            txBBeschreibung.Text = verwaltung.GetAngemeldetePerson().GetTerminBeschreibung(index);
            cBoxVonHour.SelectedIndex = von.Hour;
            cBoxVonMin.SelectedIndex = von.Minute;
            cBoxBisHour.SelectedIndex = bis.Hour;
            cBoxBisMin.SelectedIndex = bis.Minute;
            bool[] temp = verwaltung.GetAngemeldetePerson().GetTerminWiederholung(index);
            chBMo.Checked = temp[0];
            chBDienstag.Checked = temp[1];
            chBMittwoch.Checked = temp[2];
            chBDonnerstag.Checked = temp[3];
            chBFreitag.Checked = temp[4];
            chBSamstag.Checked = temp[5];
            chBSonntag.Checked = temp[6];
            chBMonatlich.Checked = temp[7];
            chBJahrlich.Checked = temp[8];
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
            if (!dTpBis.Enabled)
                bis = DateTime.Today;
            bis = bis.AddHours(cBoxBisHour.SelectedIndex).AddMinutes(cBoxBisMin.SelectedIndex);
            string wiederholung;
                if (chBMo.Checked) wiederholung = "1";
                else wiederholung = "0";
                if (chBDienstag.Checked) wiederholung+= "1";
                else wiederholung+= "0";
                if (chBMittwoch.Checked) wiederholung += "1";
                else wiederholung += "0";
                if (chBDonnerstag.Checked) wiederholung += "1";
                else wiederholung += "0";
                if (chBFreitag.Checked) wiederholung += "1";
                else wiederholung += "0";
                if (chBSamstag.Checked) wiederholung += "1";
                else wiederholung += "0";
                if (chBSonntag.Checked) wiederholung += "1";
                else wiederholung += "0";
                if (chBMonatlich.Checked) wiederholung += "1";
                else wiederholung += "0";
                if (chBJahrlich.Checked) wiederholung += "1";
                else wiederholung += "0";
                if (index == -1)
                    verwaltung.GetAngemeldetePerson().SetTermin(von,bis, txBBeschreibung.Text,wiederholung);
                else
                    verwaltung.GetAngemeldetePerson().SetTermin(von,bis, txBBeschreibung.Text, index,wiederholung);          
            Close();
        }

        private void dTPVon_ValueChanged(object sender, EventArgs e)
        {
            dTpBis.MinDate = dTPVon.Value;
        }

        private void CheckedChangedWochentag(object sender, EventArgs e)
        {
            if (chBDienstag.Checked || chBDonnerstag.Checked || chBFreitag.Checked || chBMittwoch.Checked || chBMo.Checked || chBSamstag.Checked || chBSonntag.Checked)
                chBMonatlich.Checked = chBJahrlich.Checked = dTpBis.Enabled = false;
            else dTpBis.Enabled = true;
        }

        private void chBMonatlich_CheckedChanged(object sender, EventArgs e)
        {
            if (chBMonatlich.Checked)
                dTpBis.Enabled=chBJahrlich.Checked = chBDienstag.Checked = chBDonnerstag.Checked = chBFreitag.Checked = chBMittwoch.Checked = chBMo.Checked = chBSamstag.Checked = chBSonntag.Checked = false;
            else dTpBis.Enabled = true;

        }

        private void chBJahrlich_CheckedChanged(object sender, EventArgs e)
        {
            if (chBJahrlich.Checked)
                dTpBis.Enabled=chBMonatlich.Checked = chBDienstag.Checked = chBDonnerstag.Checked = chBFreitag.Checked = chBMittwoch.Checked = chBMo.Checked = chBSamstag.Checked = chBSonntag.Checked = false;
            else
                dTpBis.Enabled = true;
        }
    }
}
