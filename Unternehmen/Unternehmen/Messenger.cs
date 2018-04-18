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
    public partial class Messenger : Form
    {
        Verwaltung verwaltung;
        List<NachrichtAnzeige> nachrichtAnzeiges;
        public Messenger(Verwaltung verwaltung)
        {
            nachrichtAnzeiges = new List<NachrichtAnzeige>();
            InitializeComponent();
            this.verwaltung = verwaltung;
            for(int f = 0; f < verwaltung.GetFirma().GetMitarbeiterAnzahl(); f++)
            {
                comBEmpfanger.Items.Add(verwaltung.GetFirma().GetMitarbeiter(f).GetKontoInhaber());
            }
            NachrichtenLaden();
        }

        private void NachrichtenLaden()
        {
            if (verwaltung.GetAngemeldetePerson().GetNachrichtenAnzahl() != 0)
            {
                for (int f = 0; f < verwaltung.GetAngemeldetePerson().GetNachrichtenAnzahl(); f++)
                {
                    lBoxNachrichten.Items.Add(verwaltung.GetAngemeldetePerson().GetAnhang(f));
                }
                lBoxNachrichten.MouseDown += LBoxNachrichten_MouseDown;
                lBoxNachrichten.MouseDoubleClick += LBoxNachrichten_MouseDoubleClick;
            }
            else
            {
                lBoxNachrichten.Enabled = false;
            }
        }

        private void LBoxNachrichten_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int index = lBoxNachrichten.IndexFromPoint(e.Location);
                if (index != ListBox.NoMatches)
                {
                    comBEmpfanger.SelectedIndex = index;
                }
            }
        }

        private void LBoxNachrichten_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lBoxNachrichten.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                nachrichtAnzeiges.Add(new NachrichtAnzeige(index, verwaltung));
                nachrichtAnzeiges[nachrichtAnzeiges.Count - 1].Show();
                nachrichtAnzeiges[nachrichtAnzeiges.Count - 1].FormClosing += NachrichtAnzeiges_FormClosing;

            }
        }

        private void NachrichtAnzeiges_FormClosing(object sender, FormClosingEventArgs e)
        {
            lBoxNachrichten.Items.Clear();
            NachrichtenLaden();
        }

        private void btnSenden_Click(object sender, EventArgs e)
        {
            txBNachricht.Text = txBNachricht.Text.Trim();
            if (txBNachricht.Text != "" && txBNachricht.Text != null && comBEmpfanger.SelectedIndex > -1)
            {
                verwaltung.GetFirma().GetMitarbeiter(comBEmpfanger.SelectedIndex).ReciveNachricht(txBNachricht.Text, "nu", verwaltung.GetAngemeldetePerson());
                txBNachricht.Text = null;
            }
        }

        private void Messenger_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int f = 0; f < nachrichtAnzeiges.Count; f++) nachrichtAnzeiges[f].Close();
        }
    }
}
