
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
            Console.WriteLine("Avez vous d�ja fait une commande dans notre restaurant auparavant?");
            String n = Console.ReadLine();
            if (n == "Yes")
            {
                Console.WriteLine("Quelle est votre num�ro de t�l�phone?");
                String t�l�phone = Console.ReadLine();
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
                Console.WriteLine("Quelle est votre t�l�phone?");
                String t�l�phoneClient = Console.ReadLine();
                clientActuelle = new Client(nom, adresseClient, t�l�phoneClient, "");
            }
            Console.WriteLine("Quelle pizza d�sirez vous? (Format: quantit�_1, taille_1, nom_pizza_1, quantit�_2, taille_2, nom_pizza_2)");
            String pizza = Console.ReadLine();
            Array listeDePizza = pizza.Split(',');
            Console.WriteLine("D�sirez vous une boisson avec?");
            String resBoisson = Console.ReadLine();
            if (resBoisson == "Yes")
            {
                Console.WriteLine("Quelle boisson d�sirez vous? (Format: quantit�_1 contenance(en cl) nom_boisson_1, quantit�_2 boisson_2)");
                String boisson = Console.ReadLine();
                Array listeDeBoisson = boisson.Split(",");
                num�roDeCommande++;
                clientActuelle.commandeActuelle = new Commande(num�roDeCommande, DateTime.Now.ToString("HH:mm"), DateTime.Now, clientActuelle, this, listeDePizza + listeDeBoisson);
                
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
            Console.WriteLine("La commande a bien �t� pris en compte");
            //Cuisnier cuisinier = recherche sur la base donn�es de cuisinier
            //await Task.Run(() => cuisinier.cuisiner(commandeActuelle));
            // Livreur livreur = recherche dans la base de donn�es de livreur
            Task.Delay(5000);
            //await Task.Run(() => livreur.livrer(commandeActuelle));
        }
    }
}