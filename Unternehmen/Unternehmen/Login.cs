using System;
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
                case -1: MessageBox.Show("Konto existiert nicht"); break;
                case -2: MessageBox.Show("Falsche Passwort"); break;
                case -3: MessageBox.Show("Gesperrtes Konto, wenden Sie sich an den Admin"); break;
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
    }
}
