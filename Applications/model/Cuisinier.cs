
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

        private Cuisinier(string nom)
        {
            this.Nom = nom;
        }
        private void Cuisiner(Commande commande)
        {
            //int tempsDePr�paration = // recherhe dans la base de donn� � partir de get commande.items
            //Task.Delay(tempsDePr�paration * 1000);

        }
    }
}