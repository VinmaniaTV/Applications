
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

using var reader = XmlReader.Create("data.xml");

namespace Applications.model
{
    public class Commis {

        private string nom
        {
            get { return nom; }
            set { nom = value; }
        }
        private int nbrCommande
        {
            get { return nbrCommande; }
            set { nbrCommande = value; }
        }
        private Client clientActuelle
        {
            get { return clientActuelle; }
            set { clientActuelle = value; }
        }
        private Commande commandeActuelle
        {
            get { return commandeActuelle; }
            set { commandeActuelle = value; }
        }


        public Commis(string nom, int nbrCommande, Client clientActuelle, Commande commandeActuelle)
        {
            this.nom = nom;
            this.nbrCommande = nbrCommande;
            this.clientActuelle = clientActuelle;
            this.commandeActuelle = commandeActuelle;
        }



        public async void questionner() {
            Console.WriteLine("Avez vous déja fait une commande dans notre restaurant auparavant?");
            String n = Console.ReadLine();
            if (n == "Yes")
            {
                Console.WriteLine("Quelle est votre numéro de téléphone?");
                String téléphone = Console.ReadLine();
                String adresse = 
                Console.WriteLine("Votre adresse est-elle troujours" + adresse + "?");
                String res = Console.ReadLine();
                if (res == "No")
                {
                    Console.WriteLine("Quelle est votre nouvelle adresse?");
                    String nouvellleAdresse = Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Quelle est votre nom?");
                String nom = Console.ReadLine();
                Console.WriteLine("Quelle est votre adresse?");
                String adresseClient = Console.ReadLine();
                Console.WriteLine("Quelle est votre téléphone?");
                String téléphoneClient = Console.ReadLine();
                clientActuelle = new Client(nom, adresseClient, téléphoneClient, "");
            }
            Console.WriteLine("Quelle pizza désirez vous? (Format: quantité_1, taille_1, nom_pizza_1, quantité_2, taille_2, nom_pizza_2)");
            String pizza = Console.ReadLine();
            Array listeDePizza = pizza.Split(',');
            Console.WriteLine("Désirez vous une boisson avec?");
            String resBoisson = Console.ReadLine();
            if (resBoisson == "Yes")
            {
                Console.WriteLine("Quelle boisson désirez vous? (Format: quantité_1 contenance(en cl) nom_boisson_1, quantité_2 boisson_2)");
                String boisson = Console.ReadLine();
                Array listeDeBoisson = boisson.Split(",");
                numéroDeCommande++;
                clientActuelle.commandeActuelle = new Commande(numéroDeCommande, DateTime.Now.ToString("HH:mm"), DateTime.Now, clientActuelle, this, listeDePizza + listeDeBoisson);
                
                await Task.Run(() => clientActuelle.commander(listeDePizza, listeDeBoisson));
            }
            else {
                await Task.Run(() => clientActuelle.commander(listeDePizza, []));
            }
        }
        public async void gestionCommande(Commande commande)
        {
            this.commandeActuelle = commande;
            this.nbrCommande += 1;
            Console.WriteLine("La commande a bien été pris en compte");
            //Cuisnier cuisinier = recherche sur la base données de cuisinier
            //await Task.Run(() => cuisinier.cuisiner(commandeActuelle));
            // Livreur livreur = recherche dans la base de données de livreur
            Task.Delay(5000);
            //await Task.Run(() => livreur.livrer(commandeActuelle));
        }
    }
}