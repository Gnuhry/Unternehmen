using System;
using System.Collections.Generic;

namespace Unternehmen
{
    [Serializable]
    public class Notizen
    {
        private List<string> Nachricht;
        private List<DateTime> Tag;

        public Notizen()
        {
            Nachricht=new List<string>();
            Tag = new List<DateTime>();
        }
        public void AddNotiz(string Nachricht, DateTime Tag)
        {
            if (this.Tag.Contains(Tag))
            {
                if(Nachricht.Trim()!=""&&Nachricht.Trim()!=null)
                    this.Nachricht[this.Tag.IndexOf(Tag)] = Nachricht;
                else
                {
                    this.Nachricht.RemoveAt(this.Tag.IndexOf(Tag));
                    this.Tag.Remove(Tag);
                }

            }
            else
            {
                if (Nachricht.Trim() == "" && Nachricht.Trim() == null) return;
                this.Nachricht.Add(Nachricht);
                this.Tag.Add(Tag);
            }
        }
        public string GetNachricht(DateTime Tag)
        {
            if (this.Tag.Contains(Tag))
                return Nachricht[this.Tag.IndexOf(Tag)];
            return "";
        }
    }
}
