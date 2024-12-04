namespace LesBases
{
    public class Video : Publication
    {
        public int Duree { get; set; }

        public Video(string nom, double prix, int quantite, int duree) : base(nom, prix)
        {
            Quantite = quantite;
            Duree = duree;
        }

        public int Quantite { get; set; }

        public override void PublishDetails()
        {
            Console.WriteLine($"Vidéo: {Nom}, Prix: {Prix}, Durée: {Duree} minutes, Quantité: {Quantite}");
        }
    }
}
