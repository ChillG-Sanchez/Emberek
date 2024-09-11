using System;

namespace EmberekOOP
{
    class Ember
    {
        private string nev;
        private string szulDatum;
        private string szulHely;

        public Ember(string nev, string szulDatum, string szulHely)
        {
            this.nev = nev;
            this.szulDatum = szulDatum;
            this.szulHely = szulHely;
        }

        public int GetSzuletesiEv()
        {
            return int.Parse(szulDatum.Substring(0, 4));
        }

        public int GetSzuletesiHonap()
        {
            string[] dateParts = szulDatum.Split('-');
            return int.Parse(dateParts[1]);
        }

        public int GetSzuletesiNap()
        {
            return int.Parse(szulDatum.Split('-')[2]);
        }

        public int GetEletkor()
        {
            int currentYear = DateTime.Now.Year;
            return currentYear - GetSzuletesiEv();
        }

        public override string ToString()
        {
            return $"Név: {nev}\nSzületési dátum: {szulDatum}\nSzületési hely: {szulHely}";
        }
    }
}