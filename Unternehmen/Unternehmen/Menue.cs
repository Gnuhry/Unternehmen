using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            StatusAbfrage();
            if (verwaltung.GetFirma().GetWeb() == "none") btnWebsite.Visible = false;
            if (verwaltung.GetAngemeldetePerson().GetStatus() == "Anwesend")
                btnAnwesend.Enabled = false;
            else
                btnGehen.Enabled = false;
            numKrankentage.Value = verwaltung.GetAngemeldetePerson().GetKrankentage();
        }

        private void btnKalender_Click(object sender, EventArgs e)
        {
            verwaltung.Kalender();
        }

        private void btnMessenger_Click(object sender, EventArgs e)
        {
            verwaltung.Messenger();
        }

        private void btnAnwesend_Click(object sender, EventArgs e)
        {
            btnGehen.Enabled = true;
            btnAnwesend.Enabled = false;
            verwaltung.GetAngemeldetePerson().Anwesend();
            StatusAbfrage();
        }

        private void btnGehen_Click(object sender, EventArgs e)
        {
            btnGehen.Enabled = false;
            btnAnwesend.Enabled = true;
            verwaltung.GetAngemeldetePerson().Gehen();
            StatusAbfrage();
        }

        private void btnZeiten_Click(object sender, EventArgs e)
        {
            MessageBox.Show(verwaltung.GetAngemeldetePerson().GetZeiten());
        }

        private void btnKrankentage_Click(object sender, EventArgs e)
        {
            verwaltung.GetAngemeldetePerson().SetKrankentage((int)numKrankentage.Value);
            StatusAbfrage();
            for (int f = 0; f < (int)numKrankentage.Value; f++)
                verwaltung.GetFirma().Uerberprufung(DateTime.Today.AddDays(f));
        }


        private void btnWebsite_Click(object sender, EventArgs e)
        {
            Process.Start(verwaltung.GetFirma().GetWeb());
        }

        private void btnAndern_Click(object sender, EventArgs e)
        {
            verwaltung.Andern();
        }
        private void StatusAbfrage()
        {
            lbStatus.Text = verwaltung.GetAngemeldetePerson().GetStatus();
        }
    }
}
