
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Applications.model
{
    public class Livreur {
        private String _nom;

        public String Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public Livreur(string nom)
        {
            this.Nom = nom;
        }
        public void Livrer(Commande commande) {
            Random rnd = new Random();
            int random = rnd.Next(20);
            if (random == 15) {
                Console.WriteLine("Votre adresse est incorrecte");
                Console.WriteLine("Entrez votre adresse:");
                commande.Client.Adresse = Console.ReadLine();
            }
            Console.WriteLine("Le livreur est entrain de vous apporter votre commande. Il arrivera dans " + random + " minutes");
            Task.Delay(random * 1000).Wait();
            Console.WriteLine("Le livreur est arrivé à votre adresse");
        }
    }
}