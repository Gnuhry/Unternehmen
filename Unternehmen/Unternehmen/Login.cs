using System;
using System.Drawing;
using System.Windows.Forms;

namespace Unternehmen
{
    public partial class Login : Form
    {
        Verwaltung verwaltung;
        public Login(Verwaltung verwaltung)
        {
            InitializeComponent();
            this.verwaltung = verwaltung;
            Logo_Picturebox.Image = verwaltung.GetFirma().GetFirmenLogo();
            Firmen_Motto.Text = verwaltung.GetFirma().Firmenstatus1;
            lbFehlermeldung.Text = null;
        }
        public void MottoAktualisieren()
        {
            Logo_Picturebox.Image = verwaltung.GetFirma().GetFirmenLogo();
            Firmen_Motto.Text = verwaltung.GetFirma().Firmenstatus1;
            lbFehlermeldung.Text=txBbenutzername.Text = txBpasswort.Text = null;
        }

        private void btnRegistrieren_Click(object sender, EventArgs e)
        {
            verwaltung.Registrieren();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           switch( verwaltung.GetFirma().Einloggen(txBbenutzername.Text, txBpasswort.Text,verwaltung))
            {
                case 0: verwaltung.Menue(); break;
                case -1: lbFehlermeldung.Text="wrong username"; break;
                case -2: lbFehlermeldung.Text="wrong password"; break;
                case -3: lbFehlermeldung.Text="Account is locked, please contact an administrator"; break;
            }
            txBpasswort.Text = txBbenutzername.Text = null;
        }

        private void txBpasswort_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) btnLogin_Click(sender, e);
        }

        private void Beenden_Label_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Panel_Left_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor=verwaltung.Bewegen_MouseDown(e);
        }

        private void Panel_Right_MouseMove(object sender, MouseEventArgs e)
        {
            verwaltung.Bewegen_MouseMove(this);
        }

        private void Panel_Left_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor=verwaltung.Bewegen_MouseUp();
        }
    }
}
