using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unternehmen
{
    public partial class Registrieren : Form
    {
        Verwaltung verwaltung;
        Konto angemeldet;
        public Registrieren(Verwaltung verwaltung)
        {
            this.verwaltung = verwaltung;
            InitializeComponent();
        }
        public Registrieren(Verwaltung verwaltung, Konto angemeldet)
        {
            this.verwaltung = verwaltung;
            InitializeComponent();
            this.angemeldet = angemeldet;
            txBPasswortA.Visible = true;
            txBInhaber.Text = angemeldet.GetKontoInhaber();
            txBBenutzername.Text = angemeldet.GetBenutzername();
            numDay.Value = angemeldet.GetGeburtstag().Day;
            numMonth.Value = angemeldet.GetGeburtstag().Month;
            numYear.Value = angemeldet.GetGeburtstag().Year;
            btnLoschen.Visible = true;
        }


        private void btnRegistrieren_Click(object sender, EventArgs e)
        {
            if (angemeldet == null)
            {
                angemeldet = new Konto();
            }
            else
            {
                if (angemeldet.Login(angemeldet.GetBenutzername(), txBPasswortA.Text) != 0) { MessageBox.Show("Altes Passwort stimmt nicht"); return; }
            }
            if (txBInhaber.Text.Trim() == null || txBInhaber.Text.Trim() == "") { MessageBox.Show("Kein Inhaber"); return; }
            if (txBBenutzername.Text.Trim() == null || txBBenutzername.Text.Trim() == "") { MessageBox.Show("Keinen Benutzernamen"); return; }
            if (txBPasswort.Text.Trim() == null || txBPasswort.Text.Trim() == "") { MessageBox.Show("Kein Passwort"); return; }
            if (txBPasswort.Text != txBPasswort2.Text) { MessageBox.Show("Passwörter überstimmen nicht ein"); return; }
            string temp;
            try
            {
                temp = angemeldet.Registrieren(txBInhaber.Text, txBBenutzername.Text, txBPasswort.Text, new DateTime((int)numYear.Value, (int)numMonth.Value, (int)numMonth.Value));
            }
            catch (Exception) { temp = "Falsches Datum"; }
            if (temp == "")
            {
                verwaltung.GetFirma().AddMitarbeiter(angemeldet);
                Close();
            }
            else
                MessageBox.Show(temp);       
        }

        private void btnLoschen_Click(object sender, EventArgs e)
        {
            verwaltung.Konto_Loschen();
        }
    }
}
