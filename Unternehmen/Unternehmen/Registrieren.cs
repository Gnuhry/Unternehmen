using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unternehmen
{
    public partial class Registrieren : Form
    {
        Verwaltung verwaltung;
        Konto angemeldet;
        public Registrieren(Verwaltung verwaltung)
        {
            this.verwaltung = verwaltung;
            InitializeComponent();
            InitComboBox();
            pcBProfilbild.Image = Properties.Resources.ic_android_black_24dp;
        }
        public Registrieren(Verwaltung verwaltung, Konto angemeldet)
        {
            
            this.verwaltung = verwaltung;
            InitializeComponent();
            this.angemeldet = angemeldet;
            InitComboBox();
            txBPasswortA.Visible = true;
            New_Password_Label.Visible = true;
            txBInhaber.Text = angemeldet.GetKontoInhaber();
            txBBenutzername.Text = angemeldet.GetBenutzername();
            btnLoschen.Visible = true;
            pcBProfilbild.Image = angemeldet.GetProfilbild();
            cBoxTag.SelectedIndex = angemeldet.GetGeburtstag().Day - 1;
            cBoxMonat.SelectedIndex = angemeldet.GetGeburtstag().Month - 1;
            cBoxJahr.SelectedIndex = angemeldet.GetGeburtstag().Year - 1;
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
            if (angemeldet == null)
            {
                angemeldet = new Konto();
            }
            else
            {
                if (angemeldet.Login(angemeldet.GetBenutzername(), txBPasswortA.Text) != 0) { MessageBox.Show("Altes Passwort stimmt nicht"); return; }
            }
            if (txBInhaber.Text.Trim() == null || txBInhaber.Text.Trim() == "") { MessageBox.Show("Kein Inhaber"); return; }
            if (txBBenutzername.Text.Trim() == null || txBBenutzername.Text.Trim() == "") { MessageBox.Show("Keinen Benutzernamen"); return; }
            if (txBPasswort.Text.Trim() == null || txBPasswort.Text.Trim() == "") { MessageBox.Show("Kein Passwort"); return; }
            if (txBPasswort.Text != txBPasswort2.Text) { MessageBox.Show("Passwörter stimmen nicht überein"); return; }
            string temp;
            try
            {
                //MessageBox.Show(new DateTime(DateTime.Today.Year - cBoxJahr.SelectedIndex, cBoxMonat.SelectedIndex + 1, cBoxTag.SelectedIndex + 1).ToShortDateString());
                temp = angemeldet.Registrieren(txBInhaber.Text, txBBenutzername.Text, txBPasswort.Text, new DateTime(DateTime.Today.Year-cBoxJahr.SelectedIndex, cBoxMonat.SelectedIndex + 1, cBoxTag.SelectedIndex + 1), pcBProfilbild.Image);
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

        private void Beenden_Label_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
