
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Applications.model
{
    public class Pizza
    {
        private string _nom;
        private string _taille;
        private int _time;
        private int _prix;

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        public string Taille
        {
            get { return _taille; }
            set { _taille = value; }
        }
        public int Time
        {
            get { return _time; }
            set { _time = value; }
        }
        public int Prix
        {
            get { return _prix; }
            set { _prix = value; }
        }

        public Pizza(string nom, string taille, int time, int prix)
        {
            this.Nom = nom;
            this.Taille = taille;
            this.Time = time;
            this.Prix = prix;
        }
    }
}