using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Unternehmen
{
    public partial class Menue_standart : Form
    {
        Verwaltung verwaltung;
        public Menue_standart(Verwaltung verwaltung)
        {
            this.verwaltung = verwaltung;
            InitializeComponent();
            StatusAbfrage();
            if (verwaltung.GetAngemeldetePerson().GetStatus() == "present")
                btnAnwesend.Enabled = false;
            else
                btnGehen.Enabled = false;
            numKrankentage.Value = verwaltung.GetAngemeldetePerson().GetKrankentage();
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
        private void StatusAbfrage()
        {
            lbStatus.Text = verwaltung.GetAngemeldetePerson().GetStatus();
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
            verwaltung.GetFirma().ReciveAdminNachricht("-Automatische Nachricht-\nKrankenbescheinigung von " + verwaltung.GetAngemeldetePerson().GetKontoInhaber() + "\n für " + numKrankentage.Value + " Tage", pcBBescheinigung.Image, verwaltung.GetAngemeldetePerson());
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            verwaltung.Chef();
        }


        private void btnBescheinigung_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = "c:\\",
                Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                        using (myStream)
                        {
                            pcBBescheinigung.Image = new Bitmap(myStream);
                            btnKrank.Enabled = true;
                        }
                            
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
        }
    }
}
