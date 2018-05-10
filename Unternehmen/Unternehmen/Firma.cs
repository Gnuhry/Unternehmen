using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Unternehmen
{
    [Serializable]
    public class Firma
    {
        private Image Logo;
        private List<Konto> Mitarbeiter,Admins;
        private Notizen notizen;
        private bool[] Arbeitstage;
        private Feiertage feiertage;
        private DateTime date_zero;
        private string Web,Firmenstatus;
        private int MaxTage;
        private bool AutoRegistrieren,AutoRemoveUrlaub;
        private Nachrichten Adminnachrichten;

        public string Firmenstatus1 { get => Firmenstatus; set => Firmenstatus = value; }
        public bool AutoRemoveUrlaub1 { get => AutoRemoveUrlaub; set => AutoRemoveUrlaub = value; }

        public Firma()
        {
            Admins = new List<Konto>();
            Firmenstatus = "We Create, We Plan\n You're Way";
            Logo = Properties.Resources.japanese_kanji;
            Adminnachrichten = new Nachrichten();
            AutoRegistrieren = true;
            AutoRemoveUrlaub = false;
            Web = "http://www.google.com";
            feiertage = new Feiertage();
            Arbeitstage = new bool[7];
            for (int f = 0; f < 5; f++) Arbeitstage[f] = true;
            Arbeitstage[5] = Arbeitstage[6] = false;
            Mitarbeiter = new List<Konto>();
            date_zero = DateTime.Today;
            notizen = new Notizen();
        }
        public void SetMaxTage(int MaxTage)
        {
            this.MaxTage = MaxTage;
            for (int f = 0; f < Mitarbeiter.Count; f++)
                Mitarbeiter[f].SetMaxTage(MaxTage);
        }
        public int GetMaxTage() => MaxTage;
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
                if (Person.GetBenutzername() == Mitarbeiter[f].GetBenutzername()) return false;
            Person.SetMaxTage(MaxTage);
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
                    temp.Add(Mitarbeiter[f].GetBenutzername()+" ("+(Mitarbeiter[f].GetGeburtstag().Year-DateTime.Today.Year)+")");
            return temp.ToArray();
        }
        public bool GetArbeitstag(int Tag) => Arbeitstage[Tag];

        public void SetArbeitstag(bool[] Arbeitstage) => this.Arbeitstage = Arbeitstage;

        public void SetFeiertag(DateTime Feiertag, string name)
        {
            feiertage.SetFeiertag(name, Feiertag);
            Urlaubstag_Entfernen(Feiertag);
        }

        public string GetFeirtagname(DateTime Tag) => feiertage.getFeierTag(Tag);
        public bool IsFeiertag(DateTime Tag) => feiertage.getFeierTag(Tag)!=null;
        public void DeleteFeiertag(DateTime Tag) => feiertage.RemoveFeiertag(Tag);
        public void SetFirmenLogo(Image Logo) => this.Logo = Logo;
        public Image GetFirmenLogo() => Logo;

        public void Urlaub_beantragen(DateTime Tag, Konto angemeldet)
        {
            int temp = 0;
            for (int f = 0; f < Mitarbeiter.Count; f++)
            {
                Console.Write(Mitarbeiter[f].GetKontoInhaber());
                if (Mitarbeiter[f].IsUrlaub(Tag)) { temp++; Console.WriteLine("-Urlaub"); }
                else if ((DateTime.Today.AddDays(Mitarbeiter[f].GetKrankentage()))>Tag) {temp++; Console.WriteLine("-krank"); }
                else { Console.WriteLine(); }
            }
            if (temp < 3)
                angemeldet.SetUrlaub(Tag);
            else Console.WriteLine("declined Day " + Tag.ToShortDateString() + " from " + angemeldet.GetKontoInhaber());
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
        public void UrlaubDeleten(DateTime tag, int index)
        {
            int temp = 0;
            for (int f = 0; f < Mitarbeiter.Count; f++)
                for (int g = 0; g < Mitarbeiter[f].GetUrlaubinMonat(tag.Month,tag.Year).Length; g++)
                    if (Mitarbeiter[f].GetUrlaubinMonat(tag.Month, tag.Year)[g].Day == tag.Day)
                    {
                        if (temp++ == index)
                        {
                            Mitarbeiter[f].ReciveNachricht("-Automatische Nachricht-\n Ihr Urlaub am " + tag.ToShortDateString() + " wurde gecanceled!\n Bei Beschwerden den Admin kontaktieren", null, null);
                            Mitarbeiter[f].RemoveUrlaub(tag);
                        }
                    }
        }

        public void Uerberprufung(DateTime Tag)
        {
            if (!AutoRemoveUrlaub) return;
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
        public void SetAutoRegistrieren(bool Auto) => AutoRegistrieren = Auto;
        public bool GetAutoRegistrieren() => AutoRegistrieren;
        public void ReciveAdminNachricht(string Nachricht, Image Anhang, Konto Sender) => Adminnachrichten.Recive(Sender, Nachricht, Anhang);
        public string GetAdminNachricht(int index) => Adminnachrichten.GetNachricht(index);
        public Image GetAdminAnhang(int index) => Adminnachrichten.GetAnhang(index);
        public Konto GetAdminNachrichtSender(int index) => Adminnachrichten.GetSender(index);
        public int GetAdminNachrichtAnzahl() => Adminnachrichten.GetAnzahl();
        public string[] GetAdminAnzeige() => Adminnachrichten.GetAnzeige();
        public DateTime GetSendeDatum(int index) => Adminnachrichten.GetSendeDatum(index);
        public void RemoveNachricht(int index) => Adminnachrichten.DeleteNachricht(index);
        public void SetAdmin(Konto Admin) => Admins.Add(Admin);
        public void RemoveAdmin(Konto Admin) => Admins.Remove(Admin);
        public bool IsKonto(Konto Abfrage) => Admins.Contains(Abfrage);

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
