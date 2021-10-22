
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using class Commande;

public class Livreur {
<<<<<<< Updated upstream
    public int id;
=======

    public int id   {
    get { return id;}
    set { id = value; }  
    }
>>>>>>> Stashed changes

    public Livreur(int id)
    {
        this.id = id;
    }

    public void livrer(Commande commande) {
        Random rnd new Random();
        int random = rnd.Nextext(20);
        if (random === 15) {
            Console.WriteLine("Votre adresse est incorrecte");
            Console.WriteLine("Entrez votre adresse:");
            commande.client.adresse = console.ReadLine();
        }
        Console.WriteLine('Le livreur est entrain de vous apporter votre commande. Il arrivera dans ' + random + 'minutes');
        Task.Delay(random * 1000);
        Console.WriteLine('Le livreur est arrivé à votre adresse');
        commande.client.payer();
    }
}