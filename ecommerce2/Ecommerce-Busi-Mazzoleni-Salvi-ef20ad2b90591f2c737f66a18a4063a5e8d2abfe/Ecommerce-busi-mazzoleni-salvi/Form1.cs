using System.Windows.Forms;

namespace Ecommerce_busi_mazzoleni_salvi
{
    public partial class Form1 : Form
    {
        private Prodotto prodotto;
        private Carrello carrello;


        public Form1()
        {
            InitializeComponent();
            prodotto = new Prodotto("1234", "Apple", "iPhone 16 Pro Max", 1800);
            carrello = new Carrello("789");
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AggiornaInterfaccia()
        {
            CARRELLO.DataSource = null;
            CARRELLO.DataSource = carrello.CarrelloList;
            CARRELLO.DisplayMember = "Modello";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            carrello.AggiungiProdotto(prodotto);
            AggiornaInterfaccia();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            carrello.RimuoviProdotto(prodotto);
            AggiornaInterfaccia();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            carrello.SvuotaCarrello();
            AggiornaInterfaccia();

        }
    }
}