
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Applications.model
{
    public class Commis {
        private string _nom;
        private int _nbrCommande;
        private Client _clientActuelle;
        private Commande _commandeActuelle;

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        public int NbrCommande
        {
            get { return _nbrCommande; }
            set { _nbrCommande = value; }
        }
        public Client ClientActuelle
        {
            get { return _clientActuelle; }
            set { _clientActuelle = value; }
        }
        public Commande CommandeActuelle
        {
            get { return _commandeActuelle; }
            set { _commandeActuelle = value; }
        }

        public Commis(string nom, int nbrCommande, Client clientActuelle, Commande commandeActuelle)
        {
            this.Nom = nom;
            this.NbrCommande = nbrCommande;
            this.ClientActuelle = clientActuelle;
            this.CommandeActuelle = commandeActuelle;
        }



        public async void questionner() {
            Console.WriteLine("Avez vous deja fait une commande dans notre restaurant auparavant?");
            String n = Console.ReadLine();
            if (n == "Yes")
            {
                Console.WriteLine("Quelle est votre numero de telephone?");
                String telephone = Console.ReadLine();
                System.Xml.Linq.XDocument doc = XDocument.Load(@"..\..\..\data\data.xml");
                String adr = from Client in doc.Root.Elements("Client")
                             where Client.Element("telephone").Value.Contains("0123456789")
                             select Client.Element("adresse").Value;
                Console.WriteLine("Votre adresse est-elle toujours" + adr + "?");
                String res = Console.ReadLine();
                if (res == "No")
                {
                    Console.WriteLine("Quelle est votre nouvelle adresse?");
                    String nouvelleAdresse = Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Quelle est votre nom?");
                String nom = Console.ReadLine();
                Console.WriteLine("Quelle est votre adresse?");
                String adresseClient = Console.ReadLine();
                Console.WriteLine("Quelle est votre t�l�phone?");
                String telephoneClient = Console.ReadLine();
                this.ClientActuelle = new Client(nom, adresseClient, telephoneClient, "");
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
                numeroDeCommande++;
                clientActuelle.commandeActuelle = new Commande(numeroDeCommande, DateTime.Now.ToString("HH:mm"), DateTime.Now, clientActuelle, this, listeDePizza + listeDeBoisson);
                
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
            Console.WriteLine("La commande a bien ete pris en compte");
            //Cuisnier cuisinier = recherche sur la base donn�es de cuisinier
            //await Task.Run(() => cuisinier.cuisiner(commandeActuelle));
            // Livreur livreur = recherche dans la base de donn�es de livreur
            Task.Delay(5000);
            //await Task.Run(() => livreur.livrer(commandeActuelle));
        }
    }
}