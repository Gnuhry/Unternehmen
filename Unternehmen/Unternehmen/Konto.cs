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
        private string benutzername, Kontoinhaber,Status,Email,Abteilung,Hobbys,Telefon;
        private byte[] passwort;
        private List<DateTime> Urlaubstage;
        private int Krankendauer, status, _Versuche, krankenC, UrlaubsC,maxTage;//0-gesperrt,1-Aktiv(Zuhause),2-Krank,3-Urlaub,4-Aktiv(arbeitend)
        private Image Profilbild;
        private double Arbeitszeit;
        private DateTime Geburtstag, _Anfang;
        private Notizen notizen;
        private Nachrichten nachrichten;
        private Tagesplan tagesplan;
        private Point[] Profil;

        public string Email1 { get => Email; set => Email = value; }
        public string Abteilung1 { get => Abteilung; set => Abteilung = value; }
        public string Telefon1 { get => Telefon; set => Telefon = value; }
       
        public Point[] Profil1 { get => Profil; set => Profil = value; }
        public string Status1 { get => Status; set => Status = value; }
        public string Hobbys1 { get => Hobbys; set => Hobbys = value; }

        public Konto()
        {
            tagesplan = new Tagesplan();
            Urlaubstage = new List<DateTime>();
            notizen = new Notizen();
            nachrichten = new Nachrichten();
            Arbeitszeit = Krankendauer = status = krankenC = UrlaubsC = 0;
            DefaultProfilAnzeige();
        }
        public void SetProfilbild(Image Profil) => Profilbild = Profil;

        private void DefaultProfilAnzeige()
        {
            Profil = new Point[8];
            Profil[0] = new Point(0, 0);
            Profil[1] = new Point(0, 0);
            Profil[2] = new Point(0, 0);
            Profil[3] = new Point(0, 0);
            Profil[4] = new Point(0, 0);
            Profil[5] = new Point(0, 0);
            Profil[6] = new Point(0, 0);
            Profil[7] = new Point(0, 0);
            Status = Email = Abteilung = Hobbys = Telefon = "";
           
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
                    return "No " + '"' + x[f] + '"';
            }
            if (!GrB) return "Missing capital letter";
            if (!KlB) return "Missing lower case letter";
            if (!Zahl) return "Missing number";
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
        public void SetInhaber(string KontoInhaber) => Kontoinhaber=KontoInhaber;
        public void SetGeburtstag(DateTime Geburtstag) => this.Geburtstag = Geburtstag;
        public int Login(string benutzername, string passwort) //0-erfolgreich; -1-Falscher Benutzername; -2-Falsches Passwort; -3-Gesperrt
        {
            if (benutzername != this.benutzername) return -1;
            if (_Versuche++ == 3||status==0)
            {
                status = 0; return -3;
            }
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
                case 0: return "locked";
                case 1: return "absent";
                case 2: return "Ill";
                case 3: return "Holiday";
                case 4: return "present";
                default: return "Error";
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
        public void ReciveNachricht(string nachricht, Image Anhang, Konto sender) => nachrichten.Recive(sender, nachricht, Anhang);
        public string[] GetAnzeige() => nachrichten.GetAnzeige();
        public string GetNachricht(int index) => nachrichten.GetNachricht(index);
        public Image GetAnhang(int index) => nachrichten.GetAnhang(index);
        public Konto GetSender(int index) => nachrichten.GetSender(index);
        public int GetNachrichtenAnzahl() => nachrichten.GetAnzahl();
        public void RemoveNachricht(int index) => nachrichten.DeleteNachricht(index);
        public DateTime GetSendeDatum(int index) => nachrichten.GetSendeDatum(index);
        public string GetZeiten() => "Employee: " + Kontoinhaber+"\nwork time: " + Arbeitszeit + "\nleave day this year: " + UrlaubsC + "\nday of illnes this year: " + krankenC;
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
