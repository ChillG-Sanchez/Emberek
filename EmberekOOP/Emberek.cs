using System;
using System.Collections.Generic;
using System.Linq;

public class Emberek
{
    private List<Ember> emberek;

    public Emberek()
    {
        emberek = new List<Ember>
        {
            new Ember("Kovács János", "1990-01-01", "Budapest", GetRandomTestTomegIndex()),
            new Ember("Nagy Anna", "1985-05-15", "Debrecen", GetRandomTestTomegIndex()),
            new Ember("Szabó Péter", "2000-12-20", "Szeged", GetRandomTestTomegIndex()),
            new Ember("Tóth Gábor", "1975-03-10", "Miskolc", GetRandomTestTomegIndex()),
            new Ember("Horváth Éva", "1995-07-25", "Pécs", GetRandomTestTomegIndex())
        };
    }

    public Emberek(string fajlNev)
    {
        emberek = new List<Ember>();
        try
        {
            string[] sorok = System.IO.File.ReadAllLines(fajlNev);
            foreach (string sor in sorok)
            {
                string[] adatok = sor.Split(';');
                if (adatok.Length == 4)
                {
                    emberek.Add(new Ember(adatok[0], adatok[1], adatok[2], double.Parse(adatok[3])));
                }
                else if (adatok.Length == 3)
                {
                    emberek.Add(new Ember(adatok[0], adatok[1], adatok[2], GetRandomTestTomegIndex()));
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Hiba történt a fájl beolvasása közben: {e.Message}");
        }
    }

    public int CountByMonth(int honap)
    {
        return emberek.Count(e => e.GetSzuletesiHonap() == honap);
    }

    public double GetAverageAge()
    {
        return emberek.Average(e => e.GetEletkor());
    }

    public double AtlagTestTomegIndex()
    {
        return emberek.Average(e => e.GetTestTomegIndex());
    }

    public string GetYoungestPerson()
    {
        return emberek.OrderBy(e => e.GetEletkor()).First().ToString();
    }

    public int GetOldestPersonIndex()
    {
        return emberek.IndexOf(emberek.OrderByDescending(e => e.GetEletkor()).First());
    }

    public override string ToString()
    {
        string result = "";
        foreach (var ember in emberek)
        {
            result += ember.ToString() + "\n";
        }
        return result;
    }

    private double GetRandomTestTomegIndex()
    {
        Random rand = new Random();
        return rand.NextDouble() * (25.0 - 19.5) + 19.5;
    }
}