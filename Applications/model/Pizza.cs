
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Applications.model
{
    public class Pizza
    {
        public string nom;
        public string taille;
        public int time;
        public int prix;

        public Pizza(string nom, string taille, int time, int prix)
        {
            this.nom = nom;
            this.taille = taille;
            this.time = time;
            this.prix = prix;
        }
    }
}