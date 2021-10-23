
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
        public Commis()
        {

        }
        public Commis(string nom, int nbrCommande)
        {
            this.Nom = nom; 
            this.NbrCommande = nbrCommande; 
        }

        public Commis(string nom, int nbrCommande, Client clientActuelle, Commande commandeActuelle)
        {
            this.Nom = nom;
            this.NbrCommande = nbrCommande;
            this.ClientActuelle = clientActuelle;
            this.CommandeActuelle = commandeActuelle;
        }



        public async void questionner() {
            Console.WriteLine("Quelle est votre nom?");
            String nom = Console.ReadLine();
            Console.WriteLine("Quelle est votre adresse?");
            String adresseClient = Console.ReadLine();
            Console.WriteLine("Quelle est votre telephone?");
            String telephoneClient = Console.ReadLine();
            this.ClientActuelle = new Client(nom, adresseClient, telephoneClient, "");
            Pizza pizza1 = new Pizza("Fromage", "petite", 10, 10);
            Pizza pizza2 = new Pizza("Fromage", "moyenne", 15, 20);
            Pizza pizza3 = new Pizza("Fromage", "grande", 20, 30);
            Pizza pizza4 = new Pizza("Royale", "petite", 10, 10);
            Pizza pizza5 = new Pizza("Royale", "moyenne", 15, 20);
            Pizza pizza6 = new Pizza("Royale", "grande", 20, 30);
            Console.WriteLine("Fromage(pettite)   10euros");
            Console.WriteLine("Fromage(moyenne)   15euros");
            Console.WriteLine("Fromage(grande)    20euros");
            Console.WriteLine("Royale(pettite)   15euros");
            Console.WriteLine("Royale(moyenne)   20euros");
            Console.WriteLine("Royale(grande)    30euros");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Quelle pizza desirez vous? (Format: quantite_1, taille_1, nom_pizza_1, quantite_2, taille_2, nom_pizza_2)");
            String pizza = Console.ReadLine();
            ArraySegment<String> listeDePizza = pizza.Split(',');
            Console.WriteLine("Desirez vous une boisson avec? (yes or no)");
            String resBoisson = Console.ReadLine();
            if (resBoisson == "yes")
            {
                Console.WriteLine("Quelle boisson desirez vous? (Format: quantite_1, contenance(en cl), nom_boisson_1)");
                String boisson = Console.ReadLine();
                ArraySegment<String> listeDeBoisson = boisson.Split(",");
                //NbrCommande++;
                
                ClientActuelle.CommandeActuelle = new Commande(1, DateTime.Now.ToString("HH:mm"), DateTime.Now, ClientActuelle, this, listeDePizza);
                this.ClientActuelle.Commander(listeDePizza, listeDeBoisson, ClientActuelle.CommandeActuelle);
            }
            else {
                ClientActuelle.CommandeActuelle = new Commande(1, DateTime.Now.ToString("HH:mm"), DateTime.Now, ClientActuelle, this, listeDePizza);
                this.ClientActuelle.Commander(listeDePizza, null, ClientActuelle.CommandeActuelle);
            }
            await Task.Run(() => this.gestionCommande());
        }
        public async void gestionCommande()
        {
            NbrCommande += 1;
            Console.WriteLine("La commande a bien ete prise en compte");
            Cuisinier cuisinier = new Cuisinier("JU");
            
            await Task.Run(() => cuisinier.Cuisiner(CommandeActuelle));
            this.gestionLivraison();
        }
        
        public async void gestionLivraison()
        {
            Livreur livreur = new Livreur("GE");
            await Task.Run(() => livreur.Livrer(CommandeActuelle));
            this.ClientActuelle.Payer();
        }
    }
}