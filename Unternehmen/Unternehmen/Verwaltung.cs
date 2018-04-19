using System.IO;
using System.Windows.Forms;

namespace Unternehmen
{
    public partial class Verwaltung : Form
    {
        private Konto angemeldete_Person;
        private Firma firma;
        private Login login;
        private Registrieren registrieren;
        private Menue menue;
        private Messenger messenger;
        private Kalender kalender;
        private static string Pfad = Directory.GetCurrentDirectory() + @"\Speichern.txt";
        
        public Verwaltung()
        {
            if (!File.Exists(Pfad))
                (new Firma()).Speichern(Pfad);
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
            InitializeComponent();
            firma = (new Firma()).Laden(Pfad);
            LogIn();
        }
        public Firma GetFirma() => firma;
        public Konto GetAngemeldetePerson() => angemeldete_Person;
        public void LogIn()
        {
            if (login != null) { login.Show(); return; }
            login = new Login(this);
            login.FormClosed += Login_FormClosed;
            login.Show();
        }
        public void Registrieren()
        {
            login.Hide();
            if (registrieren != null) { registrieren.Show(); return; }
            registrieren = new Registrieren(this);
            registrieren.FormClosed += Registrieren_FormClosed;
            registrieren.Show();
        }
        public void SetAngemeldetePerson(Konto Person) => angemeldete_Person = Person;
        public void Menue()
        {
            if (menue != null) { menue.Show(); return; }
            login.Hide();
            menue = new Menue(this);
            menue.FormClosing += Menue_FormClosing;
            menue.Show();
        }
        public void Kalender()
        {
            if (kalender != null) { kalender.Show(); return; }
            kalender = new Kalender(this,false);
            kalender.FormClosing += Kalender_FormClosing;
            kalender.Show();

        }

        private void Kalender_FormClosing(object sender, FormClosingEventArgs e)
        {
            kalender = null;
        }

        public void Messenger()
        {
            if (messenger != null) { messenger.Show(); return; }
            messenger = new Messenger(this);
            messenger.FormClosing += Messenger_FormClosing;
            messenger.Show();
        }

        private void Messenger_FormClosing(object sender, FormClosingEventArgs e)
        {
            messenger = null;
        }

        public void Andern()
        {
            if (registrieren != null) { registrieren.Show(); return; }
            registrieren = new Registrieren(this,angemeldete_Person);
            registrieren.FormClosed += Registrieren2_FormClosed;
            registrieren.Show();
        }

        private void Registrieren2_FormClosed(object sender, FormClosedEventArgs e)
        {
            registrieren = null;
        }

        private void Menue_FormClosing(object sender, FormClosingEventArgs e)
        {
            menue = null;
            angemeldete_Person = null;
            LogIn();
        }

        private void Registrieren_FormClosed(object sender, FormClosedEventArgs e)
        {
            registrieren = null;
            LogIn();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            login = null;
            firma.Speichern(Pfad);
            Close();
        }
        public void Konto_Loschen()
        {
            firma.Mitarbeiter_feuern(angemeldete_Person);
            registrieren.Close();
            menue.Close();
        }
    }
}
