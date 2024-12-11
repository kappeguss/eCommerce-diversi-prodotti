using System;
using System.Collections.Generic;

namespace Ecommerce_busi_mazzoleni_salvi
{
    internal class Carrello
    {
        private string id;  
        private List<Prodotto> carrelloList;

        public string Id { get { return id; } }
        public List<Prodotto> CarrelloList { get { return carrelloList; } }

        public void AggiungiProdotto(Prodotto prodotto)
        {
            if (prodotto == null) return;

            carrelloList.Add(prodotto);
        }

        public void RimuoviProdotto(Prodotto prodotto)
        {
            if (prodotto == null) return;
            carrelloList.Remove(prodotto);
        }

        public void SvuotaCarrello()
        {
            carrelloList.Clear();
        }

        public Carrello(string id)
        {
            this.id = id;
            carrelloList = new List<Prodotto>();
        }
    }
}
