using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Unternehmen
{
    public partial class Tag : Form
    {
        Verwaltung verwaltung;
        private DateTime tag;
        bool Chef;
        private List<Termin> termins;
        public Tag(Verwaltung verwaltung,DateTime Tag, bool Chef)
        {
            this.verwaltung = verwaltung;
            termins = new List<Termin>();
            tag = Tag;
            this.Chef = Chef;
            InitializeComponent();
            Laden();
            LadenTagesplan();
        }

        private void LadenTagesplan()
        {
           for(int f = 0; f < verwaltung.GetAngemeldetePerson().GetTerminAnzahl(); f++)
                LBTagesplan.Items.Add(verwaltung.GetAngemeldetePerson().GetTerminVon(f).ToShortDateString()+", "+verwaltung.GetAngemeldetePerson().GetTerminVon(f).ToShortTimeString() + "-" +verwaltung.GetAngemeldetePerson().GetTerminBis(f).ToShortDateString() +", "+ verwaltung.GetAngemeldetePerson().GetTerminBis(f).ToShortTimeString());
            LBTagesplan.Items.Add("new event");
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
            txBGNtz.Text = verwaltung.GetFirma().GetNotiz(tag);
            if (Chef)
            {
                txBeFeiertag.Visible = true;
                txBeFeiertag.Text = verwaltung.GetFirma().GetFeirtagname(tag);
                chBeFeiertag.Checked = verwaltung.GetFirma().GetFeirtagname(tag) != null;
                chBeFeiertag.Visible = true;
                chBLUrlaub.Visible = true;
                for (int f = 0; f < verwaltung.GetFirma().Urlaubliste(tag).Length; f++)
                    chBLUrlaub.Items.Add(verwaltung.GetFirma().Urlaubliste(tag)[f]);
                lbFeiertag.Visible = false;
                txBNotizen.Visible = false;
                label4.Visible = false;
            }
        }
        private void Speichern()
        {
            verwaltung.GetAngemeldetePerson().SetNotizen(txBNotizen.Text, tag);
            if (Chef)
                verwaltung.GetFirma().SetNotizen(txBGNtz.Text, tag);
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
            for (int f = 0; f < termins.Count; f++)
                termins[f].Close();
        }

        private void chBeFeiertag_CheckedChanged(object sender, EventArgs e)
        {
            if (chBeFeiertag.Checked) 
                verwaltung.GetFirma().SetFeiertag(tag, txBeFeiertag.Text);
            else
                verwaltung.GetFirma().DeleteFeiertag(tag);
        }

        private void txBeFeiertag_TextChanged(object sender, EventArgs e)
        {
            if(chBeFeiertag.Checked)
                verwaltung.GetFirma().SetFeiertag(tag, txBeFeiertag.Text);
        }

        private void chBLUrlaub_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Unchecked)
                verwaltung.GetFirma().UrlaubDeleten(tag, e.Index);
        }

        private void LBTagesplan_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (LBTagesplan.IndexFromPoint(e.Location) != ListBox.NoMatches)
            {
                if (LBTagesplan.IndexFromPoint(e.Location) == LBTagesplan.Items.Count - 1)
                    termins.Add(new Termin(verwaltung, -1));
                else
                    termins.Add(new Termin(verwaltung, LBTagesplan.IndexFromPoint(e.Location)));
                termins[termins.Count - 1].MdiParent = this;
                termins[termins.Count - 1].Dock = DockStyle.Fill;
                termins[termins.Count - 1].Show();
                termins[termins.Count - 1].FormClosing += Tag_FormClosing1; 
            }
        }

        private void Tag_FormClosing1(object sender, FormClosingEventArgs e)
        {
            LBTagesplan.Items.Clear();
            LadenTagesplan();
        }
    }
}
