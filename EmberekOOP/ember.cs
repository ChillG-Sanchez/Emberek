using System;

public class Ember
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

    public string Nev
    {
        get { return nev; }
        set { nev = value; }
    }

    public string SzulDatum
    {
        get { return szulDatum; }
        set { szulDatum = value; }
    } 

    public string SzulHely
    {
        get { return szulHely; }
        set { szulHely = value; }
    }

    public override string ToString()
    {
        return $"Név: {nev}\nSzületési dátum: {szulDatum}\nSzületési hely: {szulHely}";
    }
}