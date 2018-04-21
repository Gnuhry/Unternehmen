using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

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
            if (verwaltung.GetAngemeldetePerson() == verwaltung.GetFirma().GetMitarbeiter(0)) btnAdmin.Visible = true;
            Firmenlogo_pictureBox.Image = verwaltung.GetFirma().GetFirmenLogo();
        }
        private void btnKalender_Click(object sender, EventArgs e)
        {
            pnAktivAktualisieren(1);
            verwaltung.Kalender();
        }

        private void btnMessenger_Click(object sender, EventArgs e)
        {
            pnAktivAktualisieren(3);
            verwaltung.Messenger();
        }
        private void btnWebsite_Click(object sender, EventArgs e)
        {
            Process.Start(verwaltung.GetFirma().GetWeb());
        }

        private void btnAndern_Click(object sender, EventArgs e)
        {
            pnAktivAktualisieren(2);
            verwaltung.Andern();
        }
       

        private void Beenden_Button_Click(object sender, EventArgs e)
        {
            Beenden_Button.Enabled = false;
            Close();
        }

        private void btnMenue_Click(object sender, EventArgs e)
        {
            pnAktivAktualisieren(0);
            verwaltung.Menue_standart();
        }
        private void pnAktivAktualisieren(int index)
        {
           // MessageBox.Show(48 * index - pnAktiv.Location.Y + "");
             pnAktiv.Location = new Point(0,48*index);
           // pnAktiv.Location.Offset(0, 48 * index - pnAktiv.Location.Y);
           // MessageBox.Show(pnAktiv.Location.ToString());
            //pnAktiv.Location.Offset(0, 48 * index - pnAktiv.Location.Y);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            pnAktivAktualisieren(10);
            verwaltung.Chef();
        }

        private void btnAdminKalender_Click(object sender, EventArgs e)
        {
            pnAktivAktualisieren(9);
            verwaltung.AdminKalender();
        }

        private void btnAdminPostfach_Click(object sender, EventArgs e)
        {
            pnAktivAktualisieren(8);
            verwaltung.Postfach();
        }
    }
}
