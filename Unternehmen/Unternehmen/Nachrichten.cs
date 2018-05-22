using System;
using System.Collections.Generic;
using System.Drawing;

namespace Unternehmen
{
    [Serializable]
    public class Nachrichten
    {
        private List<Konto> Sender;
        private List<string> Nachricht;
        private List<Image> Anhang;
        private List<DateTime> SendeDatum;
        private List<Tagesplan> DatumAnfrage;

        public Nachrichten()
        {
            Sender = new List<Konto>();
            Nachricht = new List<string>();
            Anhang = new List<Image>();
            SendeDatum = new List<DateTime>();
            DatumAnfrage = new List<Tagesplan>();
        }
        public void Recive(Konto Sender,string Nachricht, Image Anhang)
        {
            this.Sender.Add(Sender);
            this.Nachricht.Add(Nachricht);
            this.Anhang.Add(Anhang);
            SendeDatum.Add(DateTime.Now);
            DatumAnfrage.Add(null);
        }
        //public void Recive(Konto Sender, string Nachricht, Tagesplan Anhang)
        //{
        //    this.Sender.Add(Sender);
        //    this.Nachricht.Add(Nachricht);
        //    this.Anhang.Add(null);
        //    SendeDatum.Add(DateTime.Now);
        //    DatumAnfrage.Add(Anhang);
        //}
        //public bool IsDatumAnfrage(int index) => DatumAnfrage[index] != null;
        //public Tagesplan GetTagesplan(int index) => DatumAnfrage[index];
        public string[] GetAnzeige()
        {
            string[] temp = new string[Sender.Count];
            for (int f = 0; f < Sender.Count; f++)
            {
                if(Sender[f]==null)
                    temp[f] = "From: Admin";
                else
                    temp[f] = "From: " + Sender[f].GetKontoInhaber();
            }
            return temp;
        }
        public string GetNachricht(int index) => Nachricht[index];
        public Image GetAnhang(int index) => Anhang[index];
        public Konto GetSender(int index) => Sender[index];
        public int GetAnzahl() => Nachricht.Count;
        public DateTime GetSendeDatum(int index) => SendeDatum[index];

        public void DeleteNachricht(int index)
        {
            Nachricht.RemoveAt(index);
            Anhang.RemoveAt(index);
            Sender.RemoveAt(index);
            SendeDatum.RemoveAt(index);
        }
    }
}
