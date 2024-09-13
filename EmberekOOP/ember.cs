using System;

public class Ember
{
    private string nev;
    private string szulDatum;
    private string szulHely;
    private double testTomegIndex;

    // Paraméteres konstruktor
    public Ember(string nev, string szulDatum, string szulHely, double testTomegIndex)
    {
        this.nev = nev;
        this.szulDatum = szulDatum;
        this.szulHely = szulHely;
        this.testTomegIndex = testTomegIndex;
    }

    // Metódus a születési év visszaadására
    public int GetSzuletesiEv()
    {
        return int.Parse(szulDatum.Split('-')[0]);
    }

    // Metódus a születési hónap visszaadására
    public int GetSzuletesiHonap()
    {
        return int.Parse(szulDatum.Split('-')[1]);
    }

    // Metódus a születési nap visszaadására
    public int GetSzuletesiNap()
    {
        return int.Parse(szulDatum.Split('-')[2]);
    }

    // Metódus az életkor meghatározására
    public int GetEletkor()
    {
        int currentYear = DateTime.Now.Year;
        return currentYear - GetSzuletesiEv();
    }

    // Metódus a testtömeg index visszaadására
    public double GetTestTomegIndex()
    {
        return testTomegIndex;
    }

    // Tagolt ToString metódus
    public override string ToString()
    {
        return $"Név: {nev}\nSzületési dátum: {szulDatum}\nSzületési hely: {szulHely}\nTesttömeg index: {testTomegIndex:F2}";
    }
}