using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unternehmen
{
    public class Nachrichten
    {
        private List<Konto> Sender;
        private List<string> Nachricht;
        private List<object> Anhang;

        public Nachrichten()
        {
            Sender = new List<Konto>();
            Nachricht = new List<string>();
            Anhang = new List<object>();
        }
        public void Recive(Konto Sender,string Nachricht, object Anhang)
        {
            this.Sender.Add(Sender);
            this.Nachricht.Add(Nachricht);
            this.Anhang.Add(Anhang);
        }
        public string[] GetAnzeige()
        {
            string[] temp = new string[Sender.Count];
            for(int f = 0; f < Sender.Count; f++)
                temp[f] = "Von: "+Sender[f].GetBenutzername();
            return temp;
        }
        public string GetNachricht(int index) => Nachricht[index];
        public object GetAnhang(int index) => Anhang[index];
        public Konto GetSender(int index) => Sender[index];
        public int GetAnzahl() => Nachricht.Count;

        public void DeleteNachricht(int index)
        {
            Nachricht.RemoveAt(index);
            Anhang.RemoveAt(index);
            Sender.RemoveAt(index);
        }
    }
}
