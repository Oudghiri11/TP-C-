using System;
using System.Collections.Generic;

namespace SimplifiedDiscounts
{
    public class Publication
    {
        public string Nom { get; set; }
        public double Prix { get; set; }

        public Publication(string nom, double prix)
        {
            Nom = nom;
            Prix = prix;
        }
    }

    public class Livre : Publication
    {
        public Livre(string nom, double prix) : base(nom, prix) { }
    }

    public class Disque : Publication
    {
        public Disque(string nom, double prix) : base(nom, prix) { }
    }

    public class Video : Publication
    {
        public Video(string nom, double prix) : base(nom, prix) { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Liste de publications
            List<Publication> publications = new List<Publication>
            {
                new Livre("Harry Potter", 25.00),
                new Disque("Thriller", 9.99),
                new Video("Inception", 21.50)
            };

            // Remises comme fonctions lambda
            Func<Publication, double> remisePourcentage = article => article.Prix * 0.10; // 10% pour tous
            Func<Publication, double> remiseLivre = article => article is Livre ? article.Prix * 0.15 : 0; // 15% supplémentaires pour les livres
            Func<Publication, double> remisePrixEleve = article => article.Prix > 20 ? 5 : 0; // 5€ si prix > 20€

            // Application des remises
            Console.WriteLine("--- Calcul des Remises sur les Publications ---");

            foreach (var article in publications)
            {
                double remise1 = remisePourcentage(article);
                double remise2 = remiseLivre(article);
                double remise3 = remisePrixEleve(article);

                double totalRemise = remise1 + remise2 + remise3;
                double prixFinal = article.Prix - totalRemise;

                Console.WriteLine($"{article.Nom}:");
                Console.WriteLine($"  Prix initial: {article.Prix:F2} €");
                Console.WriteLine($"  Remise totale: {totalRemise:F2} €");
                Console.WriteLine($"  Prix final: {prixFinal:F2} €\n");
            }
        }
    }
}
