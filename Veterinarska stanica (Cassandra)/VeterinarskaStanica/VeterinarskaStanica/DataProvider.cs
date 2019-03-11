using Cassandra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinarskaStanica.Entiteti;

namespace VeterinarskaStanica
{
    public static class DataProvider
    {

        #region Doktor

        public static bool proveriDoktora(String korisnicko, String sifra)
        {
            ISession session = SessionManager.GetSession();

            Row tmp = session.Execute("select * from \"VeterinarskaStanica\"" + "." + "\"Doktor\" where \"korisnicko\"='" + korisnicko + "' and \"sifra\"='" + sifra + "' allow filtering").FirstOrDefault();

            if (tmp == null)
                return false;
            else
                return true;
        }

        public static Doktor vratiDoktora(String korisnicko, String sifra)
        {
            ISession session = SessionManager.GetSession();
            Doktor doktor = new Doktor();
            Row doc = session.Execute("select * from \"VeterinarskaStanica\"" + "." + "\"Doktor\" where \"korisnicko\"='" + korisnicko + "' and \"sifra\"='" + sifra + "' allow filtering").FirstOrDefault();

            if (doc == null)
                return null;

            doktor.id = Int32.Parse(doc["id"].ToString());
            doktor.prezime = doc["prezime"] != null ? doc["prezime"].ToString() : string.Empty;
            doktor.ime = doc["ime"] != null ? doc["ime"].ToString() : string.Empty;
            doktor.korisnicko = doc["korisnicko"] != null ? doc["korisnicko"].ToString() : string.Empty;
            doktor.sifra = doc["sifra"] != null ? doc["sifra"].ToString() : string.Empty;


            return doktor;
        }

        #endregion

        #region Ordinacija

        public static Ordinacija vratiOrdinaciju(int id)
        {
            ISession session = SessionManager.GetSession();
            Ordinacija ordinacija = new Ordinacija();

            Row tmp = session.Execute("select * from \"VeterinarskaStanica\"" + "." + "\"Ordinacija\" where \"id\"=" + id + " allow filtering").FirstOrDefault();

            if (tmp == null)
                return null;

            ordinacija.id = Int32.Parse(tmp["id"].ToString());
            ordinacija.tip = tmp["tip"] != null ? tmp["tip"].ToString() : string.Empty;


            return ordinacija;
        }

        public static Ordinacija vratiOrdinaciju(string tip)
        {
            ISession session = SessionManager.GetSession();
            Ordinacija ordinacija = new Ordinacija();

            Row tmp = session.Execute("select * from \"VeterinarskaStanica\"" + "." + "\"Ordinacija\" where \"tip\"= '" + tip + "' allow filtering").FirstOrDefault();

            if (tmp == null)
                return null;

            ordinacija.id = Int32.Parse(tmp["id"].ToString());
            ordinacija.tip = tmp["tip"] != null ? tmp["tip"].ToString() : string.Empty;


            return ordinacija;
        }

        public static List<Ordinacija> vratiOrdinacije()
        {
            ISession session = SessionManager.GetSession();
            List<Ordinacija> ordinacije = new List<Ordinacija>();

            var tmp = session.Execute("select * from \"VeterinarskaStanica\"" + "." + "\"Ordinacija\" ");

            if (tmp == null)
                return null;

            foreach (var o in tmp)
            {
                Ordinacija ordinacija = new Ordinacija();
                ordinacija.id = Int32.Parse(o["id"].ToString());
                ordinacija.tip = o["tip"] != null ? o["tip"].ToString() : string.Empty;

                ordinacije.Add(ordinacija);
            }

            return ordinacije;
        }

        public static void DodajOrdinaciju(Ordinacija o)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet vlasniklData = session.Execute("insert into \"VeterinarskaStanica\".\"Ordinacija\" (id, tip)  values (" + o.id + ", '" + o.tip + "')");
        }

        #endregion

        #region Vlasnik

        public static void AddVlasnik(Vlasnik vl)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet vlasniklData = session.Execute("insert into \"VeterinarskaStanica\".\"Vlasnik\" (id, ime, prezime, jmbg)  values (" + vl.id + ", '" + vl.ime + "', '" + vl.prezime + "', '" + vl.jmbg + "')");

        }
        public static Vlasnik GetVlasnik(int id)
        {
            ISession session = SessionManager.GetSession();
            Vlasnik vlasnik = new Vlasnik();

            if (session == null)
                return null;

            Row vlasnikData = session.Execute("select * from \"VeterinarskaStanica\".\"Vlasnik\" where id=" + id + "").FirstOrDefault();

            vlasnik.id = Int32.Parse(vlasnikData["id"].ToString());

            if (vlasnikData != null)
            {
                vlasnik.ime = vlasnikData["ime"] != null ? vlasnikData["ime"].ToString() : string.Empty;
                vlasnik.prezime = vlasnikData["prezime"] != null ? vlasnikData["prezime"].ToString() : string.Empty;
                vlasnik.jmbg = vlasnikData["jmbg"] != null ? vlasnikData["jmbg"].ToString() : string.Empty;
            }

            return vlasnik;
        }
        public static Vlasnik GetVlasnik(string jmbg)
        {
            ISession session = SessionManager.GetSession();
            Vlasnik vlasnik = new Vlasnik();

            if (session == null)
                return null;

            Row vlasnikData = session.Execute("select * from \"VeterinarskaStanica\".\"Vlasnik\" where jmbg='" + jmbg + "' allow filtering").FirstOrDefault();

            if (vlasnikData == null)
                return null;

            vlasnik.id = Int32.Parse(vlasnikData["id"].ToString());

            if (vlasnikData != null)
            {
                vlasnik.ime = vlasnikData["ime"] != null ? vlasnikData["ime"].ToString() : string.Empty;
                vlasnik.prezime = vlasnikData["prezime"] != null ? vlasnikData["prezime"].ToString() : string.Empty;
                vlasnik.jmbg = vlasnikData["jmbg"] != null ? vlasnikData["jmbg"].ToString() : string.Empty;
            }

            return vlasnik;
        }

        #endregion

        #region Zivotinja

        public static void AddZivotinja(Zivotinja ziv)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet zivotinjaData = session.Execute("insert into \"VeterinarskaStanica\".\"Zivotinja\" (id, vlasnikid, ime, vrsta, datumrodjenja)  values (" + ziv.id + ", " + ziv.vlasnikId + ", '" + ziv.ime + "', '" + ziv.vrsta + "', '" + ziv.datumRodjenja + "')");

        }
        public static void DeleteZivotinja(int id)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet zivotinjaData = session.Execute("delete from \"VeterinarskaStanica\".\"Zivotinja\" where id = " + id + "");

        }
        public static Zivotinja GetZivotinja(int id)
        {
            ISession session = SessionManager.GetSession();
            Zivotinja zivotinja = new Zivotinja();

            if (session == null)
                return null;

            Row zivotinjaData = session.Execute("select * from \"VeterinarskaStanica\".\"Zivotinja\" where id=" + id + "").FirstOrDefault();

            zivotinja.id = Int32.Parse(zivotinjaData["id"].ToString());
            zivotinja.vlasnikId = Int32.Parse(zivotinjaData["vlasnikid"].ToString());
            if (zivotinjaData != null)
            {
                zivotinja.ime = zivotinjaData["ime"] != null ? zivotinjaData["ime"].ToString() : string.Empty;
                zivotinja.datumRodjenja = zivotinjaData["datumrodjenja"] != null ? zivotinjaData["datumrodjenja"].ToString() : string.Empty;
                zivotinja.vrsta = zivotinjaData["vrsta"] != null ? zivotinjaData["vrsta"].ToString() : string.Empty;
            }

            return zivotinja;
        }
        public static List<Zivotinja> GetZivotinje()
        {
            ISession session = SessionManager.GetSession();
            List<Zivotinja> zivotinje = new List<Zivotinja>();


            if (session == null)
                return null;

            var zivotinjeData = session.Execute("select * from \"VeterinarskaStanica\".\"Zivotinja\"");

            if (zivotinjeData == null)
                return null;

            foreach (var zivotinjaData in zivotinjeData)
            {
                Zivotinja zivotinja = new Zivotinja();
                zivotinja.id = Int32.Parse(zivotinjaData["id"].ToString());
                zivotinja.vlasnikId = Int32.Parse(zivotinjaData["vlasnikid"].ToString());
                zivotinja.ime = zivotinjaData["ime"] != null ? zivotinjaData["ime"].ToString() : string.Empty;
                zivotinja.datumRodjenja = zivotinjaData["datumrodjenja"] != null ? zivotinjaData["datumrodjenja"].ToString() : string.Empty;
                zivotinja.vrsta = zivotinjaData["vrsta"] != null ? zivotinjaData["vrsta"].ToString() : string.Empty;
                zivotinje.Add(zivotinja);
            }



            return zivotinje;
        }

        #endregion

        #region Izvestaj


        public static void AddIzvestaj(Izvestaj iz)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet izvestajData = session.Execute("insert into \"VeterinarskaStanica\".\"Izvestaj\" (id, doktorid, zivotinjaid, ordinacijaid, izvestaj, datum, vrstaintervencije)  values (" + iz.id + ", " + iz.doktorId + ", " + iz.zivotinjaId + ", " + iz.ordinacijaId + ", '" + iz.izvestaj + "', '" + iz.datum + "', '" + iz.vrstaIntervencije + "')");

        }
        public static void DeleteIzvestaj(int id)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet zivotinjaData = session.Execute("delete from \"VeterinarskaStanica\".\"Izvestaj\" where id = " + id + "");

        }
        public static Izvestaj GetIzvestaj(int id)
        {
            ISession session = SessionManager.GetSession();
            Izvestaj izvestaj = new Izvestaj();

            if (session == null)
                return null;

            Row izvestajData = session.Execute("select * from \"VeterinarskaStanica\".\"Izvestaj\" where id=" + id + "").FirstOrDefault();

            izvestaj.id = Int32.Parse(izvestajData["id"].ToString());
            izvestaj.doktorId = Int32.Parse(izvestajData["doktorid"].ToString());
            izvestaj.ordinacijaId = Int32.Parse(izvestajData["ordinacijaid"].ToString());
            izvestaj.zivotinjaId = Int32.Parse(izvestajData["zivotinjaid"].ToString());
            if (izvestajData != null)
            {
                izvestaj.izvestaj = izvestajData["izvestaj"] != null ? izvestajData["izvestaj"].ToString() : string.Empty;
                izvestaj.datum = izvestajData["datum"] != null ? izvestajData["datum"].ToString() : string.Empty;
                izvestaj.vrstaIntervencije = izvestajData["vrstaintervencije"] != null ? izvestajData["vrstaintervencije"].ToString() : string.Empty;
            }

            return izvestaj;
        }
        public static List<Izvestaj> GetIzvestaji(int zivotinjaId)
        {
            ISession session = SessionManager.GetSession();
            List<Izvestaj> izvestaji = new List<Izvestaj>();


            if (session == null)
                return null;

            var izvestajiData = session.Execute("select * from \"VeterinarskaStanica\".\"Izvestaj\" where zivotinjaid=" + zivotinjaId + " allow filtering");


            foreach (var izvestajData in izvestajiData)
            {
                Izvestaj izvestaj = new Izvestaj();
                izvestaj.id = Int32.Parse(izvestajData["id"].ToString());
                izvestaj.zivotinjaId = Int32.Parse(izvestajData["zivotinjaid"].ToString());
                izvestaj.ordinacijaId = Int32.Parse(izvestajData["ordinacijaid"].ToString());
                izvestaj.doktorId = Int32.Parse(izvestajData["doktorid"].ToString());
                izvestaj.izvestaj = izvestajData["izvestaj"] != null ? izvestajData["izvestaj"].ToString() : string.Empty;
                izvestaj.datum = izvestajData["datum"] != null ? izvestajData["datum"].ToString() : string.Empty;
                izvestaj.vrstaIntervencije = izvestajData["vrstaintervencije"] != null ? izvestajData["vrstaintervencije"].ToString() : string.Empty;
                izvestaji.Add(izvestaj);
            }


            return izvestaji;
        }


        #endregion


        public static int NadjiID(String tabela)
        {
            ISession session = SessionManager.GetSession();

            int maxID = 0;

            Row hotelData = session.Execute("select max(\"id\") from \"VeterinarskaStanica\"" + "." + "\"" + tabela + "\" ").FirstOrDefault();

            if (hotelData != null && hotelData["system.max(id)"] != null)
            {
                maxID = Int32.Parse(hotelData["system.max(id)"].ToString());
            }

            return maxID;
        }

    }
}
