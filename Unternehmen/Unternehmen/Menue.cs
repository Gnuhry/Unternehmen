using System;
using System.Diagnostics;
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
            verwaltung.menue_standart();
        }

        private void btnKalender_Click(object sender, EventArgs e)
        {
            verwaltung.Kalender();
        }

        private void btnMessenger_Click(object sender, EventArgs e)
        {
            verwaltung.Messenger();
        }

       


        private void btnWebsite_Click(object sender, EventArgs e)
        {
            Process.Start(verwaltung.GetFirma().GetWeb());
        }

        private void btnAndern_Click(object sender, EventArgs e)
        {
            verwaltung.Andern();
        }
       

        private void Beenden_Button_Click(object sender, EventArgs e)
        {
            Beenden_Button.Enabled = false;
            Close();
        }

        private void btnMenue_Click(object sender, EventArgs e)
        {
            verwaltung.menue_standart();
        }
    }
}
