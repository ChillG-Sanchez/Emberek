using System;

public class Program
{
    public static void Main(string[] args)
    {
        Ember ember1 = new Ember("Kovács János", "1990-01-01", "Budapest", GetRandomTestTomegIndex());
        Ember ember2 = new Ember("Nagy Anna", "1985-05-15", "Debrecen", GetRandomTestTomegIndex());
        Ember ember3 = new Ember("Szabó Péter", "2000-12-20", "Szeged", GetRandomTestTomegIndex());

        Console.WriteLine($"Születési hónapok:\n{ember1.GetSzuletesiHonap()}\n{ember2.GetSzuletesiHonap()}\n{ember3.GetSzuletesiHonap()}");
        Console.WriteLine($"Születési napok:\n{ember1.GetSzuletesiNap()}\n{ember2.GetSzuletesiNap()}\n{ember3.GetSzuletesiNap()}");

        Console.WriteLine($"Életkorok:\n{ember1.GetEletkor()}\n{ember2.GetEletkor()}\n{ember3.GetEletkor()}");

        Emberek emberek = new Emberek("emberek.txt");
        Console.WriteLine("Emberek listája:");
        Console.WriteLine(emberek);

        int month = 1;
        Console.WriteLine($"A {month}. hónapban született emberek száma: {emberek.CountByMonth(month)}");

        Console.WriteLine($"Az átlagos életkor: {emberek.GetAverageAge()} év");

        Console.WriteLine($"Az átlagos testtömegindex: {emberek.AtlagTestTomegIndex():F2}");

        Console.WriteLine($"A legfiatalabb ember: {emberek.GetYoungestPerson()}");

        Console.WriteLine($"A legidősebb ember sorszáma: {emberek.GetOldestPersonIndex()}");
    }

    // Metódus a random testtömeg index generálására
    private static double GetRandomTestTomegIndex()
    {
        Random rand = new Random();
        return rand.NextDouble() * (25.0 - 19.5) + 19.5;
    }
}