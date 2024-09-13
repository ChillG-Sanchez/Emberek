using System;

public class Ember
{
    private string nev;
    private string szulDatum;
    private string szulHely;
    private double testTomegIndex;

    public Ember(string nev, string szulDatum, string szulHely, double testTomegIndex)
    {
        this.nev = nev;
        this.szulDatum = szulDatum;
        this.szulHely = szulHely;
        this.testTomegIndex = testTomegIndex;
    }

    public int GetSzuletesiEv()
    {
        return int.Parse(szulDatum.Split('-')[0]);
    }

    public int GetSzuletesiHonap()
    {
        return int.Parse(szulDatum.Split('-')[1]);
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

    public double GetTestTomegIndex()
    {
        return testTomegIndex;
    }

    public override string ToString()
    {
        return $"Név: {nev}\nSzületési dátum: {szulDatum}\nSzületési hely: {szulHely}\nTesttömeg index: {testTomegIndex:F2}";
    }
}