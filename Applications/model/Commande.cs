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
        private int _numero;
        private string _heure;
        private DateTime _date;
        private Commis _commis;
        private Client _client;
        private ArraySegment<String> _items;

        public int Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }
        public string Heure
        {
            get { return _heure; }
            set { _heure = value; }
        }
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public Commis Commis
        {
            get { return _commis; }
            set { _commis = value; }
        }
        public Client Client
        {
            get { return _client; }
            set { _client = value; }
        }
        public ArraySegment<String> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        public Commande(){
        }
        public Commande(int numero, string heure, DateTime date, Client client, Commis commis, ArraySegment<String> items)
        {
            this.Numero = numero;
            this.Heure = heure;
            this.Date = date;
            this.Client = client;
            this.Commis = commis;
            this.Items = items;
        }

        public void TransmettreCommande(ArraySegment<String> pizza, ArraySegment<String> boisson)
        {
            this.Items = pizza.Concat(boisson).ToArray();
        }
    }
}