package com.example;

import java.time.LocalDate;

public class Ember {
    private String nev;
    private String szulDatum;
    private String szulHely;
    private double tti; 

    public Ember(String nev, String szulDatum, String szulHely) {
        this.nev = nev;
        this.szulDatum = szulDatum;
        this.szulHely = szulHely;
        this.tti = Math.random() * 10 + 18;
    }

    public String getNev() {
        return nev;
    }

    public void setNev(String nev) {
        this.nev = nev;
    }

    public String getSzulDatum() {
        return szulDatum;
    }

    public void setSzulDatum(String szulDatum) {
        this.szulDatum = szulDatum;
    }

    public String getSzulHely() {
        return szulHely;
    }

    public void setSzulHely(String szulHely) {
        this.szulHely = szulHely;
    }

    public double getTti() {
        return tti;
    }

    public void setTti(double tti) {
        this.tti = tti;
    }

    public int getSzuletesiEv() {
        return Integer.parseInt(szulDatum.split("-")[0]);
    }

    public int getSzuletesiHonap() {
        return Integer.parseInt(szulDatum.split("-")[1]);
    }

    public int getSzuletesiNap() {
        return Integer.parseInt(szulDatum.split("-")[2]);
    }

    public int getEletkor() {
        int szuletesiEv = getSzuletesiEv();
        int aktualisEv = LocalDate.now().getYear();
        return aktualisEv - szuletesiEv;
    }

    @Override
    public String toString() {
        return "Név: " + nev + "\nSzületési dátum: " + szulDatum + "\nSzületési hely: " + szulHely + "\nTTI: " + tti;
    }
}