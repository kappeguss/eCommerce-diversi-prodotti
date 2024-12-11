using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_busi_mazzoleni_salvi
{
    internal class Prodotto
    {
        private string id;
        private string marca;
        private string modello;
        private double prezzo;

        public Prodotto(string id, string marca, string modello, double prezzo)
        {
            this.id = id;
            this.marca = marca;
            this.modello = modello;
            this.prezzo = prezzo;
        }

        public string Id { get { return id; } }
        public string Marca { get { return marca; } }
        public string Modello { get {  return modello; } }
        public double Prezzo { get { return prezzo; } set { prezzo = value; } }
      

    }
}

