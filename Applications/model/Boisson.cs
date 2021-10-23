
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Applications.model
{
    public class Boisson
    {
        private string _nom;
        private int _volume;
        private int _prix;

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        public int Volume
        {
            get { return _volume; }
            set { _volume = value; }
        }
        public int Prix
        {
            get { return _prix; }
            set { _prix = value; }
        }

        public Boisson(string nom, int volume, int prix)
        {
            this.Nom = nom;
            this.Volume = volume;
            this.Prix = prix;
        }
    }
}