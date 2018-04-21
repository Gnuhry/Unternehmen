using System;
using System.Collections.Generic;

namespace Unternehmen
{
    [Serializable]
    public class Tagesplan
    {
        private List<DateTime> TerminVon, TerminBis;
        private List<string> Beschreibung;

        public Tagesplan()
        {
            TerminVon = new List<DateTime>();
            TerminBis = new List<DateTime>();
            Beschreibung = new List<string>();
        }
        public int GetAnzahl() => TerminVon.Count;
        public void SetTermin(DateTime von, DateTime bis, string Beschreibung)
        {
            TerminVon.Add(von);
            TerminBis.Add(bis);
            this.Beschreibung.Add(Beschreibung);
            Sortieren();
        }
        public void SetTermin(DateTime von, DateTime bis, string Beschreibung,int index)
        {
            TerminVon[index]=von;
            TerminBis[index]=bis;
            this.Beschreibung[index]=Beschreibung;
            Sortieren();
        }
        public DateTime GetVon(int index) => TerminVon[index];
        public DateTime GetBis(int index) => TerminBis[index];
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
