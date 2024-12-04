namespace LesBases
{
    
    public class Article
    {
        public string Nom { get; set; }
        public double Prix { get; set; }
        public int Quantite { get; set; }

        // Constructeur
        public Article(string nom, double prix, int quantite)
        {
            Nom = nom;
            Prix = prix;
            Quantite = quantite;
        }

        // Méthodes
        public void Afficher()
        {
            Console.WriteLine($"Nom: {Nom}, Prix: {Prix}, Quantité: {Quantite}");
        }

        public void Ajouter(int quantite)
        {
            if (quantite > 0)
            {
                Quantite += quantite;
                Console.WriteLine($"{quantite} ajoutés à l'article {Nom}. Quantité actuelle: {Quantite}");
            }
            else
            {
                Console.WriteLine("La quantité doit être un nombre entier positif.");
            }
        }

        public void Retirer(int quantite)
        {
            if (quantite > 0 && Quantite >= quantite)
            {
                Quantite -= quantite;
                Console.WriteLine($"{quantite} retirés de l'article {Nom}. Quantité restante: {Quantite}");
            }
            else
            {
                Console.WriteLine("La quantité à retirer doit être un nombre entier positif et ne pas dépasser la quantité disponible.");
            }
        }
    }
}
