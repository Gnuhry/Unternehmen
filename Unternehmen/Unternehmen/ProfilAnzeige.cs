using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unternehmen
{
    public partial class ProfilAnzeige : Form
    {
        Point[] Profil;
        Verwaltung verwaltung;
        private Control activeControl;
        private Point previousPosition;

        public ProfilAnzeige(Verwaltung verwaltung)
        {
            Profil = verwaltung.GetAngemeldetePerson().Profil1;
            InitializeComponent();
            this.verwaltung = verwaltung;
            InitComboBox();
            Init();
            InitProfil();
        }

        private void InitProfil()
        {
            Profil = verwaltung.GetAngemeldetePerson().Profil1;
            lbInhaber.Location = Profil[0];
            lbStatus.Location = Profil[1];
            lbGeburtstag.Location = Profil[2];
            pcBProfil.Location = Profil[3];
            lbAbteilung.Location = Profil[4];
            lbEmail.Location = Profil[5];
            lbHobby.Location = Profil[6];
            lbTelefon.Location = Profil[7];
        }

        private void Init()
        {
            BackgroundImage = verwaltung.GetAngemeldetePerson().Hintergrundbild1;
            txBBenutzername.Text = verwaltung.GetAngemeldetePerson().GetBenutzername();
            txBInhaber.Text = verwaltung.GetAngemeldetePerson().GetKontoInhaber();
            cBoxTag.SelectedIndex = verwaltung.GetAngemeldetePerson().GetGeburtstag().Day - 1;
            cBoxMonat.SelectedIndex = verwaltung.GetAngemeldetePerson().GetGeburtstag().Month - 1;
            cBoxJahr.SelectedIndex = verwaltung.GetAngemeldetePerson().GetGeburtstag().Year % DateTime.Today.Year;
            txBEmail.Text = verwaltung.GetAngemeldetePerson().Email1;
            txBAbteilung.Text = verwaltung.GetAngemeldetePerson().Abteilung1;
            txBHobbys.Text = verwaltung.GetAngemeldetePerson().Hobbys1;
            txBStatus.Text = verwaltung.GetAngemeldetePerson().Status1;
            txBTelefon.Text = verwaltung.GetAngemeldetePerson().Telefon1;
            pcBProfil.Image = verwaltung.GetAngemeldetePerson().GetProfilbild();
        }
        private void InitComboBox()
        {
            for (int f = 0; f < 31; f++)
                cBoxTag.Items.Add(f + 1);
            for (int f = DateTime.Today.Year; f > DateTime.Today.Year - 100; f--)
                cBoxJahr.Items.Add(f);
            cBoxTag.SelectedIndex = cBoxMonat.SelectedIndex = cBoxJahr.SelectedIndex = 0;
        }

        private void btnAndern_Click(object sender, EventArgs e)
        {
            if (txBInhaber.Text.Trim() == null || txBInhaber.Text.Trim() == "") { lbFehlermeldung.Text = "Kein Inhaber"; return; }
            if (txBBenutzername.Text.Trim() == null || txBBenutzername.Text.Trim() == "") { lbFehlermeldung.Text = "Keinen Benutzernamen"; return; }
            if (txBPasswort.Text.Trim() == null || txBPasswort.Text.Trim() == "") { lbFehlermeldung.Text = "Kein Passwort"; return; }
            if (txBPasswort.Text != txBPasswort2.Text) { lbFehlermeldung.Text = "Passwörter überstimmen nicht ein"; return; }
            if (verwaltung.GetAngemeldetePerson().Login(verwaltung.GetAngemeldetePerson().GetBenutzername(), txBPasswortA.Text) == 0)
            {
                verwaltung.GetAngemeldetePerson().Registrieren(txBInhaber.Text, txBBenutzername.Text, txBPasswort.Text, DateTime.Today, pcBProfil.Image, true);
                txBInhaber.Text = txBBenutzername.Text = txBPasswort.Text = txBPasswort2.Text = txBPasswortA.Text = null;
            }
            else lbFehlermeldung.Text = "Falsches Altes Passwort";
        }

        private void btnProfilbildHochladen_Click(object sender, EventArgs e)
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
                            pcBProfil.Image = new Bitmap(myStream);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
        }


        private void txBStatus_TextChanged(object sender, EventArgs e)
        {
            verwaltung.GetAngemeldetePerson().Status1 = txBStatus.Text;
            lbStatus.Text = txBStatus.Text;
        }

        private void txBInhaber_TextChanged_1(object sender, EventArgs e)
        {
            verwaltung.GetAngemeldetePerson().SetInhaber(txBInhaber.Text);
            lbInhaber.Text = txBInhaber.Text;
        }

        private void cBoxTag_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                verwaltung.GetAngemeldetePerson().SetGeburtstag(new DateTime(DateTime.Today.Year - cBoxJahr.SelectedIndex, cBoxMonat.SelectedIndex + 1, cBoxTag.SelectedIndex + 1 ));
                lbGeburtstag.Text = verwaltung.GetAngemeldetePerson().GetGeburtstag().ToShortDateString();
            }
            catch (Exception) { }
        }

        private void cBoxMonat_SelectedIndexChanged(object sender, EventArgs e)
        {
            cBoxTag.Items.Clear();
            for (int f = 0; f < DateTime.DaysInMonth(cBoxJahr.SelectedIndex + 1, cBoxMonat.SelectedIndex + 1); f++)
                cBoxTag.Items.Add(f + 1);
            cBoxTag.SelectedIndex = 0;
            try
            {
                verwaltung.GetAngemeldetePerson().SetGeburtstag(new DateTime(DateTime.Today.Year - cBoxJahr.SelectedIndex, cBoxMonat.SelectedIndex + 1, cBoxTag.SelectedIndex + 1));
                lbGeburtstag.Text = verwaltung.GetAngemeldetePerson().GetGeburtstag().ToShortDateString();
            }
            catch (Exception) { }
        }

        private void cBoxJahr_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                verwaltung.GetAngemeldetePerson().SetGeburtstag(new DateTime(DateTime.Today.Year - cBoxJahr.SelectedIndex, cBoxMonat.SelectedIndex + 1, cBoxTag.SelectedIndex + 1));
                lbGeburtstag.Text = verwaltung.GetAngemeldetePerson().GetGeburtstag().ToShortDateString();
            }
            catch (Exception) { }
        }
        private void Bewegen_MouseDown(object sender, MouseEventArgs e)
        {
            //sender = Tabel(sender);
            if (e.Button == MouseButtons.Right)
            {
                activeControl = sender as Control;
                previousPosition = e.Location;
                Cursor = Cursors.Hand;
            }
        }

        private void Bewegen_MouseMove(object sender, MouseEventArgs e)
        {

            if (activeControl == null || activeControl != sender)
                return;
            else
            {
                Point location = (sender as Control).Location;
                location.Offset(e.Location.X - previousPosition.X, e.Location.Y - previousPosition.Y);
                if (Randuerberprufung(location, sender))
                    (sender as Control).Location = location;
            }
        }

        private void Bewegen_MouseUp(object sender, MouseEventArgs e)
        {
            activeControl = null;
            Cursor = Cursors.Default;

        }
        private bool Randuerberprufung(Point sender, object sender_)
        {
            if (sender.X < 0 || sender.X + (sender_ as Control).Width > panel2.Width)
                return false;
            if (sender.Y < 0 || sender.Y + (sender_ as Control).Height > panel2.Height)
                return false;
            if (sender_ != pcBProfil)
            {
                if (pcBProfil.Location.X < sender.X + (sender_ as Control).Width &
                    sender.X < pcBProfil.Location.X + pcBProfil.Size.Width &&
                    pcBProfil.Location.Y < sender.Y + (sender_ as Control).Height &&
                    sender.Y < pcBProfil.Location.Y + pcBProfil.Size.Height)
                    return false;
            }
            if (sender_ != lbGeburtstag)
            {
                if (lbGeburtstag.Location.X < sender.X + (sender_ as Control).Width &
                    sender.X < lbGeburtstag.Location.X + lbGeburtstag.Size.Width &&
                    lbGeburtstag.Location.Y < sender.Y + (sender_ as Control).Height &&
                    sender.Y < lbGeburtstag.Location.Y + lbGeburtstag.Size.Height)
                    return false;
            }
            if (sender_ != lbInhaber)
            {
                if (lbInhaber.Location.X < sender.X + (sender_ as Control).Width &
                    sender.X < lbInhaber.Location.X + lbInhaber.Size.Width &&
                    lbInhaber.Location.Y < sender.Y + (sender_ as Control).Height &&
                    sender.Y < lbInhaber.Location.Y + lbInhaber.Size.Height)
                    return false;
            }
            if (sender_ != lbStatus)
            {
                if (lbStatus.Location.X < sender.X + (sender_ as Control).Width &
                    sender.X < lbStatus.Location.X + lbStatus.Size.Width &&
                    lbStatus.Location.Y < sender.Y + (sender_ as Control).Height &&
                    sender.Y < lbStatus.Location.Y + lbStatus.Size.Height)
                    return false;
            }
            if (sender_ != txBAbteilung)
            {
                if (txBAbteilung.Location.X < sender.X + (sender_ as Control).Width &
                    sender.X < txBAbteilung.Location.X + txBAbteilung.Size.Width &&
                    txBAbteilung.Location.Y < sender.Y + (sender_ as Control).Height &&
                    sender.Y < txBAbteilung.Location.Y + txBAbteilung.Size.Height)
                    return false;
            }
            if (sender_ != txBEmail)
            {
                if (txBEmail.Location.X < sender.X + (sender_ as Control).Width &
                    sender.X < txBEmail.Location.X + txBEmail.Size.Width &&
                    txBEmail.Location.Y < sender.Y + (sender_ as Control).Height &&
                    sender.Y < txBEmail.Location.Y + txBEmail.Size.Height)
                    return false;
            }
            if (sender_ != txBHobbys)
            {
                if (txBHobbys.Location.X < sender.X + (sender_ as Control).Width &
                    sender.X < txBHobbys.Location.X + txBHobbys.Size.Width &&
                    txBHobbys.Location.Y < sender.Y + (sender_ as Control).Height &&
                    sender.Y < txBHobbys.Location.Y + txBHobbys.Size.Height)
                    return false;
            }
            if (sender_ != txBStatus)
            {
                if (txBStatus.Location.X < sender.X + (sender_ as Control).Width &
                    sender.X < txBStatus.Location.X + txBStatus.Size.Width &&
                    txBStatus.Location.Y < sender.Y + (sender_ as Control).Height &&
                    sender.Y < txBStatus.Location.Y + txBStatus.Size.Height)
                    return false;
            }
            if (sender_ != txBTelefon)
            {
                if (txBTelefon.Location.X < sender.X + (sender_ as Control).Width &
                    sender.X < txBTelefon.Location.X + txBTelefon.Size.Width &&
                    txBTelefon.Location.Y < sender.Y + (sender_ as Control).Height &&
                    sender.Y < txBTelefon.Location.Y + txBTelefon.Size.Height)
                    return false;
            }
            return true;

        }
        private void Speichern()
        {
            Profil[0] = lbInhaber.Location;
            Profil[1] = lbStatus.Location;
            Profil[2] = lbGeburtstag.Location;
            Profil[3] = pcBProfil.Location;
            Profil[4] = txBAbteilung.Location;
            Profil[5] = txBEmail.Location;
            Profil[6] = txBHobbys.Location;
            Profil[7] = txBTelefon.Location;
            verwaltung.GetAngemeldetePerson().Profil1 = Profil;
            verwaltung.GetAngemeldetePerson().Hintergrundbild1 = BackgroundImage;
            verwaltung.GetAngemeldetePerson().SetProfilbild(pcBProfil.Image);
        }

        private void btnHintergrundHochladen_Click(object sender, EventArgs e)
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
                            BackgroundImage = new Bitmap(myStream);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
        }

        private void txBTelefon_TextChanged(object sender, EventArgs e)
        {
            verwaltung.GetAngemeldetePerson().Telefon1 = txBTelefon.Text;
            lbTelefon.Text = txBTelefon.Text;
        }

        private void txBAbteilung_TextChanged(object sender, EventArgs e)
        {
            verwaltung.GetAngemeldetePerson().Abteilung1 = txBAbteilung.Text;
            lbAbteilung.Text = txBAbteilung.Text;
        }

        private void txBHobbys_TextChanged(object sender, EventArgs e)
        {
            verwaltung.GetAngemeldetePerson().Hobbys1 = txBHobbys.Text;
            lbHobby.Text = txBHobbys.Text;
        }

        private void txBEmail_TextChanged(object sender, EventArgs e)
        {
            verwaltung.GetAngemeldetePerson().Email1 = txBEmail.Text;
            lbEmail.Text = txBEmail.Text;
        }

        private void ProfilAnzeige_FormClosing(object sender, FormClosingEventArgs e)
        {
            Speichern();
        }
    }
}
