
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Applications.model
{
    public class Client
    {
        private string _nom;
        private string _adresse;
        private string _telephone;
        private string _datePremiereCommande;
        private Commande _commandeActuelle;

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        public string Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }
        public string Telephone
        {
            get { return _telephone; }
            set { _telephone = value; }
        }
        public string DatePremiereCommande
        {
            get { return _datePremiereCommande; }
            set { _datePremiereCommande = value; }
        }
        public Commande CommandeActuelle
        {
            get { return _commandeActuelle; }
            set { _commandeActuelle = value; }
        }
        public Client()
        {

        }
        public Client(string nom, string Adresse, string telephone, string datePremiereCommande)
        {
            this.Nom = nom;
            this.Adresse = Adresse;
            this.Telephone = telephone;
            this.DatePremiereCommande = datePremiereCommande;
            this.CommandeActuelle = null;
        }
        public Client(string nom, string Adresse, string telephone, string datePremiereCommande, Commande commandeActuelle)
        {
            this.Nom = nom;
            this.Adresse = Adresse;
            this.Telephone = telephone;
            this.DatePremiereCommande = datePremiereCommande;
            this.CommandeActuelle = commandeActuelle;
        }


        public void payer()
        {
            Task.Delay(3000);
            Console.WriteLine("Est ce que votre commande a été livrée?");
            string confirmation = Console.ReadLine();
            if (confirmation == "No")
            {
                Console.WriteLine("Entrez de nouveau votre adresse:");
                string confAdresse =Console.ReadLine();
                if (Adresse == confAdresse)
                {
                    Console.WriteLine("Nous ne comprenons pas l'erreur. Notre livreur est à la bonne adresse. Veuillez nous excuser de ce désagréments");
                }
                else
                {
                    Console.WriteLine("Le livreur n'était pas à la bonne adresse. Veuillez nous excusez.");
                    Task.Delay(5000);
                    Console.WriteLine("Est ce que votre commande a été livrée?");
                    confirmation = Console.ReadLine();
                    if (confirmation == "No")
                    {
                        Console.WriteLine("Entrez de nouveau votre adresse:");
                        string confAdresse2 = Console.ReadLine();
                        if (Adresse == confAdresse2)
                        {
                            Console.WriteLine("Nous ne comprenons pas l'erreur. Notre livreur est à la bonne adresse. Veuillez nous excuser de ce désagréments");
                        }
                        else
                        {
                            Console.WriteLine("Merci pour achat en espérant vous revoir");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Merci pour achat en espérant vous revoir");
            }
        }

        public async void Commander(ArraySegment<String> pizza, ArraySegment<String> boisson)
        {
            await Task.Run(() => CommandeActuelle.TransmettreCommande(pizza, boisson));
        }
    }
}