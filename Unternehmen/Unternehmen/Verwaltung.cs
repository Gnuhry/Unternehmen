using System;
using System.Drawing;
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
        private Messenger messenger,amessenger;
        private Kalender kalender,akalender;
        private Menue_standart menue_Standart;
        private Admin chef;
        private static string Pfad = Directory.GetCurrentDirectory() + @"\Speichern.txt";
        private Control activeControl;
        private Point previousPosition;
        private ProfilAnzeige profilAnzeige;

        public Verwaltung()
        {
            if (!File.Exists(Pfad))
                (new Firma()).Speichern(Pfad);
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
            InitializeComponent();
            firma = (new Firma()).Laden(Pfad);



            Konto x = new Konto();
            x.Registrieren("Admin", "Admin", "Admin1", DateTime.Today, null, true);
            firma.AddMitarbeiter(x);

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
            Menue_standart();
            menue.Show();
        }

        public void Chef()
        {
            if (chef != null) { chef.Show(); return; }
            SchliesenMenues();
            chef = new Admin(this)
            {
                MdiParent = menue,
                Dock = DockStyle.Fill
            };
            chef.FormClosing += Chef_FormClosing;
            chef.Show();
        }
        public void Menue_standart()
        {
            if (menue_Standart != null) { menue_Standart.Show(); return; }
            SchliesenMenues();
            menue_Standart = new Menue_standart(this)
            {
                MdiParent = menue,
                Dock = DockStyle.Fill
            };
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
            firma.Speichern(Pfad);
        }

        public void AdminKalender()
        {
            if (akalender != null) { akalender.Show(); return; }
            SchliesenMenues();
            akalender = new Kalender(this, true)
            {
                MdiParent = menue,
                Dock = DockStyle.Fill
            };
            akalender.FormClosing += Akalender_FormClosing;
            akalender.Show();

        }

        private void Akalender_FormClosing(object sender, FormClosingEventArgs e)
        {
            akalender = null;
        }

        public void Kalender()
        {
            if (kalender != null) { kalender.Show(); return; }
            SchliesenMenues();
            kalender = new Kalender(this, false)
            {
                MdiParent = menue,
                Dock = DockStyle.Fill
            };
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
            messenger = new Messenger(this, false)
            {
                MdiParent = menue,
                Dock = DockStyle.Fill
            };
            messenger.FormClosing += Messenger_FormClosing;
            messenger.Show();
        }
        public void Postfach()
        {
            if (amessenger != null) { amessenger.Show(); return; }
            SchliesenMenues();
            amessenger = new Messenger(this, true)
            {
                MdiParent = menue,
                Dock = DockStyle.Fill
            };
            amessenger.FormClosing += Amessenger_FormClosing;
            amessenger.Show();
        }

        private void Amessenger_FormClosing(object sender, FormClosingEventArgs e)
        {
            amessenger = null;
        }

        private void Messenger_FormClosing(object sender, FormClosingEventArgs e)
        {
            messenger = null;
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
            login.MottoAktualisieren();
        }
        public void ProfilAnzeige()
        {
            if (profilAnzeige != null) { profilAnzeige.Show();return; }
            SchliesenMenues();
            profilAnzeige = new ProfilAnzeige(this)
            {
                MdiParent = menue,
                Dock = DockStyle.Fill
            };
            profilAnzeige.FormClosing += ProfilAnzeige_FormClosing;
            profilAnzeige.Show();
        }

        private void ProfilAnzeige_FormClosing(object sender, FormClosingEventArgs e)
        {
            profilAnzeige = null;
        }

        private void Registrieren_FormClosed(object sender, FormClosedEventArgs e)
        {
            registrieren = null;
            firma.Speichern(Pfad);
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
        public Cursor Bewegen_MouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                activeControl = new Control();
                previousPosition = e.Location;
                return Cursors.Hand;
            }
            return Cursors.Default;
        }


        public void Bewegen_MouseMove(Form form)
        {
            if (activeControl == null) return;
            form.SetDesktopLocation(MousePosition.X - previousPosition.X, MousePosition.Y - previousPosition.Y);
        }

        public Cursor Bewegen_MouseUp()
        {
            activeControl = null;
            return Cursors.Default;
        }
    }
}
