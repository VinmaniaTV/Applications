
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
        public string nom;

        public Cuisinier(string nom)
        {
            this.nom = nom;
        }

        public void Cuisiner(Commande commande)
        {
            //int tempsDePr�paration = // recherhe dans la base de donn� � partir de get commande.items
            //Task.Delay(tempsDePr�paration * 1000);

        }
    }
}