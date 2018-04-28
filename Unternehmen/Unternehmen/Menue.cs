using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
//948;585
namespace Unternehmen
{
    public partial class Menue : Form
    {
        Verwaltung verwaltung;
        public Menue(Verwaltung verwaltung)
        {
            InitializeComponent();
            this.verwaltung = verwaltung;
            if (verwaltung.GetFirma().GetWeb() == "none") btnWebsite.Visible = false;
            if (verwaltung.GetAngemeldetePerson() == verwaltung.GetFirma().GetMitarbeiter(0)||verwaltung.GetFirma().IsKonto(verwaltung.GetAngemeldetePerson())) { btnAdmin.Visible =btnAdminKalender.Visible=btnAdminPostfach.Visible= true; }
            Menue_Aktualisieren();
            timer.Enabled = true;
            timer.Start();
        }
        private void btnKalender_Click(object sender, EventArgs e)
        {
            pnAktivAktualisieren(sender as Control);
            Aktive_Form_Name.Text = "Calendar";
            verwaltung.Kalender();
        }

        private void btnMessenger_Click(object sender, EventArgs e)
        {
            pnAktivAktualisieren(sender as Control);
            Aktive_Form_Name.Text = "Messenger";
            verwaltung.Messenger();
        }
        private void btnWebsite_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(verwaltung.GetFirma().GetWeb());
            }
            catch (Exception)
            {
                MessageBox.Show("Es gibt einen Fehler! Wenden sie ich an den Admin!");
                Konto temp = new Konto();
                temp.Registrieren("System", "System", "System01", DateTime.Today, null,true, true);
                verwaltung.GetFirma().ReciveAdminNachricht("Fehler 01-Web", null, temp);
            }
        }

        private void btnAndern_Click(object sender, EventArgs e)
        {
            pnAktivAktualisieren(sender as Control);
            Aktive_Form_Name.Text = "Edit profile";
            verwaltung.ProfilAnzeige();
        }
       

        private void Beenden_Button_Click(object sender, EventArgs e)
        {
            Beenden_Button.Enabled = false;
            Close();
        }

        private void btnMenue_Click(object sender, EventArgs e)
        {
            pnAktivAktualisieren(sender as Control);
            Aktive_Form_Name.Text = "Dashboard";
            verwaltung.Menue_standart();
        }
        private void pnAktivAktualisieren(Control sender)
        {
            // MessageBox.Show(48 * index - pnAktiv.Location.Y + "");
            pnAktiv.Location = sender.Location;
           // Point temp = pnAktiv.Location;
             //temp.Offset(0, 48 * index - pnAktiv.Location.Y);
            //pnAktiv.Location = temp;
           // MessageBox.Show(pnAktiv.Location.ToString());
            //pnAktiv.Location.Offset(0, 48 * index - pnAktiv.Location.Y);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            pnAktivAktualisieren(sender as Control);
            Aktive_Form_Name.Text = "Admin Dashboard";
            verwaltung.Chef();
        }

        private void btnAdminKalender_Click(object sender, EventArgs e)
        {
            pnAktivAktualisieren(sender as Control);
            Aktive_Form_Name.Text = "Admin Calendar";
            verwaltung.AdminKalender();
        }

        private void btnAdminPostfach_Click(object sender, EventArgs e)
        {
            pnAktivAktualisieren(sender as Control);
            Aktive_Form_Name.Text = "Admin Messages";
            verwaltung.Postfach();
        }
        public void WebsiteAktualisieren()
        {
            btnWebsite.Visible = verwaltung.GetFirma().GetWeb() != "none";
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = verwaltung.Bewegen_MouseDown(e);
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            verwaltung.Bewegen_MouseMove(this);
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = verwaltung.Bewegen_MouseUp();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lbNow.Text = DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToLongDateString();
        }

        private void Menue_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Enabled = false;
            timer.Stop();
        }
        public void Menue_Aktualisieren()
        {
            Firmenlogo_pictureBox.Image = verwaltung.GetFirma().GetFirmenLogo();
            pcBProfil.Image = verwaltung.GetAngemeldetePerson().GetProfilbild();
            if (verwaltung.GetAngemeldetePerson().Geschlecht1) lbName.Text = "Mr." + verwaltung.GetAngemeldetePerson().GetKontoInhaber();
            else lbName.Text = "Ms." + verwaltung.GetAngemeldetePerson().GetKontoInhaber();
        }
    }
}
