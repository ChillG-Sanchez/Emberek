package com.example;

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

public class Emberek {
    private List<Ember> emberek;

    // Konstruktor, amely konstans tömbök alapján feltölti a listát
    public Emberek() {
        emberek = new ArrayList<>();
        emberek.add(new Ember("Kovács János", "1990-01-01", "Budapest"));
        emberek.add(new Ember("Nagy Anna", "1985-05-15", "Debrecen"));
        emberek.add(new Ember("Szabó Péter", "2000-12-20", "Szeged"));
        emberek.add(new Ember("Tóth Gábor", "1975-03-10", "Miskolc"));
        emberek.add(new Ember("Horváth Éva", "1995-07-25", "Pécs"));
    }

    // Konstruktor, amely egy fájlból tölti be az adatokat
    public Emberek(String fajlNev) {
        emberek = new ArrayList<>();
        try (BufferedReader br = new BufferedReader(new FileReader(fajlNev))) {
            String sor;
            while ((sor = br.readLine()) != null) {
                String[] adatok = sor.split(";");
                if (adatok.length == 3) {
                    emberek.add(new Ember(adatok[0], adatok[1], adatok[2]));
                }
            }
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    // Metódus, amely megszámlálja a megadott hónapban született embereket
    public int szamolSzuletesHonap(int honap) {
        int szamlalo = 0;
        for (Ember ember : emberek) {
            if (ember.getSzuletesiHonap() == honap) {
                szamlalo++;
            }
        }
        return szamlalo;
    }

    // Metódus, amely meghatározza az átlagos életkort
    public double atlagEletkor() {
        int osszesEletkor = 0;
        for (Ember ember : emberek) {
            osszesEletkor += ember.getEletkor();
        }
        return (double) osszesEletkor / emberek.size();
    }

    // Metódus, amely kiszámítja az átlagos testtömeg indexet
    // Feltételezzük, hogy az Ember osztály tartalmazza a testtömeg indexet
    public double atlagTti() {
        double osszesTti = 0;
        for (Ember ember : emberek) {
            osszesTti += ember.getTti();
        }
        return osszesTti / emberek.size();
    }

    // Metódus, amely meghatározza a legfiatalabb ember nevét
    public String legfiatalabbNev() {
        Ember legfiatalabb = emberek.get(0);
        for (Ember ember : emberek) {
            if (ember.getSzuletesiEv() > legfiatalabb.getSzuletesiEv()) {
                legfiatalabb = ember;
            }
        }
        return legfiatalabb.getNev();
    }

    // Metódus, amely meghatározza a legidősebb ember sorszámát
    public int legidosebbSorszam() {
        int legidosebbIndex = 0;
        for (int i = 1; i < emberek.size(); i++) {
            if (emberek.get(i).getSzuletesiEv() < emberek.get(legidosebbIndex).getSzuletesiEv()) {
                legidosebbIndex = i;
            }
        }
        return legidosebbIndex;
    }

    // toString metódus, amely bejárja a teljes listát, és az abban található minden Ember objektum toStringjét egybefűzi, sortöréssel
    @Override
    public String toString() {
        StringBuilder sb = new StringBuilder();
        for (Ember ember : emberek) {
            sb.append(ember.toString()).append("\n");
        }
        return sb.toString();
    }
}