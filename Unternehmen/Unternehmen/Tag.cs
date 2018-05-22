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
        private Termin termins;
        public Tag(Verwaltung verwaltung,DateTime Tag, bool Chef)
        {
            this.verwaltung = verwaltung;
            tag = Tag;
            this.Chef = Chef;
            InitializeComponent();
            Laden();
            LadenTagesplan();
        }

        private void LadenTagesplan()
        {
            LBTagesplan.Items.Clear();/*
           for(int f = 0; f < verwaltung.GetAngemeldetePerson().GetTerminAnzahl(); f++)
                if(tag.Date>=verwaltung.GetAngemeldetePerson().GetTerminVon(f).Date&& tag.Date < verwaltung.GetAngemeldetePerson().GetTerminBis(f).Date)
                LBTagesplan.Items.Add(verwaltung.GetAngemeldetePerson().GetTerminVon(f).ToShortDateString()+", "+verwaltung.GetAngemeldetePerson().GetTerminVon(f).ToShortTimeString() + "-" +verwaltung.GetAngemeldetePerson().GetTerminBis(f).ToShortDateString() +", "+ verwaltung.GetAngemeldetePerson().GetTerminBis(f).ToShortTimeString());
            */
            string[] temp = verwaltung.GetAngemeldetePerson().GetTerminAnzeige(tag);
            for (int f = 0; f < temp.Length; f++)
                LBTagesplan.Items.Add(temp[f].Split(';')[0]);
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
            lbWochentag.Text = tag.DayOfWeek+" "+tag.ToShortDateString();
            lbFeiertag.Text = verwaltung.GetFirma().GetFeirtagname(tag);
            txBNotizen.Text = verwaltung.GetAngemeldetePerson().GetNotiz(tag);
            txBGNtz.Text = verwaltung.GetFirma().GetNotiz(tag);
            if (Chef)
            {
                txBeFeiertag.Visible = chBeFeiertag.Visible = chBLUrlaub.Visible = true;
                txBeFeiertag.Text = verwaltung.GetFirma().GetFeirtagname(tag);
                Console.WriteLine("IsFeiertag: " + verwaltung.GetFirma().IsFeiertag(tag)+","+verwaltung.GetFirma().GetFeirtagname(tag)+",");
                chBeFeiertag.Checked = verwaltung.GetFirma().IsFeiertag(tag);
                for (int f = 0; f < verwaltung.GetFirma().Urlaubliste(tag).Length; f++)
                    chBLUrlaub.Items.Add(verwaltung.GetFirma().Urlaubliste(tag)[f], true);
                lbUrlaub.Visible = label4.Visible = txBNotizen.Visible = lbFeiertag.Visible = btnLogin.Visible = false;
                if (verwaltung.GetFirma().IsFeiertagAnderbar(tag))
                {
                    chBeFeiertag.Enabled = txBeFeiertag.Enabled = true;
                }
                else
                    chBeFeiertag.Enabled = txBeFeiertag.Enabled = false;
            }
            else
            {
                btnLogin.Text = "Urlaub beantragen";
                if (verwaltung.GetFirma().IsFeiertag(tag)) btnLogin.Text = "Urlaub entfernen";
                switch (tag.DayOfWeek)
                {
                    case DayOfWeek.Monday: if (!verwaltung.GetFirma().GetArbeitstag(0)) btnLogin.Text = "Urlaub entfernen"; break;
                    case DayOfWeek.Tuesday: if (!verwaltung.GetFirma().GetArbeitstag(1)) btnLogin.Text = "Urlaub entfernen"; break;
                    case DayOfWeek.Wednesday: if (!verwaltung.GetFirma().GetArbeitstag(2)) btnLogin.Text = "Urlaub entfernen"; break;
                    case DayOfWeek.Thursday: if (!verwaltung.GetFirma().GetArbeitstag(3)) btnLogin.Text = "Urlaub entfernen"; break;
                    case DayOfWeek.Friday: if (!verwaltung.GetFirma().GetArbeitstag(4)) btnLogin.Text = "Urlaub entfernen"; break;
                    case DayOfWeek.Saturday: if (!verwaltung.GetFirma().GetArbeitstag(5)) btnLogin.Text = "Urlaub entfernen"; break;
                    case DayOfWeek.Sunday: if (!verwaltung.GetFirma().GetArbeitstag(6)) btnLogin.Text = "Urlaub entfernen"; break;
                }
                if (verwaltung.GetAngemeldetePerson().IsUrlaub(tag)) btnLogin.Text = "Urlaub entfernen";
            }
            LadenTagesplan();
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
            if(termins!=null)
                termins.Close();
        }

        private void chBeFeiertag_CheckedChanged(object sender, EventArgs e)
        {
            if (chBeFeiertag.Checked&&verwaltung.GetFirma().IsFeiertagAnderbar(tag)) 
                verwaltung.GetFirma().SetFeiertag(tag, txBeFeiertag.Text);
            else
                verwaltung.GetFirma().DeleteFeiertag(tag);
        }

        private void txBeFeiertag_TextChanged(object sender, EventArgs e)
        {
            if (chBeFeiertag.Checked && verwaltung.GetFirma().IsFeiertagAnderbar(tag))
            {
                verwaltung.GetFirma().SetFeiertag(tag, txBeFeiertag.Text);
            }
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
                if (termins != null) { termins.FormClosing -= Tag_FormClosing1;  termins.Close(); termins = null; }
                if (LBTagesplan.IndexFromPoint(e.Location) == LBTagesplan.Items.Count - 1)
                    termins=new Termin(verwaltung, -1,tag);
                else
                    termins=new Termin(verwaltung,Convert.ToInt32(verwaltung.GetAngemeldetePerson().GetTerminAnzeige(tag)[LBTagesplan.IndexFromPoint(e.Location)].Split(';')[1]),tag);
                termins.MdiParent = this;
                termins.Dock = DockStyle.Fill;
                termins.Show();
                termins.FormClosing += Tag_FormClosing1; 
            }
        }

        private void Tag_FormClosing1(object sender, FormClosingEventArgs e)
        {
            termins = null;
            LBTagesplan.Items.Clear();
            LadenTagesplan();
        }

        private void Beenden_Label_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (btnLogin.Text == "Urlaub beantragen")
                verwaltung.GetFirma().Urlaub_beantragen(tag, verwaltung.GetAngemeldetePerson());
            else
                verwaltung.GetAngemeldetePerson().RemoveUrlaub(tag);
            Laden();
        }
    }
}
