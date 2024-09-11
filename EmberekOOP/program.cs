using System;

public class Program
{
    public static void Main(string[] args)
    {
        Ember ember1 = new Ember("Kovács János", "1990-01-01", "Budapest");
        Ember ember2 = new Ember("Nagy Anna", "1985-05-15", "Debrecen");
        Ember ember3 = new Ember("Szabó Péter", "2000-12-20", "Szeged");

        Console.WriteLine(ember1);
        Console.WriteLine(ember2);
        Console.WriteLine(ember3);

        ember1.Nev = "Kovács János Péter";
        ember2.SzulDatum = "1985-06-15";
        ember3.SzulHely = "Pécs";

        Console.WriteLine("\nMódosított adatok:");
        Console.WriteLine(ember1);
        Console.WriteLine(ember2);
        Console.WriteLine(ember3);
    }
}