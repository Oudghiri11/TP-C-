namespace LesBases
{
    public class Livre : Publication
    {
        public int Pages { get; set; }

        public Livre(string nom, double prix, int quantite, int pages) : base(nom, prix)
        {
            Quantite = quantite;
            Pages = pages;
        }

        public int Quantite { get; set; }

        public override void PublishDetails()
        {
            Console.WriteLine($"Livre: {Nom}, Prix: {Prix}, Pages: {Pages}, Quantité: {Quantite}");
        }
    }
}
