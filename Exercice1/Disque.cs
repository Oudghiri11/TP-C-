namespace LesBases
{
    public class Disque : Publication
    {
        public string Label { get; set; }

        public Disque(string nom, double prix, int quantite, string label) : base(nom, prix)
        {
            Quantite = quantite;
            Label = label;
        }

        public int Quantite { get; set; }

        public override void PublishDetails()
        {
            Console.WriteLine($"Disque: {Nom}, Prix: {Prix}, Label: {Label}, Quantité: {Quantite}");
        }
    }
}
