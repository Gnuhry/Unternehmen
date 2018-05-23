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
        ProfilAnzeige profilAnzeige;
        Verwaltung verwaltung;
        List<int> Admins, NoAdmin;
        public Admin(Verwaltung verwaltung)
        {
            Admins = new List<int>();
            NoAdmin = new List<int>();
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
            chBWebsite.Checked = txBWebsite.Enabled;
            chBAutoAktiv.Checked = verwaltung.GetFirma().GetAutoRegistrieren();
            pcBFirmenlogo.Image = verwaltung.GetFirma().GetFirmenLogo();
            txBFirmenmotto.Text = verwaltung.GetFirma().GetFirmenstatus();
            chBAutoRemoveUrlaub.Checked = verwaltung.GetFirma().GetAutoRemoveUrlaub();
            if (verwaltung.GetAngemeldetePerson() == verwaltung.GetFirma().GetMitarbeiter(0))
            {
                btnReset.Visible=rbtnResetEnabled.Visible= lBoxAdmin.Visible = lBoxNoAdmin.Visible = btnAdmin.Visible=btnNoAdmin.Visible = true;
                for (int f = 1; f < verwaltung.GetFirma().GetMitarbeiterAnzahl(); f++)
                    if (verwaltung.GetFirma().IsKonto(verwaltung.GetFirma().GetMitarbeiter(f))) { lBoxAdmin.Items.Add(verwaltung.GetFirma().GetMitarbeiter(f).GetKontoInhaber()); Admins.Add(f); }
                    else{ lBoxNoAdmin.Items.Add(verwaltung.GetFirma().GetMitarbeiter(f).GetKontoInhaber()); NoAdmin.Add(f); }
            }
        }

        private void btnFeuern_Click(object sender, EventArgs e)
        {
            verwaltung.GetFirma().Mitarbeiter_feuern(verwaltung.GetFirma().GetMitarbeiter(comBMitarbeiter.SelectedIndex + 1));
            btnAktivieren.Enabled = btnFeuern.Enabled = btnPassword.Enabled = btnSperren.Enabled = false;
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
            if (profilAnzeige != null) { profilAnzeige.Show(); return; }
            profilAnzeige = new ProfilAnzeige(verwaltung,verwaltung.GetFirma().GetMitarbeiter(comBMitarbeiter.SelectedIndex + 1));
            profilAnzeige.Show();
            profilAnzeige.FormClosing += Registrieren_FormClosing;
        }

        private void Registrieren_FormClosing(object sender, FormClosingEventArgs e)
        {
            profilAnzeige = null;
        }

        private void btnEinsehen_Click(object sender, EventArgs e)
        {
            MessageBox.Show(verwaltung.GetFirma().GetMitarbeiter(comBMitarbeiter.SelectedIndex + 1).GetZeiten());

        }

        private void comBMitarbeiter_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAktivieren.Enabled = btnFeuern.Enabled = btnPassword.Enabled = btnSperren.Enabled = btnEinsehen.Enabled = true;
            if (verwaltung.GetFirma().GetMitarbeiter(comBMitarbeiter.SelectedIndex + 1).GetStatus() != "gesperrt")
                btnAktivieren.Enabled = false;
            else
                btnSperren.Enabled = false;
        }

        private void txBWebsite_TextChanged(object sender, EventArgs e)
        {
            if (txBWebsite.Text.Trim() == null || txBWebsite.Text.Trim() == "")
                verwaltung.GetFirma().SetWeb("none");
            else
                verwaltung.GetFirma().SetWeb(txBWebsite.Text);
            try
            {
                (MdiParent as Menue).WebsiteAktualisieren();
            }catch(Exception) { }
        }

        private void chBWebsite_CheckedChanged(object sender, EventArgs e)
        {
            txBWebsite.Enabled = chBWebsite.Checked;
            txBWebsite.Text = "";
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


        private void Admin_DragDrop(object sender, DragEventArgs e)
        {
            pcBFirmenlogo.Image=new Bitmap(((string[])e.Data.GetData(DataFormats.FileDrop))[0]);
            verwaltung.GetFirma().SetFirmenLogo(((string[])e.Data.GetData(DataFormats.FileDrop))[0]);
            verwaltung.MenueAktualisieren();
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
                            myStream.Dispose();
                            verwaltung.GetFirma().SetFirmenLogo(openFileDialog1.FileName);
                            verwaltung.MenueAktualisieren();
                        }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
        }

        private void txBFirmenmotto_TextChanged(object sender, EventArgs e)
        {
            verwaltung.GetFirma().SetFirmenstatus(txBFirmenmotto.Text);
        }

        private void chBAutoRemoveUrlaub_CheckedChanged(object sender, EventArgs e)
        {
            verwaltung.GetFirma().SetAutoRemoveUrlaub(chBAutoRemoveUrlaub.Checked);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            verwaltung.GetFirma().SetAdmin(verwaltung.GetFirma().GetMitarbeiter(NoAdmin[lBoxNoAdmin.SelectedIndex]));
            lBoxAdmin.Items.Add(verwaltung.GetFirma().GetMitarbeiter(NoAdmin[lBoxNoAdmin.SelectedIndex]).GetKontoInhaber());
            lBoxNoAdmin.Items.Remove(verwaltung.GetFirma().GetMitarbeiter(NoAdmin[lBoxNoAdmin.SelectedIndex]).GetKontoInhaber());
            NoAdmin.Remove(lBoxNoAdmin.SelectedIndex);
            Admins.Add(lBoxNoAdmin.SelectedIndex);

            lBoxAdmin.Update();
            lBoxNoAdmin.Update();
            verwaltung.UpdateAdmin();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            verwaltung.Reset();
        }

        private void rbtnResetEnabled_Click(object sender, EventArgs e)
        {
            //rbtnResetEnabled.Checked = !rbtnResetEnabled.Checked;
            if (rbtnResetEnabled.Checked) btnReset.Enabled = true;
            else btnReset.Enabled = false;
        }

        private void btnNoAdmin_Click(object sender, EventArgs e)
        {
            verwaltung.GetFirma().RemoveAdmin(verwaltung.GetFirma().GetMitarbeiter(Admins[lBoxAdmin.SelectedIndex]));
            lBoxNoAdmin.Items.Add(verwaltung.GetFirma().GetMitarbeiter(Admins[lBoxAdmin.SelectedIndex]).GetKontoInhaber());
            lBoxAdmin.Items.Remove(verwaltung.GetFirma().GetMitarbeiter(Admins[lBoxAdmin.SelectedIndex]).GetKontoInhaber());
            Admins.Remove(lBoxNoAdmin.SelectedIndex);
            NoAdmin.Add(lBoxNoAdmin.SelectedIndex);
            lBoxAdmin.Update();
            lBoxNoAdmin.Update();
            verwaltung.UpdateAdmin();

        }
    }
}
