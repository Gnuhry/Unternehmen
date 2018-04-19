using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Farben RGBS
//37; 41; 48
//web->White
//67; 188; 180
namespace Unternehmen
{
    public partial class Kalender : Form
    {
        Verwaltung verwaltung;
        private Label[] Inhalt;
        private List<DateTime> Urlaubstage;
        private List<Tag> tage;
        private int Month, Year;
        private static Color KrankentageC = Color.Orange, UrlaubstageC = Color.Red, VergangeneTageC = Color.LightGray, FeiertageC = Color.Green, BeantragenC = Color.Blue;
        public Kalender(Verwaltung verwaltung)
        {
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
            switch (Month)
            {
                case 1: lbMonat.Text = "Januar"; break;
                case 3: lbMonat.Text = "März"; break;
                case 5: lbMonat.Text = "Mai"; break;
                case 7: lbMonat.Text = "Juli"; break;
                case 8: lbMonat.Text = "August"; break;
                case 10: lbMonat.Text = "Oktober"; break;
                case 12:  lbMonat.Text = "Dezember"; break;
                case 4:  lbMonat.Text = "April"; break;
                case 6:  lbMonat.Text = "Juni"; break;
                case 9: lbMonat.Text = "September"; break;
                case 11:  lbMonat.Text = "November"; break;
                case 2: lbMonat.Text = "Februar"; break;
            }
            lbJahr.Text = Year + "";
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
            if (Month == DateTime.Today.Month)
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
        }

        private void Inhalt_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if ((sender as Label).BackColor == BeantragenC) (sender as Label).BackColor = Color.Transparent;
                else if ((sender as Label).BackColor == Color.Transparent) (sender as Label).BackColor = BeantragenC;
            }
            else
            {
                tage.Add(new Tag(verwaltung, new DateTime(Year, Month, Convert.ToInt32((sender as Label).Text))));
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
                            Urlaubstage.Add(new DateTime(Year, Month, Convert.ToInt32(Inhalt[g].Text)));              
        }
        private void Laden(int erster)
        {          
            for (int f = 0; f < Urlaubstage.Count; f++)
                if (Urlaubstage[f].Month == Month && Urlaubstage[f].Year == Year)
                {
                    Inhalt[erster + Urlaubstage[f].Day - 1].BackColor = BeantragenC;
                    Urlaubstage.RemoveAt(f);
                }
        }

        private void Kalender_FormClosing(object sender, FormClosingEventArgs e)
        {
            for(int f = 0; f < tage.Count; f++)
            {
                tage[f].Close();
            }
        }

        private void LadenGenemigteUrlaube(int erster)
        {
           
            List<DateTime> Urlaubstage2 = (verwaltung.GetAngemeldetePerson().GetUrlaubinMonat(Month, Year)).ToList();
            for (int f = 0; f < Urlaubstage2.Count; f++)
            {
                MessageBox.Show(Urlaubstage2[f].ToShortDateString());
                if (Urlaubstage2[f].Month == Month && Urlaubstage2[f].Year == Year)
                {
                    Inhalt[erster + Urlaubstage2[f].Day - 1].BackColor = UrlaubstageC;
                    Urlaubstage2.RemoveAt(f);
                }
            }
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

        private void Init()
        {
            btnMonatzuruck.Enabled = false;
            Inhalt = new Label[47];
            for (int f = 0; f < Inhalt.Length; f++)
            {
                Inhalt[f] = new Label();
                tLpKalender.Controls.Add(Inhalt[f]);
            }
            Inhalt[0].Text = "MO";
            Inhalt[1].Text = "DI";
            Inhalt[2].Text = "MI";
            Inhalt[3].Text = "DO";
            Inhalt[4].Text = "FR";
            Inhalt[5].Text = "SA";
            Inhalt[6].Text = "SO";
        }
    }
}
