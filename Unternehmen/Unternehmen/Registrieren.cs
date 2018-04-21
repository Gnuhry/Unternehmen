using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Unternehmen
{
    public partial class Registrieren : Form
    {
        Verwaltung verwaltung;
        Konto angemeldet;
        bool aa;
        public Registrieren(Verwaltung verwaltung)
        {
            this.verwaltung = verwaltung;
            InitializeComponent();
            InitComboBox();
            pcBProfilbild.Image = Properties.Resources.ic_android_black_24dp;
            Logo_Picturebox.Image =  verwaltung.GetFirma().GetFirmenLogo();
            aa = true;
        }
        public Registrieren(Verwaltung verwaltung, Konto angemeldet)
        {
           // WindowState = FormWindowState.Maximized;
            this.verwaltung = verwaltung;
            InitializeComponent();
            this.angemeldet = angemeldet;
            InitComboBox();
            txBPasswortA.Visible = true;
            txBInhaber.Text = angemeldet.GetKontoInhaber();
            txBBenutzername.Text = angemeldet.GetBenutzername();
            btnLoschen.Visible = true;
            pcBProfilbild.Image = angemeldet.GetProfilbild();
            cBoxTag.SelectedIndex = angemeldet.GetGeburtstag().Day - 1;
            cBoxMonat.SelectedIndex = angemeldet.GetGeburtstag().Month - 1;
            cBoxJahr.SelectedIndex = angemeldet.GetGeburtstag().Year - 1;
            Logo_Picturebox.Image = verwaltung.GetFirma().GetFirmenLogo();
            aa = false;
        }

        private void InitComboBox()
        {
            for (int f = 0; f < 31; f++)
                cBoxTag.Items.Add(f + 1);
            for (int f = DateTime.Today.Year; f > DateTime.Today.Year - 100; f--)
                cBoxJahr.Items.Add(f);
            cBoxTag.SelectedIndex = cBoxMonat.SelectedIndex = cBoxJahr.SelectedIndex = 0;
        }

        private void btnRegistrieren_Click(object sender, EventArgs e)
        {
            if (!TermsandConditionsCheckbox.Checked)
            {
                MessageBox.Show("Terms and Condition annehmen");
                return;
            }
            if (aa)
                angemeldet = new Konto();
            else if (angemeldet.Login(angemeldet.GetBenutzername(), txBPasswortA.Text) != 0) { MessageBox.Show("Altes Passwort stimmt nicht"); return; }
            if (txBInhaber.Text.Trim() == null || txBInhaber.Text.Trim() == "") { MessageBox.Show("Kein Inhaber"); return; }
            if (txBBenutzername.Text.Trim() == null || txBBenutzername.Text.Trim() == "") { MessageBox.Show("Keinen Benutzernamen"); return; }
            if (txBPasswort.Text.Trim() == null || txBPasswort.Text.Trim() == "") { MessageBox.Show("Kein Passwort"); return; }
            if (txBPasswort.Text != txBPasswort2.Text) { MessageBox.Show("Passwörter überstimmen nicht ein"); return; }
            string temp;
            try
            {
                //MessageBox.Show(new DateTime(DateTime.Today.Year - cBoxJahr.SelectedIndex, cBoxMonat.SelectedIndex + 1, cBoxTag.SelectedIndex + 1).ToShortDateString());
                temp = angemeldet.Registrieren(txBInhaber.Text, txBBenutzername.Text, txBPasswort.Text, new DateTime(DateTime.Today.Year-cBoxJahr.SelectedIndex, cBoxMonat.SelectedIndex + 1, cBoxTag.SelectedIndex + 1), pcBProfilbild.Image,verwaltung.GetFirma().GetAutoRegistrieren());
            }
            catch (Exception) { temp = "Falsches Datum"; }
            if (temp == "")
            {
                if (verwaltung.GetFirma().AddMitarbeiter(angemeldet))
                    Close();
                else
                    MessageBox.Show("Benutzername existiert schon");
            }
            else
                MessageBox.Show(temp);       
        }

        private void btnLoschen_Click(object sender, EventArgs e)
        {
            verwaltung.Konto_Loschen();
        }

        private void Registrieren_DragEnter(object sender, DragEventArgs e)
        {
            string[] validExtensions = new string[] { ".png", ".jpg" };
            foreach (var ext in ((IEnumerable<string>)e.Data.GetData(DataFormats.FileDrop)).Select((f) => System.IO.Path.GetExtension(f)))
                if (!validExtensions.Contains(ext))
                    e.Effect = DragDropEffects.None;
            e.Effect = DragDropEffects.Copy;
        }

        private void Registrieren_DragDrop(object sender, DragEventArgs e)
        {
            pcBProfilbild.Image = new Bitmap(((string[])e.Data.GetData(DataFormats.FileDrop))[0]);
        }

        private void cBoxMonat_SelectedIndexChanged(object sender, EventArgs e)
        {
            cBoxTag.Items.Clear();
            for (int f = 0; f < DateTime.DaysInMonth(cBoxJahr.SelectedIndex+1, cBoxMonat.SelectedIndex+1); f++)
                cBoxTag.Items.Add(f + 1);
            cBoxTag.SelectedIndex = 0;
        }

        private void Beenden_Label_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnHochladen_Click(object sender, EventArgs e)
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
                            pcBProfilbild.Image = new Bitmap(myStream);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
        }
    }
}
