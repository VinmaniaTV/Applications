
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using class Commande;

public class Client {
    public string nom;
    public string adresse;
    public string téléphone;
    public string datePremièreCommande;

    public Commande commandeActuelle;

    public Client(string nom, string adresse, string téléphone, string datePremièreCommande, Commande commandeActuelle)
    {

        this.nom = nom;
        this.adresse = adresse;
        this.téléphone = téléphone;
        this.datePremièreCommande = datePremièreCommande;
        this.commandeActuelle = commandeActuelle;
    }

    public void payer() {
        Task.Delay(3000);
        Console.WriteLine("Est ce que votre commande a été livrer?")
        String confirmation = Console.ReadLine();
        if (confirmation === 'No')
        {
            Console.WriteLine("Entrez de nouveau votre adresse:");
            string confAdresse = Console.ReadLine();
            if (adresse === confAdresse)
            {
                Console.WriteLine("Nous ne comprenons pas l'erreur. Notre livreur est à la bonne adresse. Veuillez nous excuser de ce désagréments");
            }
            else
            {
                Console.WriteLine("Le livreur n'était pas à la bonne adresse. Veuillez nous excusez.");
                Task.Delay(5000);
                Console.WriteLine("Est ce que votre commande a été livrer?")
                confirmation = Console.ReadLine();
                if (confirmation === 'No')
                {
                    Console.WriteLine("Entrez de nouveau votre adresse:");
                    string confAdresse2 = Console.ReadLine();
                    if (adresse === confAdresse2)
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

    public async void commander(List<String> pizza, List<String> boisson ) {
        await Task.Run(() => commandeActuelle.TransmettreCommande(pizza,boisson));
    }

}