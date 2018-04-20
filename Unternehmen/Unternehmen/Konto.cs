using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;

namespace Unternehmen
{
    [Serializable]
    public class Konto
    {
        private string benutzername, Kontoinhaber;
        private byte[] passwort;
        private List<DateTime> Urlaubstage;
        private int Krankendauer, status, _Versuche, krankenC, UrlaubsC,maxTage;//0-gesperrt,1-Aktiv(Zuhause),2-Krank,3-Urlaub,4-Aktiv(arbeitend)
        private Image Profilbild;
        private double Arbeitszeit;
        private DateTime Geburtstag, _Anfang;
        private Notizen notizen;
        private Nachrichten nachrichten;
        private Tagesplan tagesplan;

        public Konto()
        {
            tagesplan = new Tagesplan();
            Urlaubstage = new List<DateTime>();
            notizen = new Notizen();
            nachrichten = new Nachrichten();
            Arbeitszeit = Krankendauer = status = krankenC = UrlaubsC = 0;
        }

        public string Registrieren(string Kontoinhaber, string benutzername, string passwort, DateTime Geburtstag,Image Profilbild, bool Autoregistrieren)
        {
            char[] x = benutzername.ToCharArray();
            bool GrB = false, KlB = false, Zahl = false;

            for (int f = 0; f < x.Length; f++)
            {
                if (x[f] < 65 || x[f] > 122 || (x[f] > 90 && x[f] < 97))
                    return "Kein " + x[f];
            }
            this.benutzername = benutzername;
            //Überprüfung der Existenz des benutzernamen
            x = passwort.ToCharArray();
            for (int f = 0; f < x.Length; f++)
            {
                if (x[f] > 64 && x[f] < 91) GrB = true;
                else if (x[f] > 96 && x[f] < 122) KlB = true;
                else if (x[f] > 47 && x[f] < 58) Zahl = true;
                else
                    return "Keine " + '"' + x[f] + '"';
            }
            if (!GrB) return "Großbuchstabe fehlt";
            if (!KlB) return "Kleinbuchstabe fehlt";
            if (!Zahl) return "Zahl fehlt";
            this.passwort = new MD5CryptoServiceProvider().ComputeHash(ASCIIEncoding.ASCII.GetBytes(passwort));

            if (Autoregistrieren)
                status = 1;
            else
                status = 0;
            this.Geburtstag = Geburtstag;
            this.Kontoinhaber = Kontoinhaber;
            this.Profilbild = Profilbild;

            return "";
        }
        public int Login(string benutzername, string passwort) //0-erfolgreich; -1-Falscher Benutzername; -2-Falsches Passwort; -3-Gesperrt
        {
            if (_Versuche++ == 3||status==0)
            {
                status = 0; return -3;
            }
            if (benutzername != this.benutzername) return -1;
            byte[] temp = new MD5CryptoServiceProvider().ComputeHash(ASCIIEncoding.ASCII.GetBytes(passwort));
            if (temp.Length != this.passwort.Length) return -2;
            for (int f = 0; f < temp.Length; f++)
                if (temp[f] != this.passwort[f]) return -2;
            _Versuche = 0;
            return 0;

        }
        public string GetBenutzername() => benutzername;
        public bool IsGeburtstag(DateTime Tag) => Tag == Geburtstag;
        public string GetKontoInhaber() => Kontoinhaber;
        public DateTime GetGeburtstag() => Geburtstag;
        public DateTime[] GetUrlaubinMonat(int Monat, int Year)
        {
            List<DateTime> temp = new List<DateTime>();
            for(int f = 0; f < Urlaubstage.Count; f++)
            {
                if (Urlaubstage[f].Month == Monat && Urlaubstage[f].Year == Year)
                    temp.Add(Urlaubstage[f]);                
            }
            return temp.ToArray();
        }
        public bool IsUrlaub(DateTime Tag)
        {
            for (int f = 0; f < Urlaubstage.Count; f++)
                if (Tag == Urlaubstage[f]) return true;
            return false;
        }
        public void SetUrlaub(DateTime Tag)
        {
            if (!Urlaubstage.Contains(Tag))
                Urlaubstage.Add(Tag);
            if (Tag == DateTime.Today) status = 2;
        }
        public void RemoveUrlaub(DateTime Tag) => Urlaubstage.Remove(Tag);
        public void SetKrankentage(int Krankendauer)
        {
            this.Krankendauer = Krankendauer;
            if (Krankendauer != 0)
                status = 2;
        }
        public int GetKrankentage() => Krankendauer;
        public string GetStatus()
        {
            switch (status)
            {
                case 0: return "gesperrt";
                case 1: return "Gegangen";
                case 2: return "Krank";
                case 3: return "Urlaub";
                case 4: return "Anwesend";
                default: return "Fehler";
            }
        }
        public Image GetProfilbild() => Profilbild;
        public double GetArbeitszeit() => Arbeitszeit;

        public void Anwesend()
        {
            status = 4;
            Krankendauer = 0;
            RemoveUrlaub(DateTime.Today);
            _Anfang = DateTime.Now;
        }
        public void Gehen()
        {
            status = 1;
            Arbeitszeit += (DateTime.Now - _Anfang).TotalMinutes;
        }
        public void SetNotizen(string Nachricht, DateTime Tag) => notizen.AddNotiz(Nachricht, Tag);
        public string GetNotiz(DateTime Tag) => notizen.GetNachricht(Tag);
        public void ReciveNachricht(string nachricht, object Anhang, Konto sender) => nachrichten.Recive(sender, nachricht, Anhang);
        public string[] GetAnzeige() => nachrichten.GetAnzeige();
        public string GetNachricht(int index) => nachrichten.GetNachricht(index);
        public object GetAnhang(int index) => nachrichten.GetAnhang(index);
        public Konto GetSender(int index) => nachrichten.GetSender(index);
        public int GetNachrichtenAnzahl() => nachrichten.GetAnzahl();
        public void RemoveNachricht(int index) => nachrichten.DeleteNachricht(index);
        public string GetZeiten() => "Mitarbeiter: "+Kontoinhaber+"\nArbeitszeit: " + Arbeitszeit + "\nUrlaubstage dieses Jahr: " + UrlaubsC + "\nKrankentage dieses Jahr: " + krankenC;
        public void SetStatus(int status)
        {
            if (status == 1 && this.status == 0) this.status = 1;
            else status = 0;
        }
        public void SetMaxTage(int MaxTage) => maxTage = MaxTage;
        public void SetTermin(DateTime von, DateTime bis, string Beschreibung) => tagesplan.SetTermin(von, bis, Beschreibung);
        public void SetTermin(DateTime von, DateTime bis, string Beschreibung,int index) => tagesplan.SetTermin(von, bis, Beschreibung,index);

        public DateTime GetTerminVon(int index) => tagesplan.GetVon(index);
        public DateTime GetTerminBis(int index) => tagesplan.GetBis(index);
        public string GetTerminBeschreibung(int index) => tagesplan.GetBeschreibung(index);
        public void DeleteTermin(int index) => tagesplan.DeleteBeschreibung(index);
        public int GetTerminAnzahl() => tagesplan.GetAnzahl();
        public void Neuer_Tag()
        {
            if (IsUrlaub(DateTime.Today)) { status = 3; UrlaubsC++; }

            if (Krankendauer != 0)
            {
                if (--Krankendauer == 0) status = 1;
                else { status = 2; Krankendauer++; }
            }

        }
    }
}
