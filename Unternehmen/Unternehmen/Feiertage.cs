using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unternehmen
{
    [Serializable]
    public class Feiertage
    {
        private DateTime[] Feiertag;
        private string[] Feiertagname;
        private List<DateTime> eigeneFeiertage;
        private List<string> eigeneFeiertagename;
        public Feiertage()
        {
            eigeneFeiertage = new List<DateTime>();
            eigeneFeiertagename = new List<string>();
        }

        public string getFeierTag(DateTime Tag)
        {
           // Console.WriteLine("Hey");
            SetFeiertage(Tag.Year);
            string erg = "";
            for (int f = 0; f < Feiertag.Length; f++)
            {
                if (Feiertag[f] == Tag)
                {
                    erg += Feiertagname[f] + "\n";
                    //Console.WriteLine("1-"+Feiertagname[f]);
                }
            }
            for (int f = 0; f < eigeneFeiertage.Count; f++)
            {
                if (eigeneFeiertage[f].Year == 1753)
                {
                    if (eigeneFeiertage[f].Month == Tag.Month && eigeneFeiertage[f].Day == Tag.Day)
                    {
                        erg += eigeneFeiertagename[f] + "\n";
                      //  Console.WriteLine("2-" + Feiertagname[f]);
                    }
                }
                else
                if (eigeneFeiertage[f] == Tag)
                {
                    erg += eigeneFeiertagename[f] + "\n";
                   // Console.WriteLine("3-" + Feiertagname[f]);
                }
            }
            if (erg=="") return null;
            return erg;
        }

        private void SetFeiertage(int Jahr)
        {
            int count = 0;
            Feiertag = new DateTime[32];
            Feiertagname = new string[Feiertag.Length];

            for (int f = 0; f < Feiertag.Length; f++) { Feiertag[f] = new DateTime(Jahr, 1, 1); }


            Feiertag[count] = Feiertag[count].AddMonths(2);
            Feiertag[count] = Feiertag[count].AddDays(22 - 1 + ((19 * (Jahr % 19) + 24) % 30) + ((2 * (Jahr % 4) + 4 * (Jahr % 7) + 6 * ((19 * (Jahr % 19) + 24) % 30) + 5) % 7));
            //Feiertag[count]=Feiertag[count].AddDays(31);
            Feiertagname[count++] = "Ostersonntag";
            Feiertag[count] = Feiertag[0].AddDays(-48); Feiertagname[count++] = "Rosenmontag";
            Feiertag[count] = Feiertag[0].AddDays(-47); Feiertagname[count++] = "Faschingsdienstag";
            Feiertag[count] = Feiertag[0].AddDays(-46); Feiertagname[count++] = "Aschermittwoch";
            Feiertag[count] = Feiertag[0].AddDays(-7); Feiertagname[count++] = "Palmsonntag";
            Feiertag[count] = Feiertag[0].AddDays(-3); Feiertagname[count++] = "Gründonnerstag";
            Feiertag[count] = Feiertag[0].AddDays(-2); Feiertagname[count++] = "Karfreitag";
            Feiertag[count] = Feiertag[0].AddDays(+1); Feiertagname[count++] = "Ostermontag";
            Feiertag[count] = Feiertag[0].AddDays(39); Feiertagname[count++] = "Christi Himmelfahrt";
            Feiertag[count] = Feiertag[0].AddDays(49); Feiertagname[count++] = "Pfingstsonntag";
            Feiertag[count] = Feiertag[0].AddDays(50); Feiertagname[count++] = "Pfingstmontag";
            Feiertag[count] = Feiertag[0].AddDays(60); Feiertagname[count++] = "Fronleichnam";

            Feiertag[count] = Feiertag[count].AddDays(23); Feiertag[count] = Feiertag[count].AddMonths(11); Feiertagname[count++] = "Heilg Abend";
            DateTime weih = Feiertag[count - 1];
            for (int f = 0; f < 6; f++)
            {
                if (weih.DayOfWeek == DayOfWeek.Sunday) { Feiertag[count] = weih; break; }
                else { weih = weih.AddDays(-1); }
            }
            Feiertagname[count++] = "4. Advent";
            Feiertag[count] = weih.AddDays(-7); Feiertagname[count++] = "3. Advent";
            Feiertag[count] = weih.AddDays(-14); Feiertagname[count++] = "2. Advent";
            Feiertag[count] = weih.AddDays(-21); Feiertagname[count++] = "1. Advent";





            Feiertag[count] = Feiertag[count].AddDays(0); Feiertag[count] = Feiertag[count].AddMonths(0); Feiertagname[count++] = "Neujahr";
            Feiertag[count] = Feiertag[count].AddDays(5); Feiertag[count] = Feiertag[count].AddMonths(0); Feiertagname[count++] = "Heilige Drei Könige";
            Feiertag[count] = Feiertag[count].AddDays(0); Feiertag[count] = Feiertag[count].AddMonths(4); Feiertagname[count++] = "Tag der Arbeit";
            Feiertag[count] = Feiertag[count].AddDays(14); Feiertag[count] = Feiertag[count].AddMonths(7); Feiertagname[count++] = "Mariä Himmelsfahrt";
            Feiertag[count] = Feiertag[count].AddDays(2); Feiertag[count] = Feiertag[count].AddMonths(9); Feiertagname[count++] = "Tag der Deutschen Einheit";
            Feiertag[count] = Feiertag[count].AddDays(30); Feiertag[count] = Feiertag[count].AddMonths(9); Feiertagname[count++] = "Reformationstag";
            Feiertag[count] = Feiertag[count].AddDays(0); Feiertag[count] = Feiertag[count].AddMonths(10); Feiertagname[count++] = "Allerheiligen";
            Feiertag[count] = Feiertag[count].AddDays(1); Feiertag[count] = Feiertag[count].AddMonths(10); Feiertagname[count++] = "Allerseelen";
            Feiertag[count] = Feiertag[count].AddDays(10); Feiertag[count] = Feiertag[count].AddMonths(10); Feiertagname[count++] = "St. Martin";
            Feiertag[count] = Feiertag[count].AddDays(6); Feiertag[count] = Feiertag[count].AddMonths(11); Feiertagname[count++] = "Nikolaus";
            Feiertag[count] = Feiertag[count].AddDays(7); Feiertag[count] = Feiertag[count].AddMonths(11); Feiertagname[count++] = "Mariä Unbefleckte Empfängnis";
            Feiertag[count] = Feiertag[count].AddDays(23); Feiertag[count] = Feiertag[count].AddMonths(11); Feiertagname[count++] = "Heiliger Abend";
            Feiertag[count] = Feiertag[count].AddDays(24); Feiertag[count] = Feiertag[count].AddMonths(11); Feiertagname[count++] = "1. Weihnachtstag";
            Feiertag[count] = Feiertag[count].AddDays(25); Feiertag[count] = Feiertag[count].AddMonths(11); Feiertagname[count++] = "2. Weihnachtstag";
            Feiertag[count] = Feiertag[count].AddDays(30); Feiertag[count] = Feiertag[count].AddMonths(11); Feiertagname[count++] = "Silvester";
        }

        public bool IsAnderbar(DateTime Tag)
        {
            SetFeiertage(Tag.Year);
            if (Feiertag.Contains(Tag)) return false;
                for (int f = 0; f < eigeneFeiertage.Count; f++)
                {
                    if (eigeneFeiertage[f].Month == Tag.Month && eigeneFeiertage[f].Day == Tag.Day)
                    {
                        if (eigeneFeiertage[f].Year == 1753)
                        {
                            return false;
                        }
                    }

            }
            return true;

        }
        public void SetFeiertag(string Name, DateTime Tag)
        {
            if (eigeneFeiertage.Contains(Tag))
            {
                eigeneFeiertagename[eigeneFeiertage.BinarySearch(Tag)] = Name;
            }
            else if(eigeneFeiertage.Contains(new DateTime(1753, Tag.Month, Tag.Day)))
            {
                return;
            }
            else
            {
                eigeneFeiertage.Add(Tag);
                eigeneFeiertagename.Add(Name);
            }
        }
        public void RemoveFeiertag(DateTime Tag)
        {
            Console.WriteLine(Tag.ToShortDateString());
            if (eigeneFeiertage.Contains(Tag))
            {
                eigeneFeiertagename.RemoveAt(eigeneFeiertage.BinarySearch(Tag));
                eigeneFeiertage.Remove(Tag);
            }
        }
        public string[] GetGesetzlicheFeiertage(int Jahr)
        {
            SetFeiertage(Jahr);
            string[] temp=new string[Feiertag.Length];
            for(int f = 0; f < Feiertag.Length; f++)
            {
                temp[f] = Feiertag[f].ToShortDateString() + "- " + Feiertagname[f];
            }
            return temp;
        }
        public string[] GetEigeneFeiertage()
        {
            string[] temp = new string[eigeneFeiertage.Count];
            for (int f = 0; f < eigeneFeiertage.Count; f++)
            {
                if (eigeneFeiertage[f].Year == 1753)
                {
                    if (eigeneFeiertage[f].Day < 10)
                        temp[f] = "0" + eigeneFeiertage[f].Day+".";
                    else
                        temp[f] = eigeneFeiertage[f].Day + ".";
                    if (eigeneFeiertage[f].Month < 10)
                        temp[f] += "0" + eigeneFeiertage[f].Month;
                    else
                        temp[f] += eigeneFeiertage[f].Month + "";
                    temp[f] +="- " + eigeneFeiertagename[f];
                }
                else
                temp[f] = eigeneFeiertage[f].ToShortDateString() + "- " + eigeneFeiertagename[f];
            }
            return temp;
        }
    }
}
