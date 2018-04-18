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
    public partial class Tag : Form
    {
        Verwaltung verwaltung;
        private DateTime tag;
        public Tag(Verwaltung verwaltung,DateTime Tag)
        {
            this.verwaltung = verwaltung;
            tag = Tag;
            InitializeComponent();
            Laden();
        }

        private void Laden()
        {
            btnZuruck.Enabled = true;
            if (tag == DateTime.Today)
                btnZuruck.Enabled = false;
            txBNotizen.Text = txBGNtz.Text = lbFeiertag.Text = lbGeburtstag.Text = lbKrank.Text = lbUrlaub.Text = lbWochentag.Text = "";
            for (int f = 0; f < verwaltung.GetFirma().Urlaubliste(tag).Length; f++)
                lbUrlaub.Text += verwaltung.GetFirma().Urlaubliste(tag)[f]+"\n";
            for (int f = 0; f < verwaltung.GetFirma().Krankenliste(tag).Length; f++)
                lbKrank.Text += verwaltung.GetFirma().Krankenliste(tag)[f] + "\n";
            for (int f = 0; f < verwaltung.GetFirma().Geburtstagliste(tag).Length; f++)
                lbGeburtstag.Text += verwaltung.GetFirma().Geburtstagliste(tag)[f]+"\n";
            lbWochentag.Text = tag.ToShortDateString();
            lbFeiertag.Text = verwaltung.GetFirma().GetFeirtagname(tag);
            txBNotizen.Text = verwaltung.GetAngemeldetePerson().GetNotiz(tag);
        }
        private void Speichern()
        {
            verwaltung.GetAngemeldetePerson().SetNotizen(txBNotizen.Text, tag);
        }
       
        private void btnVor_Click(object sender, EventArgs e)
        {
            Speichern();
            tag=tag.AddDays(1);
            Laden();
        }

        private void btnZuruck_Click(object sender, EventArgs e)
        {
            Speichern();
            tag=tag.AddDays(-1);
            Laden();
        }

        private void Tag_FormClosing(object sender, FormClosingEventArgs e)
        {
            Speichern();
        }
    }
}
