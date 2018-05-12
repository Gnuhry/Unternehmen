using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Unternehmen
{
    public partial class Kalender : Form
    {
        private bool Chef;
        private static int MaxJahre = 10;
        Verwaltung verwaltung;
        private Label[] Inhalt;
        private List<DateTime> Urlaubstage;
        private List<Tag> tage;
        private int Month, Year;
        private static string[] Monat = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        private static Color KrankentageC = Color.Orange, UrlaubstageC = Color.Red, VergangeneTageC = Color.LightGray, FeiertageC = Color.Green, BeantragenC = Color.Blue, keinArbeitstagC=Color.LightGray;
        private Control activeControl;
        private Point previousPosition;

        public Kalender(Verwaltung verwaltung, bool Chef)
        {
            this.Chef = Chef;
            tage = new List<Tag>();
            this.verwaltung = verwaltung;
            InitializeComponent();
            Urlaubstage = new List<DateTime>();
            Month = DateTime.Today.Month;
            Year = DateTime.Today.Year;
            Init();
            KalenderLaden();
        }
        

        private void KalenderLaden()
        {
            btnMonatzuruck.Enabled = true;
            if (Month == DateTime.Today.Month && Year == DateTime.Today.Year)
                btnMonatzuruck.Enabled = false;
            int erster = 0;
            switch ((new DateTime(Year, Month, 1)).DayOfWeek)
            {
                case DayOfWeek.Monday: erster = 0; break;
                case DayOfWeek.Tuesday: erster = 1; break;
                case DayOfWeek.Wednesday: erster = 2; break;
                case DayOfWeek.Thursday: erster = 3; break;
                case DayOfWeek.Friday: erster = 4; break;
                case DayOfWeek.Saturday: erster = 5; break;
                case DayOfWeek.Sunday: erster = 6; break;
            }
            if (DateTime.Today.Year == Year)
                try {
                    cBoxMonat.SelectedIndex = Month - DateTime.Today.Month; }
                catch (Exception) { }
            else
                cBoxMonat.SelectedIndex = Month - 1;
            cBoxJahr.SelectedIndex = Year - DateTime.Today.Year;
            //Leeren
            for (int f = 7; f < Inhalt.Length; f++)
            {
                Inhalt[f].Text = "";
                Inhalt[f].BackColor = Color.Transparent;
                Inhalt[f].MouseDown -= Inhalt_Click;
                Inhalt[f].Enabled = true;
            }
            //Füllen
            for (int f = erster + 7; f < DateTime.DaysInMonth(Year, Month) + erster + 7; f++)
            {
                Inhalt[f].Text = f - erster - 6 + "";
                Inhalt[f].MouseDown += Inhalt_Click;
            }
            //Abfangen
            if (Month == DateTime.Today.Month&&Year==DateTime.Today.Year)
                for (int f = erster + 7; f < DateTime.Today.Day + erster + 6; f++)
                {
                    Inhalt[f].BackColor =VergangeneTageC;
                    Inhalt[f].MouseDown -= Inhalt_Click;
                    Inhalt[f].Enabled = false;
                }
            Laden(erster+7);
            LadenGenemigteUrlaube(erster+7);
            LadenKrankenTage(erster + 7);
            LadenFeiertage(erster + 7, DateTime.DaysInMonth(Year, Month));
            LadenArbeitstage(erster + 7, DateTime.DaysInMonth(Year, Month));
        }

        private void Inhalt_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right&&!Chef)
            {
                if ((sender as Label).BackColor == BeantragenC) (sender as Label).BackColor = Color.Transparent;
                else if ((sender as Label).BackColor == Color.Transparent) (sender as Label).BackColor = BeantragenC;
            }
            else
            {
                tage.Add(new Tag(verwaltung, new DateTime(Year, Month, Convert.ToInt32((sender as Label).Text)),Chef));
                tage[tage.Count - 1].Show();
            }
        }

        private void btnMonatzuruck_Click(object sender, EventArgs e)
        {
            Speichern();
            if (--Month == 0)
            {
                Month = 12;
                Year--;
            }
            KalenderLaden();
        }

        private void Speichern()
        {
            for (int f = 0; f < Inhalt.Length; f++)
                if (Inhalt[f].Text == "1")
                    for (int g = f; g < Inhalt.Length; g++)
                        if (Inhalt[g].BackColor == BeantragenC)
                            if (!Urlaubstage.Contains(new DateTime(Year, Month, Convert.ToInt32(Inhalt[g].Text))))
                                Urlaubstage.Add(new DateTime(Year, Month, Convert.ToInt32(Inhalt[g].Text)));
        }
        private void Laden(int erster)
        {
            for (int f = 0; f < Urlaubstage.Count; f++)
                if (Urlaubstage[f].Month == Month && Urlaubstage[f].Year == Year)
                    Inhalt[erster + Urlaubstage[f].Day - 1].BackColor = BeantragenC;
        }

        private void Kalender_FormClosing(object sender, FormClosingEventArgs e)
        {
            for(int f = 0; f < tage.Count; f++)
                tage[f].Close();
        }

        private void LadenGenemigteUrlaube(int erster)
        {
            if (Chef) return;
            DateTime[] Urlaubstage2 = verwaltung.GetAngemeldetePerson().GetUrlaubinMonat(Month, Year);
            for (int f = 0; f < Urlaubstage2.Length; f++)
                if (Urlaubstage2[f].Month == Month && Urlaubstage2[f].Year == Year)
                    Inhalt[erster + Urlaubstage2[f].Day - 1].BackColor = UrlaubstageC;
        }

        private void cBoxMonat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DateTime.Today.Year == Year)
                Month = cBoxMonat.SelectedIndex  + DateTime.Today.Month;
            else
                Month = cBoxMonat.SelectedIndex + 1;
            KalenderLaden();
        }

        private void cBoxJahr_SelectedIndexChanged(object sender, EventArgs e)
        {
            Year = cBoxJahr.SelectedIndex + DateTime.Today.Year;
            if (Year == DateTime.Today.Year)
            {
                for (int f = 0; f < DateTime.Today.Month - 1; f++)
                    cBoxMonat.Items.Remove(Monat[f]);
                if (Month < DateTime.Today.Month) Month = DateTime.Today.Month;
            }
            else if (cBoxMonat.Items.Count != 12)
            {
                cBoxMonat.Items.Clear();
                cBoxMonat.Items.Add("January");
                cBoxMonat.Items.Add("February");
                cBoxMonat.Items.Add("March");
                cBoxMonat.Items.Add("April");
                cBoxMonat.Items.Add("May");
                cBoxMonat.Items.Add("June");
                cBoxMonat.Items.Add("July");
                cBoxMonat.Items.Add("August");
                cBoxMonat.Items.Add("September");
                cBoxMonat.Items.Add("October");
                cBoxMonat.Items.Add("November");
                cBoxMonat.Items.Add("December");
            }
            KalenderLaden();
        }

        private void tLpKalender_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                activeControl = sender as Control;
                previousPosition = e.Location;
            }
        }

        private void tLpKalender_MouseMove(object sender, MouseEventArgs e)
        {
            if (activeControl == null || activeControl != sender)
                return;
            else
            {
                if (tLpKalender.GetChildAtPoint(e.Location) == null) return;
                if (tLpKalender.GetChildAtPoint(e.Location).Text == "") return;
               // MessageBox.Show("Überprüfen");
                if (tLpKalender.GetChildAtPoint(e.Location).BackColor == BeantragenC) tLpKalender.GetChildAtPoint(e.Location).BackColor = Color.Transparent;
                else if (tLpKalender.GetChildAtPoint(e.Location).BackColor == Color.Transparent) tLpKalender.GetChildAtPoint(e.Location).BackColor = BeantragenC;
                Thread.Sleep(10); 
            }
        }

        private void tLpKalender_MouseUp(object sender, MouseEventArgs e)
        {
            activeControl = null;
        }

        private void btnBeantragen_Click(object sender, EventArgs e)
        {
            Speichern();
            for (int f = 0; f < Urlaubstage.Count; f++) 
                verwaltung.GetFirma().Urlaub_beantragen(Urlaubstage[f],verwaltung.GetAngemeldetePerson());
            Urlaubstage = new List<DateTime>();
            KalenderLaden();
        }

        private void btnMonatvor_Click(object sender, EventArgs e)
        {
            Speichern();
            if (++Month == 13)
            {
                Month = 1;
                Year++;
            }
            KalenderLaden();
        }
        private void LadenKrankenTage(int erster)
        {
            if (Chef) return;
            if (Month != DateTime.Today.Month) return;
            else
                for(int f = 0; f < verwaltung.GetAngemeldetePerson().GetKrankentage(); f++)
                    Inhalt[erster - 1 + DateTime.Today.Day + f].BackColor=KrankentageC;
        }
        private void LadenFeiertage(int erster,int maxTage)
        {
            for (int f = 0; f < maxTage; f++) 
                if(verwaltung.GetFirma().IsFeiertag(new DateTime(Year, Month, f+1)))
                    Inhalt[f + erster].BackColor = FeiertageC;
        }
        private void LadenArbeitstage(int erster, int maxTage)
        {
           /* MessageBox.Show(verwaltung.GetFirma().GetArbeitstag(0) + "\n" + verwaltung.GetFirma().GetArbeitstag(1) + "\n" +
                verwaltung.GetFirma().GetArbeitstag(2) + "\n" + verwaltung.GetFirma().GetArbeitstag(3) + "\n" +
                verwaltung.GetFirma().GetArbeitstag(4) + "\n" + verwaltung.GetFirma().GetArbeitstag(5) + "\n" +
                verwaltung.GetFirma().GetArbeitstag(6) + "\n");*/
            for(int f = erster; f < maxTage + erster; f++)
            {
                switch((new DateTime(Year, Month, f - erster + 1)).DayOfWeek)
                {
                    case DayOfWeek.Monday: if (!verwaltung.GetFirma().GetArbeitstag(0)) Inhalt[f].BackColor = keinArbeitstagC; break;
                    case DayOfWeek.Tuesday: if (!verwaltung.GetFirma().GetArbeitstag(1)) Inhalt[f].BackColor = keinArbeitstagC; break;
                    case DayOfWeek.Wednesday: if (!verwaltung.GetFirma().GetArbeitstag(2)) Inhalt[f].BackColor = keinArbeitstagC; break;
                    case DayOfWeek.Thursday: if (!verwaltung.GetFirma().GetArbeitstag(3)) Inhalt[f].BackColor = keinArbeitstagC; break;
                    case DayOfWeek.Friday: if (!verwaltung.GetFirma().GetArbeitstag(4)) Inhalt[f].BackColor = keinArbeitstagC; break;
                    case DayOfWeek.Saturday: if (!verwaltung.GetFirma().GetArbeitstag(5)) Inhalt[f].BackColor = keinArbeitstagC; break;
                    case DayOfWeek.Sunday: if (!verwaltung.GetFirma().GetArbeitstag(6)) Inhalt[f].BackColor = keinArbeitstagC; break;
                }
            }
        }

        private void Init()
        {
            btnBeantragen.Visible = !Chef;
            btnMonatzuruck.Enabled = false;
            Inhalt = new Label[47];
            for (int f = 0; f < Inhalt.Length; f++)
            {
                Inhalt[f] = new Label();
                tLpKalender.Controls.Add(Inhalt[f]);
                Inhalt[f].MouseDown += tLpKalender_MouseDown;
            }
            Inhalt[0].Text = "MON";
            Inhalt[1].Text = "TUE";
            Inhalt[2].Text = "WED";
            Inhalt[3].Text = "THU";
            Inhalt[4].Text = "FRI";
            Inhalt[5].Text = "SAT";
            Inhalt[6].Text = "SUN";
            for(int f = 0; f < MaxJahre; f++)
                cBoxJahr.Items.Add(DateTime.Today.Year+f);
            cBoxJahr.SelectedIndex = 0;
                cBoxMonat.Items.Clear();
            cBoxMonat.Items.Add(Monat[0]);
            cBoxMonat.Items.Add(Monat[1]);
            cBoxMonat.Items.Add(Monat[2]);
            cBoxMonat.Items.Add(Monat[3]);
            cBoxMonat.Items.Add(Monat[4]);
            cBoxMonat.Items.Add(Monat[5]);
            cBoxMonat.Items.Add(Monat[6]);
            cBoxMonat.Items.Add(Monat[7]);
            cBoxMonat.Items.Add(Monat[8]);
            cBoxMonat.Items.Add(Monat[9]);
            cBoxMonat.Items.Add(Monat[10]);
            cBoxMonat.Items.Add(Monat[11]);
            for (int f = 0; f < DateTime.Today.Month-1; f++)
                cBoxMonat.Items.Remove(Monat[f]);
            cBoxMonat.SelectedIndex = 0;
        }
    }
}
