namespace LesBases
{
    public abstract class Publication
    {
        public string Nom { get; set; }
        public double Prix { get; set; }

        // Constructeur
        public Publication(string nom, double prix)
        {
            Nom = nom;
            Prix = prix;
        }

        // Méthode abstraite
        public abstract void PublishDetails();
    }
}
