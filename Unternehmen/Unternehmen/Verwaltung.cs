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
        private Menue_standart menue_Standart;
        private Admin chef;
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
            menue_standart();
            menue.Show();
        }

        public void Chef()
        {
            if (firma.GetMitarbeiter(0) != angemeldete_Person) return;
            if (chef != null) { chef.Show(); return; }
            chef = new Admin(this);
            chef.MdiParent = menue;
            chef.Dock = DockStyle.Fill;
            chef.FormClosing += Chef_FormClosing;
            chef.Show();
        }
        public void menue_standart()
        {
            if (menue_Standart != null) { menue_Standart.Show(); return; }
            SchliesenMenues();
            menue_Standart = new Menue_standart(this);
            menue_Standart.MdiParent = menue;
            menue_Standart.Dock = DockStyle.Fill;
            menue_Standart.FormClosing += Menue_Standart_FormClosing;
            menue_Standart.Show();
        }

        private void Menue_Standart_FormClosing(object sender, FormClosingEventArgs e)
        {
            menue_Standart = null;
        }

        private void Chef_FormClosing(object sender, FormClosingEventArgs e)
        {
            chef = null;
        }

        public void Kalender()
        {
            if (kalender != null) { kalender.Show(); return; }
            SchliesenMenues();
            kalender = new Kalender(this,false);
            kalender.MdiParent = menue;
            kalender.Dock = DockStyle.Fill;
            kalender.FormClosing += Kalender_FormClosing;
            kalender.Show();

        }

        private void SchliesenMenues()
        {
            for (int f = 0; f < menue.MdiChildren.Length; f++)
                if (menue.MdiChildren[f].Visible == true)
                {
                    Form temp = menue.MdiChildren[f];
                    temp.MdiParent = null;
                    temp.Close();       
                }
        }

        private void Kalender_FormClosing(object sender, FormClosingEventArgs e)
        {
            kalender = null;
        }
        

        public void Messenger()
        {
            if (messenger != null) { messenger.Show(); return; }
            SchliesenMenues();
            messenger = new Messenger(this,false);
            messenger.MdiParent = menue;
            messenger.Dock = DockStyle.Fill;
            messenger.FormClosing += Messenger_FormClosing;
            messenger.Show();
        }
        public void Postfach()
        {
            if (messenger != null) { messenger.Show(); return; }
            SchliesenMenues();
            messenger = new Messenger(this, true);
            messenger.MdiParent = menue;
            messenger.Dock = DockStyle.Fill;
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
            SchliesenMenues();
            registrieren = new Registrieren(this,angemeldete_Person);
            registrieren.MdiParent = menue;
            registrieren.Dock = DockStyle.Fill;
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
            if(messenger!=null)
            messenger.Close();
            if(kalender!=null)
            kalender.Close();
            if(chef!=null)
            chef.Close();
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
