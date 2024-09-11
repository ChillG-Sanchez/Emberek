using System;

namespace EmberekOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Ember ember1 = new Ember("Kovács János", "1980-01-01", "Budapest");
            Ember ember2 = new Ember("Nagy Anna", "1990-05-15", "Debrecen");
            Ember ember3 = new Ember("Szabó Péter", "2000-12-24", "Szeged");

            Console.WriteLine(ember1);
            Console.WriteLine(ember2);
            Console.WriteLine(ember3);

            Console.WriteLine($"Születési évek:\n{ember1.GetSzuletesiEv()}\n{ember2.GetSzuletesiEv()}\n{ember3.GetSzuletesiEv()}");
            Console.WriteLine($"Születési hónapok:\n{ember1.GetSzuletesiHonap()}\n{ember2.GetSzuletesiHonap()}\n{ember3.GetSzuletesiHonap()}");
            Console.WriteLine($"Születési napok:\n{ember1.GetSzuletesiNap()}\n{ember2.GetSzuletesiNap()}\n{ember3.GetSzuletesiNap()}");

            Console.WriteLine($"Életkorok:\n{ember1.GetEletkor()}\n{ember2.GetEletkor()}\n{ember3.GetEletkor()}");

            Emberek emberek = new Emberek("emberek.txt");
            Console.WriteLine("Emberek listája:");
            Console.WriteLine(emberek);

            int month = 3;
            Console.WriteLine($"A {month}. hónapban született emberek száma: {emberek.CountByMonth(month)}");

            Console.WriteLine($"Az átlagos életkor: {emberek.GetAverageAge()} év");

            Console.WriteLine($"A legfiatalabb ember: {emberek.GetYoungestPerson()}");

            Console.WriteLine($"A legidősebb ember sorszáma: {emberek.GetOldestPersonIndex()}");
        }
    }
}