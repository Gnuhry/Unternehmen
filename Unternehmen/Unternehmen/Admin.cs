using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Unternehmen
{
    public partial class Admin : Form
    {
        Kalender kalender;
        Registrieren registrieren;
        Verwaltung verwaltung;
        public Admin(Verwaltung verwaltung)
        {
            InitializeComponent();
            this.verwaltung = verwaltung;
            for (int f = 1; f<verwaltung.GetFirma().GetMitarbeiterAnzahl(); f++)
                comBMitarbeiter.Items.Add(verwaltung.GetFirma().GetMitarbeiter(f).GetKontoInhaber());
            for(int f = 0; f < 7; f++)
                chbLArbeitstage.SetItemChecked(f, verwaltung.GetFirma().GetArbeitstag(f));
            numUrlaubstage.Value = verwaltung.GetFirma().GetMaxTage();
            txBWebsite.Text = verwaltung.GetFirma().GetWeb();
            if (txBWebsite.Text == "none")
                txBWebsite.Enabled = false;
            chBAutoAktiv.Checked = verwaltung.GetFirma().GetAutoRegistrieren();
            pcBFirmenlogo.Image = verwaltung.GetFirma().GetFirmenLogo();
        }

        private void btnFeuern_Click(object sender, EventArgs e)
        {
            verwaltung.GetFirma().Mitarbeiter_feuern(verwaltung.GetFirma().GetMitarbeiter(comBMitarbeiter.SelectedIndex + 1));
            btnAktivieren.Enabled = btnFeuern.Enabled = btnPassword.Enabled = btnSperren.Enabled = btnUrlaub.Enabled = false;
            comBMitarbeiter.Items.RemoveAt(comBMitarbeiter.SelectedIndex);
        }

        private void btnAktivieren_Click(object sender, EventArgs e)
        {
            verwaltung.GetFirma().GetMitarbeiter(comBMitarbeiter.SelectedIndex + 1).SetStatus(1);
            btnAktivieren.Enabled = false; btnSperren.Enabled = true;

        }

        private void btnSperren_Click(object sender, EventArgs e)
        {
            verwaltung.GetFirma().GetMitarbeiter(comBMitarbeiter.SelectedIndex + 1).SetStatus(0);
            btnSperren.Enabled = false; btnAktivieren.Enabled = true;
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            if (registrieren != null) { registrieren.Show(); return; }
            registrieren = new Registrieren(verwaltung,verwaltung.GetFirma().GetMitarbeiter(comBMitarbeiter.SelectedIndex + 1));
            registrieren.Show();
            registrieren.FormClosing += Registrieren_FormClosing;
        }

        private void Registrieren_FormClosing(object sender, FormClosingEventArgs e)
        {
            registrieren = null;
        }

        private void btnEinsehen_Click(object sender, EventArgs e)
        {
            MessageBox.Show(verwaltung.GetFirma().GetMitarbeiter(comBMitarbeiter.SelectedIndex + 1).GetZeiten());

        }

        private void btnUrlaub_Click(object sender, EventArgs e)
        {
            if(kalender!=null) { kalender.Show();return; }
            kalender = new Kalender(verwaltung, true);
            kalender.FormClosing += Kalender_FormClosing;
            kalender.Show();
        }

        private void Kalender_FormClosing(object sender, FormClosingEventArgs e)
        {
            kalender = null;
        }

        private void comBMitarbeiter_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAktivieren.Enabled = btnFeuern.Enabled = btnPassword.Enabled = btnSperren.Enabled = btnUrlaub.Enabled = btnEinsehen.Enabled = true;
            if (verwaltung.GetFirma().GetMitarbeiter(comBMitarbeiter.SelectedIndex + 1).GetStatus() != "gesperrt")
                btnAktivieren.Enabled = false;
            else
                btnSperren.Enabled = false;
        }

        private void txBWebsite_TextChanged(object sender, EventArgs e)
        {
            verwaltung.GetFirma().SetWeb(txBWebsite.Text);
        }

        private void chBWebsite_CheckedChanged(object sender, EventArgs e)
        {
            txBWebsite.Enabled = chBWebsite.Checked;
            if(!chBWebsite.Checked)
                verwaltung.GetFirma().SetWeb("none");
        }

        private void numUrlaubstage_ValueChanged(object sender, EventArgs e)
        {
            verwaltung.GetFirma().SetMaxTage((int)numUrlaubstage.Value);
        }

        private void chbLArbeitstage_SelectedValueChanged(object sender, EventArgs e)
        {
            bool[] erg = new bool[7];
            for (int f = 0; f < 7; f++)
                erg[f] = chbLArbeitstage.GetItemChecked(f);
            verwaltung.GetFirma().SetArbeitstag(erg);
        }

        private void chBAutoAktiv_CheckedChanged(object sender, EventArgs e)
        {
            verwaltung.GetFirma().SetAutoRegistrieren(chBAutoAktiv.Checked);
        }

        private void btnMessenger_Click(object sender, EventArgs e)
        {
            verwaltung.Postfach();
        }

        private void Admin_DragDrop(object sender, DragEventArgs e)
        {
            pcBFirmenlogo.Image=new Bitmap(((string[])e.Data.GetData(DataFormats.FileDrop))[0]);
            verwaltung.GetFirma().SetFirmenLogo(pcBFirmenlogo.Image);
        }

        private void Admin_DragEnter(object sender, DragEventArgs e)
        {
            string[] validExtensions = new string[] { ".png", ".jpg" };
            foreach (var ext in ((IEnumerable<string>)e.Data.GetData(DataFormats.FileDrop)).Select((f) => System.IO.Path.GetExtension(f)))
                if (!validExtensions.Contains(ext))
                    e.Effect = DragDropEffects.None;
            e.Effect = DragDropEffects.Copy;
        }

        private void btnLogoHochladen_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = "c:\\",
                Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                        using (myStream)
                        {
                            pcBFirmenlogo.Image = new Bitmap(myStream);
                            verwaltung.GetFirma().SetFirmenLogo(pcBFirmenlogo.Image);
                        }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
        }

    }
}
