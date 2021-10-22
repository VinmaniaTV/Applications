
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Applications.model
{
    public class Livreur {
        public int id
        {
            get { return id; }
            set { id = value; }
        }

        public Livreur(int id)
        {
            this.id = id;
        }

        public void livrer(Commande commande) {
            Random rnd = new Random();
            int random = rnd.Next(20);
            if (random == 15) {
                Console.WriteLine("Votre adresse est incorrecte");
                Console.WriteLine("Entrez votre adresse:");
                //commande.client.adress faire un set avec un console.WriteLine()
            }
            Console.WriteLine("Le livreur est entrain de vous apporter votre commande. Il arrivera dans " + random + " minutes");
            Task.Delay(random * 1000);
            Console.WriteLine("Le livreur est arrivé à votre adresse");
            commande.client.payer();
        }
    }
}