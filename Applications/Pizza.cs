
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Pizza {
am
    public string nom;
    public string taille;
    public int time; 
    public int prix;



    public string nom  {
    get { return nom;}
    set { nom = value; }  
    }

    public string taille   {
    get { return taille;}
    set { taille = value; }  
    }

    public int time   {
    get { return time;}
    set { time = value; }  
    } 

    public int prix   {
    get { return prix;}
    set { prix = value; }  
    }


    public Pizza(string nom, string time, int time, int prix)
    {
        this.nom = nom;
        this.taille = taille;
        this.time = time;
        this.prix = prix;
    }
}