using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Applications.model
{
    public class Commande
    {
        public int numéro
        {
            get { return numéro; }
            set { number = value; }
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

        public Commis commis
        {
            get { return commis; }
            set { commis = value; }
        }
        public Client client
        {
            get { return client; }
            set { client = value; }
        }

        public List<String> items
        {
            get { return items; }
            set { items = value; }
        }


        public Commande(int numéro, string heure, DateTime date, Client client, Commis commis, List<String> items)
        {
            this.numisro = numéro;
            this.heure = heure;
            this.date = date;
            this.client = client;
            this.commis = commis;
            this.items = items;
        }

        public void TransmettreCommande(List<String> pizza, List<String> boisson)
        {
            this.items = pizza + boisson;
            Commis.gestionCommande(commis.commandeActuelle);
        }
    }
}