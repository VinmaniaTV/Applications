
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
<<<<<<< Updated upstream:Applications/model/Commande.cs
=======
using class Commis;
using class Client;

public class Commande {

    public int numéro;
    public string heure;
    public DateTime date;


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


    public Client client;
    public Commis commis;

    public List<String> items;


    public List<String> items   {
    get { return items;}
    set(List<String> list) { items = value; }  
    }


    public Commande(int numéro, string heure, DateTime date, Client client, Commis commis, List<String> items)
    {
        this.numéro = numéro;
        this.heure = heure;
        this.date = date;
        this.client = client;
        this.commis = commis;
        this.items = items;        
    }
>>>>>>> Stashed changes:Applications/Commande.cs

namespace Applications.model
{
    public class Commande {
        public int numéro
        {
            get { return numéro; }
            set { numéro = value; }
        }

        public string heure
        {
            get { return heure; }
            set { heure = value; }
        }

        public DateTime date
        {
            get { return date; }
            set { date = value; }
        }
        public Client client;
        public Commis commis;
        public List<String> items {
            get { return items; }
            set { items = value; }
        }


        public Commande()
        {

        }
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
            //this.items = pizza + boisson;
            //commis.gestionCommande(//get commis.commandeActuelle);
        }
    }
}