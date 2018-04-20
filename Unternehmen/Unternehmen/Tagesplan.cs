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
        }
        public void SetTermin(DateTime von, DateTime bis, string Beschreibung,int index)
        {
            TerminVon[index]=von;
            TerminBis[index]=bis;
            this.Beschreibung[index]=Beschreibung;
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
    }
}
