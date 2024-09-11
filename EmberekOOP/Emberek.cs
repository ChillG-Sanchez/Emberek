using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EmberekOOP
{
    class Emberek
    {
        private List<Ember> emberek;

        public Emberek(string fileName)
        {
            emberek = new List<Ember>();
            LoadFromFile(fileName);
        }

        private void LoadFromFile(string fileName)
        {
            try
            {
                string[] lines = File.ReadAllLines(fileName);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(';');
                    if (parts.Length == 3)
                    {
                        string nev = parts[0].Trim();
                        string szulDatum = parts[1].Trim();
                        string szulHely = parts[2].Trim();
                        emberek.Add(new Ember(nev, szulDatum, szulHely));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hiba történt a fájl beolvasása közben: {ex.Message}");
            }
        }

        public int CountByMonth(int month)
        {
            return emberek.Count(e => e.GetSzuletesiHonap() == month);
        }

        public double GetAverageAge()
        {
            return emberek.Average(e => e.GetEletkor());
        }

        public string GetYoungestPerson()
        {
            var youngest = emberek.OrderByDescending(e => e.GetSzuletesiEv()).ThenByDescending(e => e.GetSzuletesiHonap()).ThenByDescending(e => e.GetSzuletesiNap()).First();
            return youngest.ToString();
        }

        public int GetOldestPersonIndex()
        {
            var oldest = emberek.OrderByDescending(e => e.GetSzuletesiEv()).ThenByDescending(e => e.GetSzuletesiHonap()).ThenByDescending(e => e.GetSzuletesiNap()).Last();
            return emberek.IndexOf(oldest);
        }

        public override string ToString()
        {
            string result = "";
            foreach (var ember in emberek)
            {
                result += ember.ToString() + Environment.NewLine;
            }
            return result;
        }
    }
}