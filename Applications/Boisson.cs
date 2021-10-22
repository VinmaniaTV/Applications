
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Boisson {
    public string nom;
    public int volume;
    public int prix;

    public Boisson(string nom, int volume, int prix)
    {
        this.nom = nom;
        this.volume = volume;
        this.prix = prix;
    }
}