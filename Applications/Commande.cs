
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using class Commis;
using class Client;

public class Commande {
<<<<<<< Updated upstream
    public int numéro;
    public string heure;
    public DateTime date;
=======

    public int numéro   {
    get { return numéro;}
    set { numéro = value; }  
    }

    public string heure   {
    get { return heure;}
    set { heure = value; }  
    }

    public DateTime date   {
    get { return date;}
    set { date = value; }  
    }

>>>>>>> Stashed changes
    public Client client;
    public Commis commis;
<<<<<<< Updated upstream
    public List<String> items;
=======

    public List<String> items   {
    get { return items;}
    set(List<String> list) { items = value; }  
    }
>>>>>>> Stashed changes


    public Commande(int numéro, string heure, DateTime date, Client client, Commis commis, List<String> items)
    {
        this.numéro = numéro;
        this.heure = heure;
        this.date = date;
        this.client = client;
        this.commis = commis;
        this.items = items;        
    }

    public void TransmettreCommande(List<String> pizza, List<String> boisson)
    {
       items.set(pizza+boisson)
        commis.gestionCommande( commis.commandeActuelle);
    }
}