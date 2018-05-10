using System;
using System.Collections.Generic;

namespace Unternehmen
{
    [Serializable]
    public class Tagesplan
    {
        private List<DateTime> TerminVon, TerminBis;
        private List<string> Beschreibung;
        private List<string> Wiederholung;//0-Einmal,1-MO,2-DI,3-MI,4-DO,5-FR,6-SA,7-SO,10-Monatlich,100-Jährlich  MO-DI-MI-DO-FR-SA-SO-Monatlich-Jährlich

        public Tagesplan()
        {
            TerminVon = new List<DateTime>();
            TerminBis = new List<DateTime>();
            Beschreibung = new List<string>();
            Wiederholung = new List<string>();
        }
        public int GetAnzahl() => TerminVon.Count;
        public void SetTermin(DateTime am,string Beschreibung, string Wiederholung)
        {
            TerminVon.Add(am); TerminBis.Add(DateTime.MinValue); this.Beschreibung.Add(Beschreibung); this.Wiederholung.Add(Wiederholung);
        }
        public void SetTermin(DateTime am, string Beschreibung, string Wiederholung,int index)
        {
            TerminVon[index]=am; TerminBis[index]=DateTime.MinValue; this.Beschreibung[index]=Beschreibung; this.Wiederholung[index]=Wiederholung;
        }
        public void SetTermin(DateTime von, DateTime bis, string Beschreibung)
        {
            TerminVon.Add(von);
            TerminBis.Add(bis);
            this.Beschreibung.Add(Beschreibung);
            this.Wiederholung.Add("000000000");
            Sortieren();
        }
        public void SetTermin(DateTime von, DateTime bis, string Beschreibung,int index)
        {
            TerminVon[index]=von;
            TerminBis[index]=bis;
            this.Beschreibung[index]=Beschreibung;
            this.Wiederholung[index]="000000000";
            Sortieren();
        }
        public string[] GetBeschreibungen(DateTime Tag)
        {
            List<string> temp = new List<string>();
            for(int f = 0; f < TerminVon.Count; f++)
            {
                char[] help = Wiederholung[f].ToCharArray();
                switch (Tag.DayOfWeek)
                {
                    case DayOfWeek.Monday:
                        if (help[0] == '1')
                            if (Tag > TerminVon[f])
                                temp.Add(Beschreibung[f]);
                        break;
                    case DayOfWeek.Tuesday:
                        if (help[1] == '1')
                            if (Tag > TerminVon[f])
                                temp.Add(Beschreibung[f]);
                        break;
                    case DayOfWeek.Wednesday:
                        if (help[2] == '1')
                            if (Tag > TerminVon[f])
                                temp.Add(Beschreibung[f]);
                        break;
                    case DayOfWeek.Thursday:
                        if (help[3] == '1')
                            if (Tag > TerminVon[f])
                                temp.Add(Beschreibung[f]);
                        break;
                    case DayOfWeek.Friday:
                        if (help[4] == '1')
                            if (Tag > TerminVon[f])
                                temp.Add(Beschreibung[f]);
                        break;
                    case DayOfWeek.Saturday:
                        if (help[5] == '1')
                            if (Tag > TerminVon[f])
                                temp.Add(Beschreibung[f]);
                        break;
                    case DayOfWeek.Sunday:
                        if (help[6] == '1')
                            if (Tag > TerminVon[f])
                                temp.Add(Beschreibung[f]);
                        break;
                    }
                if (help[0] + "" + help[1] + help[2] + help[3] + help[4] + help[5] + help[6] == "0000000")
                {
                    if (help[7] == '1')
                    {
                        if (Tag.Day == TerminVon[f].Day)
                            temp.Add(Beschreibung[f]);
                    }
                    else if (help[8] == '1')
                    {
                        if (Tag.Day == TerminVon[f].Day && Tag.Month == TerminVon[f].Month)
                            temp.Add(Beschreibung[f]);
                    }
                    else
                    {
                        
                        if (DateTime.Compare(Tag,TerminVon[f])>=0&&DateTime.Compare(Tag,TerminBis[f])<0)
                            temp.Add(Beschreibung[f]);
                    }
                }

            }
            return temp.ToArray();
        }
        public DateTime GetVon(int index) => TerminVon[index];
        public DateTime GetBis(int index) => TerminBis[index];
        public int GetIndex(DateTime tag,int index)
        {
            int temp = 0,f;
            for (f = 0; f < TerminVon.Count&&temp!=index; f++)
            {
                char[] help = Wiederholung[f].ToCharArray();
                switch (tag.DayOfWeek)
                {
                    case DayOfWeek.Monday:
                        if (help[0] == '1')
                            if (tag > TerminVon[f])
                                temp++;
                        break;
                    case DayOfWeek.Tuesday:
                        if (help[1] == '1')
                            if (tag > TerminVon[f])
                                temp++;
                        break;
                    case DayOfWeek.Wednesday:
                        if (help[2] == '1')
                            if (tag > TerminVon[f])
                                temp++;
                        break;
                    case DayOfWeek.Thursday:
                        if (help[3] == '1')
                            if (tag > TerminVon[f])
                                temp++;
                        break;
                    case DayOfWeek.Friday:
                        if (help[4] == '1')
                            if (tag > TerminVon[f])
                                temp++;
                        break;
                    case DayOfWeek.Saturday:
                        if (help[5] == '1')
                            if (tag > TerminVon[f])
                                temp++;
                        break;
                    case DayOfWeek.Sunday:
                        if (help[6] == '1')
                            if (tag > TerminVon[f])
                                temp++;
                        break;
                }
                if (help[0] + "" + help[1] + help[2] + help[3] + help[4] + help[5] + help[6] == "0000000")
                {
                    if (help[7] == '1')
                    {
                        if (tag.Day == TerminVon[f].Day)
                            temp++;
                    }
                    else if (help[8] == '1')
                    {
                        if (tag.Day == TerminVon[f].Day && tag.Month == TerminVon[f].Month)
                            temp++;
                    }
                    else
                    {
                        if (DateTime.Compare(tag, TerminVon[f]) >= 0 && DateTime.Compare(tag, TerminBis[f]) < 0)
                            temp++;
                    }
                }

            }
            return f;        
        }
        public string GetBeschreibung(int index) => Beschreibung[index];
        public void DeleteBeschreibung(int index)
        {
            TerminVon.RemoveAt(index);
            TerminBis.RemoveAt(index);
            Beschreibung.RemoveAt(index);
        }
        public void Sortieren()
        {
            List<DateTime> copie = new List<DateTime>();
            for(int f = 0; f < TerminVon.Count; f++)
                copie.Add(TerminVon[f]);
            if (TerminVon.Count < 2) return;
            int[] temp = new int[copie.Count];
            int tempC = 0;
            for (int g = 0; g < temp.Length; g++)
            {
                DateTime min = copie[0];
                for (int f = 1; f < copie.Count; f++)
                    if (min > copie[f])
                    {
                        min = copie[f];
                        temp[tempC] = f;
                    }
                copie.RemoveAt(temp[tempC++]);
            }
            List<DateTime> temp1=new List<DateTime>(), temp2 = new List<DateTime>();
            List<string> tempB = new List<string>();
            for(int f = 0; f < temp.Length; f++)
            {
                temp1.Add(TerminVon[temp[f]]);
                temp2.Add(TerminBis[temp[f]]);
                tempB.Add(Beschreibung[temp[f]]);
            }
            TerminVon = temp1;
            TerminBis = temp2;
            Beschreibung = tempB;
        }
    }
}
