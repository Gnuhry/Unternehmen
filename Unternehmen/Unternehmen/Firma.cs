﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Unternehmen
{
    [Serializable]
    public class Firma
    {
        private List<Konto> Mitarbeiter;
        private Notizen notizen;
        private bool[] Arbeitstage;
        private Feiertage feiertage;
        private DateTime date_zero;
        private string Web;

        public Firma()
        {
            Web = "http://www.google.com";
            feiertage = new Feiertage();
            Arbeitstage = new bool[7];
            for (int f = 0; f < 5; f++) Arbeitstage[f] = true;
            Arbeitstage[5] = Arbeitstage[6] = false;
            Mitarbeiter = new List<Konto>();
            date_zero = DateTime.Today;
        }
        public int Einloggen(string benutzername, string passwort, Verwaltung verwaltung)
        {
            for(int f = 0; f < Mitarbeiter.Count; f++)
            {
                switch (Mitarbeiter[f].Login(benutzername,passwort))
                {
                    case 0: verwaltung.SetAngemeldetePerson(Mitarbeiter[f]); return 0;
                    case -1: break;
                    case -2: return -1;
                    case -3: return -3;
                }  
            }
            return -1;
        }
        public void SetWeb(string web) => Web = web;
        public string GetWeb() => Web;
        public bool AddMitarbeiter(Konto Person)
        {
            for (int f = 0; f < Mitarbeiter.Count; f++)
            {
                if (Person.GetBenutzername() == Mitarbeiter[f].GetBenutzername()) return false;
            }
            Mitarbeiter.Add(Person);
            return true;
        }
        public void Mitarbeiter_feuern(Konto Person)
        {
            for (int f = 0; f < Mitarbeiter.Count; f++)
                if (Person == Mitarbeiter[f])
                    Mitarbeiter.RemoveAt(f);
        }
        public Konto GetMitarbeiter(int index) => Mitarbeiter[index];
        public int GetMitarbeiterAnzahl() => Mitarbeiter.Count;

        public string[] Krankenliste(DateTime Tag)
        {
            List<string> temp = new List<string>();
            for(int f = 0; f < Mitarbeiter.Count; f++)
                if ((Tag-DateTime.Today).TotalDays < Mitarbeiter[f].GetKrankentage())
                    temp.Add(Mitarbeiter[f].GetBenutzername());
            return temp.ToArray();
        }
        public string[] Urlaubliste(DateTime Tag)
        {
            List<string> temp = new List<string>();
            for (int f = 0; f < Mitarbeiter.Count; f++)
                    if (Mitarbeiter[f].IsUrlaub(Tag))
                        temp.Add(Mitarbeiter[f].GetBenutzername());
            return temp.ToArray();
        }
        public string[] Geburtstagliste(DateTime Tag)
        {
            List<string> temp = new List<string>();
            for (int f = 0; f < Mitarbeiter.Count; f++)
                if (Mitarbeiter[f].IsGeburtstag(Tag))
                    temp.Add(Mitarbeiter[f].GetBenutzername());
            return temp.ToArray();
        }
        public bool GetArbeitstag(int Tag) => Arbeitstage[Tag];

        public void SetArbeitstag(bool[] Arbeitstage) => this.Arbeitstage = Arbeitstage;

        public void SetFeiertag(DateTime Feiertag, string name)=>feiertage.SetFeiertag(name, Feiertag);

        public string GetFeirtagname(DateTime Tag) => feiertage.getFeierTag(Tag);
        public bool IsFeiertag(DateTime Tag) => feiertage.getFeierTag(Tag)!=null;
        public void DeleteFeiertag(DateTime Tag) => feiertage.RemoveFeiertag(Tag);

        public void Urlaub_beantragen(DateTime Tag, Konto angemeldet)
        {
            int temp = 0;
            for (int f = 0; f < Mitarbeiter.Count; f++)
            {
                if (Mitarbeiter[f].IsUrlaub(Tag)) temp++;
                else if (DateTime.Today.AddDays(Mitarbeiter[f].GetKrankentage()) == Tag) temp++;
            }
            if (temp < 3)
            {
                angemeldet.SetUrlaub(Tag);
            }
        }
        private bool Urlaub_beantragen(DateTime Tag)
        {
            int temp = 0;
            for (int f = 0; f < Mitarbeiter.Count; f++)
            {
                if (Mitarbeiter[f].IsUrlaub(Tag)) temp++;
                else if (DateTime.Today.AddDays(Mitarbeiter[f].GetKrankentage()) == Tag) temp++;
            }
            return temp < 3;
        }
        public void Urlaubstag_Entfernen(DateTime Tag)
        {
            for(int f = 0; f < Mitarbeiter.Count; f++)
            {
                Mitarbeiter[f].RemoveUrlaub(Tag);
            }
        }

        public void Uerberprufung(DateTime Tag)
        {
            List<int> temp = new List<int>();
            if (Urlaub_beantragen(Tag)) return;
            for(int f = 0; f < Mitarbeiter.Count; f++)
            {
                if (Mitarbeiter[f].IsUrlaub(Tag))
                    temp.Add(f);
            }
            Mitarbeiter[temp[(new Random()).Next(temp.Count)]].RemoveUrlaub(Tag);
        }
        public void SetNotizen(string Nachricht, DateTime Tag) => notizen.AddNotiz(Nachricht, Tag);
        public string GetNotiz(DateTime Tag) => notizen.GetNachricht(Tag);


        public void Speichern(string path)
        {
            Leeren(path);
            FileStream FS = new FileStream(path, FileMode.Create);
            BinaryFormatter BF = new BinaryFormatter();
            BF.Serialize(FS, this);
            FS.Dispose();
        }
        public Firma Laden(string path)
        {
            Firma erg = new Firma();
            FileStream FS = new FileStream(path, FileMode.Open);
            BinaryFormatter BF = new BinaryFormatter();
            erg = (Firma)BF.Deserialize(FS);
            FS.Dispose();
            Neuer_Tag();
            return erg;
        }

        private void Neuer_Tag()
        {
           
                for(int g = 0; g < Mitarbeiter.Count; g++)
                {
                for (int f = 0; f < (DateTime.Today - date_zero).TotalDays; f++)
                {
                    Mitarbeiter[g].RemoveUrlaub(date_zero.AddDays(f));
                }
                    Mitarbeiter[g].Neuer_Tag();
                }
            date_zero = DateTime.Today;
        }

        public void Leeren(string path)
        {
            File.Delete(path);
            FileStream FS = new FileStream(path, FileMode.Create);
            BinaryFormatter BF = new BinaryFormatter();
            BF.Serialize(FS, new Firma());
            FS.Dispose();
        }
    }
}
