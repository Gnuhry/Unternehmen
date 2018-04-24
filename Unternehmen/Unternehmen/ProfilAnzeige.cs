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
            Profil = new Point[4];
            InitializeComponent();
            this.verwaltung = verwaltung;
            InitComboBox();
            Init();
            InitProfil();
        }

        private void InitProfil()
        {
            lbInhaber.Location = Profil[0];
            lbStatus.Location = Profil[1];
            lbGeburtstag.Location = Profil[2];
            pcBProfil.Location = Profil[3];

        }

        private void Init()
        {
            txBBenutzername.Text = verwaltung.GetAngemeldetePerson().GetBenutzername();
            txBInhaber.Text = verwaltung.GetAngemeldetePerson().GetKontoInhaber();
            cBoxTag.SelectedIndex = verwaltung.GetAngemeldetePerson().GetGeburtstag().Day - 1;
            cBoxMonat.SelectedIndex = verwaltung.GetAngemeldetePerson().GetGeburtstag().Month - 1;
            cBoxJahr.SelectedIndex = verwaltung.GetAngemeldetePerson().GetGeburtstag().Year % DateTime.Today.Year;
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
            lbStatus.Text = txBStatus.Text;
        }

        private void txBInhaber_TextChanged_1(object sender, EventArgs e)
        {
            verwaltung.GetAngemeldetePerson().SetInhaber(txBInhaber.Text);
            lbInhaber.Text = txBInhaber.Text;
        }

        private void cBoxTag_SelectedIndexChanged(object sender, EventArgs e)
        {
            verwaltung.GetAngemeldetePerson().SetGeburtstag(new DateTime(cBoxTag.SelectedIndex + 1, cBoxMonat.SelectedIndex + 1, DateTime.Today.Year - cBoxJahr.SelectedIndex));
            lbGeburtstag.Text = verwaltung.GetAngemeldetePerson().GetGeburtstag().ToShortDateString();
        }

        private void cBoxMonat_SelectedIndexChanged(object sender, EventArgs e)
        {
            cBoxTag.Items.Clear();
            for (int f = 0; f < DateTime.DaysInMonth(cBoxJahr.SelectedIndex + 1, cBoxMonat.SelectedIndex + 1); f++)
                cBoxTag.Items.Add(f + 1);
            cBoxTag.SelectedIndex = 0;
            verwaltung.GetAngemeldetePerson().SetGeburtstag(new DateTime(cBoxTag.SelectedIndex + 1, cBoxMonat.SelectedIndex + 1, DateTime.Today.Year - cBoxJahr.SelectedIndex));
            lbGeburtstag.Text = verwaltung.GetAngemeldetePerson().GetGeburtstag().ToShortDateString();
        }

        private void cBoxJahr_SelectedIndexChanged(object sender, EventArgs e)
        {

            verwaltung.GetAngemeldetePerson().SetGeburtstag(new DateTime(cBoxTag.SelectedIndex + 1, cBoxMonat.SelectedIndex + 1, DateTime.Today.Year - cBoxJahr.SelectedIndex));
            lbGeburtstag.Text = verwaltung.GetAngemeldetePerson().GetGeburtstag().ToShortDateString();
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
            return true;
        }
        private void Speichern()
        {
            Profil[0]=lbInhaber.Location;
            Profil[1]=lbStatus.Location;
            Profil[2]=lbGeburtstag.Location;
            Profil[3]=pcBProfil.Location;
        }
    }
}
