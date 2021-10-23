
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Applications.model
{
    public class Boisson
    {
        private string nom
        {
            get { return nom; }
            set { nom = value; }
        }
        private int volume
        {
            get { return volume; }
            set { volume = value; }
        }
        private int prix
        {
            get { return prix; }
            set { prix = value; }
        }

        public Boisson(string nom, int volume, int prix)
        {
            this.nom = nom;
            this.volume = volume;
            this.prix = prix;
        }
    }
}