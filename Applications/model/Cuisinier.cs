
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Applications.model
{
    public class Cuisinier
    {
        private string _nom;

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        public Cuisinier()
        {

        }
        public Cuisinier(string nom)
        {
            this.Nom = nom;
        }
        public void Cuisiner(Commande commande)
        {
            int tempsDePréparation = 15;
            Task.Delay(tempsDePréparation * 1000);

        }
    }
}