
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using class Commande;

public class Cuisinier {

    public string nom;

    public Cuisinier(string nom)
    {
        this.nom = nom;
    }

    public void Cuisiner(Commande commande) {
        int tempsDePréparation = // recherhe dans la base de donné à partir de get commande.items
        Task.Delay(tempsDePréparation * 1000);

    }



}