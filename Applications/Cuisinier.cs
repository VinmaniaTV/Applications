
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using class Commande;

public class Cuisinier {
<<<<<<< Updated upstream
    public string nom;
=======

    public string nom   {
    get { return nom;}
    set { nom = value; }  
    }
>>>>>>> Stashed changes

    public Cuisinier(string nom)
    {
        this.nom = nom;
    }

    public void Cuisiner(Commande commande) {
        int tempsDePr�paration = // recherhe dans la base de donn� � partir de get commande.items
        Task.Delay(tempsDePr�paration * 1000);

    }
}