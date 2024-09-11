package com.example;

public class EmberekOOP {
    public static void main(String[] args) {
        // Három különböző objektumpéldány létrehozása
        Ember ember1 = new Ember("Kovács János", "1990-01-01", "Budapest");
        Ember ember2 = new Ember("Nagy Anna", "1985-05-15", "Debrecen");
        Ember ember3 = new Ember("Szabó Péter", "2000-12-20", "Szeged");

        // Objektumok kiíratása
        System.out.println(ember1);
        System.out.println(ember2);
        System.out.println(ember3);

        // Születési évek, hónapok és napok kiíratása
        System.out.println("\nSzületési évek:");
        System.out.println(ember1.getSzuletesiEv() + " " + ember2.getSzuletesiEv() + " " + ember3.getSzuletesiEv());

        System.out.println("\nSzületési hónapok:");
        System.out.println(ember1.getSzuletesiHonap() + " " + ember2.getSzuletesiHonap() + " " + ember3.getSzuletesiHonap());

        System.out.println("\nSzületési napok:");
        System.out.println(ember1.getSzuletesiNap() + " " + ember2.getSzuletesiNap() + " " + ember3.getSzuletesiNap());

        // Életkorok kiíratása
        System.out.println("\nÉletkorok:");
        System.out.println(ember1.getEletkor() + " " + ember2.getEletkor() + " " + ember3.getEletkor());

        // Emberek osztály példányosítása és kiíratása fájlból
        Emberek emberek = new Emberek("emberek.txt");
        System.out.println("\nEmberek listája:");
        System.out.println(emberek);

        // Új metódusok meghívása és eredményeik kiíratása
        System.out.println("\nJanuárban született emberek száma: " + emberek.szamolSzuletesHonap(1));
        System.out.println("Átlagos életkor: " + emberek.atlagEletkor());
        System.out.println("Átlagos testtömeg index: " + emberek.atlagTti());
        System.out.println("Legfiatalabb ember neve: " + emberek.legfiatalabbNev());
        System.out.println("Legidősebb ember sorszáma: " + emberek.legidosebbSorszam());
    }
}