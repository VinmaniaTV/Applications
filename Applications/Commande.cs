
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using class Commis;
using class Client;

public class Commande {
    public int numéro;
    public string heure;
    public DateTime date;
    public Client client;
    public Commis commis;
    public List<String> items;


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
        this.items = pizza + boisson;
        commis.gestionCommande(//get commis.commandeActuelle);
    }
}