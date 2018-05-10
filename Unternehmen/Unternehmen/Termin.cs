﻿using System;
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
            try
            {
                dTpBis.Value = bis;
            }
            catch (Exception) { }
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
            if (chBDienstag.Checked || chBDonnerstag.Checked || chBFreitag.Checked || chBMittwoch.Checked || chBMo.Checked || chBSamstag.Checked || chBSonntag.Checked || chBJahrlich.Checked || chBMonatlich.Checked)
            {
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
                    verwaltung.GetAngemeldetePerson().SetTermin(von, txBBeschreibung.Text,wiederholung);
                else
                    verwaltung.GetAngemeldetePerson().SetTermin(von, txBBeschreibung.Text, index,wiederholung);
            }
            else
            {
                if (index == -1)
                    verwaltung.GetAngemeldetePerson().SetTermin(von, bis, txBBeschreibung.Text);
                else
                    verwaltung.GetAngemeldetePerson().SetTermin(von, bis, txBBeschreibung.Text, index);
            }
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
