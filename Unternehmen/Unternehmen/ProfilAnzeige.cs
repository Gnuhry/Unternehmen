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
        string Bild;
        Point[] Profil;
        Verwaltung verwaltung;
        private Control activeControl;
        private Point previousPosition;
        private Konto angemeldet;
        bool aa;

        public ProfilAnzeige(Verwaltung verwaltung)
        {
            aa = false;
            angemeldet = verwaltung.GetAngemeldetePerson();
            InitializeComponent();
            this.verwaltung = verwaltung;
            InitComboBox();
            Init();
            InitProfil();
            lbFehlermeldung.Text = null;
        }
        public ProfilAnzeige(Verwaltung verwaltung,Konto angemeldet)
        {
            aa = true;
            this.angemeldet = angemeldet;
            InitializeComponent();
            this.verwaltung = verwaltung;
            InitComboBox();
            Init();
            InitProfil();
            txBPasswortA.Text = "-----------------------------";
            txBPasswortA.Enabled = false;
            Beenden_Label.Visible = true;
        }

        private void InitProfil()
        {
            Profil = angemeldet.GetProfil();
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
            Bild = verwaltung.GetAngemeldetePerson().GetProfilBildPath();
            if (angemeldet.GetGeschlecht()) rbtMann.Checked = true;
            else rbtFrau.Checked = true;
            
            txBBenutzername.Text = angemeldet.GetBenutzername();
            
            cBoxTag.SelectedIndex = angemeldet.GetGeburtstag().Day - 1;
            cBoxMonat.SelectedIndex = angemeldet.GetGeburtstag().Month - 1;
            cBoxJahr.SelectedIndex = ( DateTime.Today.Year- angemeldet.GetGeburtstag().Year);
            lbGeburtstag.Text = angemeldet.GetGeburtstag().ToShortDateString();
            cBoxTag.SelectedIndexChanged += cBoxTag_SelectedIndexChanged;
            cBoxMonat.SelectedIndexChanged += cBoxMonat_SelectedIndexChanged;
            cBoxJahr.SelectedIndexChanged += cBoxJahr_SelectedIndexChanged;
            txBEmail.Text = angemeldet.GetEmail();
            txBAbteilung.Text = angemeldet.GetAbteilung();
            txBHobbys.Text = angemeldet.GetHobby();
            txBStatus.Text = angemeldet.GetStatus_();
            txBTelefon.Text = angemeldet.GetTelefon();
            pcBProfil.Image = angemeldet.GetProfilbild();
            txBInhaber.Text = angemeldet.GetKontoInhaber();
            Inhaber();
        }
        private void Inhaber()
        {
            if(angemeldet.GetGeschlecht())
                lbInhaber.Text="Mr."+ angemeldet.GetKontoInhaber();
            else
                lbInhaber.Text = "Ms." + angemeldet.GetKontoInhaber();
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
            if (txBInhaber.Text.Trim() == null || txBInhaber.Text.Trim() == "") { lbFehlermeldung.Text = "Missing name"; return; }
            if (txBBenutzername.Text.Trim() == null || txBBenutzername.Text.Trim() == "") { lbFehlermeldung.Text = "Missing username"; return; }
            if (txBPasswort.Text.Trim() == null || txBPasswort.Text.Trim() == "") { lbFehlermeldung.Text = "Missing password"; return; }
            if (txBPasswort.Text != txBPasswort2.Text) { lbFehlermeldung.Text = "passwords aren't matching"; return; }
            if (angemeldet.Login(angemeldet.GetBenutzername(), txBPasswortA.Text) == 0||aa)
            {
                angemeldet.Registrieren(txBInhaber.Text, txBBenutzername.Text, txBPasswort.Text, DateTime.Today, Bild,rbtMann.Checked, true);
                txBInhaber.Text = txBBenutzername.Text = txBPasswort.Text = txBPasswort2.Text = txBPasswortA.Text = null;
            }
            else lbFehlermeldung.Text = "prior password incorrect";
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
                        {
                            verwaltung.GetAngemeldetePerson().SetProfilbild(openFileDialog1.FileName);
                            Bild = verwaltung.GetAngemeldetePerson().GetProfilBildPath();
                        }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
        }


        private void txBStatus_TextChanged(object sender, EventArgs e)
        {
            angemeldet.SetStatus(txBStatus.Text);
            lbStatus.Text = txBStatus.Text;
        }

        private void txBInhaber_TextChanged_1(object sender, EventArgs e)
        {
            angemeldet.SetInhaber(txBInhaber.Text);
            lbInhaber.Text = txBInhaber.Text;
        }

        private void cBoxTag_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                angemeldet.SetGeburtstag(new DateTime(DateTime.Today.Year - cBoxJahr.SelectedIndex, cBoxMonat.SelectedIndex + 1, cBoxTag.SelectedIndex + 1 ));
                lbGeburtstag.Text = angemeldet.GetGeburtstag().ToShortDateString();
            }
            catch (Exception) { }
        }

        private void cBoxMonat_SelectedIndexChanged(object sender, EventArgs e)
        {
            int temp = cBoxTag.SelectedIndex;
            cBoxTag.Items.Clear();
            for (int f = 0; f < DateTime.DaysInMonth(DateTime.Today.Year-cBoxJahr.SelectedIndex, cBoxMonat.SelectedIndex + 1); f++)
                cBoxTag.Items.Add(f + 1);
            if (temp < DateTime.DaysInMonth(DateTime.Today.Year - cBoxJahr.SelectedIndex, cBoxMonat.SelectedIndex + 1))
                cBoxTag.SelectedIndex = temp;
            else
                cBoxTag.SelectedIndex = 0;
            try
            {
                angemeldet.SetGeburtstag(new DateTime(DateTime.Today.Year - cBoxJahr.SelectedIndex, cBoxMonat.SelectedIndex + 1, cBoxTag.SelectedIndex + 1));
                lbGeburtstag.Text = angemeldet.GetGeburtstag().ToShortDateString();
            }
            catch (Exception) { }
        }

        private void cBoxJahr_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                angemeldet.SetGeburtstag(new DateTime(DateTime.Today.Year - cBoxJahr.SelectedIndex, cBoxMonat.SelectedIndex + 1, cBoxTag.SelectedIndex + 1));
                lbGeburtstag.Text = angemeldet.GetGeburtstag().ToShortDateString();
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
                Console.WriteLine(location.ToString());
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
                return false;/*
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
            }*/
            return true;

        }
        private void Speichern()
        {
            Profil[0] = lbInhaber.Location;
            Profil[1] = lbStatus.Location;
            Profil[2] = lbGeburtstag.Location;
            Profil[3] = pcBProfil.Location;
            Profil[4] = lbAbteilung.Location;
            Profil[5] = lbEmail.Location;
            Profil[6] = lbHobby.Location;
            Profil[7] = lbTelefon.Location;
            angemeldet.SetProfil(Profil);
            angemeldet.SetProfilbild(Bild);
        }


        private void txBTelefon_TextChanged(object sender, EventArgs e)
        {
            angemeldet.SetTelefon(txBTelefon.Text);
            lbTelefon.Text = "telefon-nbr.:"+txBTelefon.Text;
        }

        private void txBAbteilung_TextChanged(object sender, EventArgs e)
        {
            angemeldet.SetAbteilung(txBAbteilung.Text);
            lbAbteilung.Text = "work: "+txBAbteilung.Text;
        }

        private void txBHobbys_TextChanged(object sender, EventArgs e)
        {
            angemeldet.SetHobby(txBHobbys.Text);
            lbHobby.Text = "Hobbies: "+txBHobbys.Text;
        }

        private void txBEmail_TextChanged(object sender, EventArgs e)
        {
            angemeldet.SetEmail(txBEmail.Text);
            lbEmail.Text = "E-Mail-adress: "+txBEmail.Text;
        }

        private void ProfilAnzeige_FormClosing(object sender, FormClosingEventArgs e)
        {
            Speichern();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verwaltung.Konto_Loschen();
        }

        private void rbtMann_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbtMann.Checked) return;
            angemeldet.SetGeschlecht(true);
            rbtFrau.Checked = false;
            Inhaber();
        }

        private void rbtFrau_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbtFrau.Checked) return;
            angemeldet.SetGeschlecht(false);
            rbtMann.Checked = false;
            Inhaber();
        }

        private void Beenden_Label_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
