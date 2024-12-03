using System;
using System.Collections.Generic;

namespace LesBases
{
    public class Program
    {
        // Définition du délégué
        public delegate double DiscountStrategy(Publication article);

        // Stratégie 1 : Remise fixe en pourcentage
        public static double PercentageDiscount(Publication article)
        {
            const double discountRate = 0.10;
            return article.Prix * discountRate;
        }

        // Stratégie 2 : Remise pour les livres
        public static double BookDiscount(Publication article)
        {
            if (article is Livre)
            {
                const double discountRate = 0.15;
                return article.Prix * discountRate;
            }
            return 0;
        }

        // Stratégie 3 : Remise en fonction du prix
        public static double PriceBasedDiscount(Publication article)
        {
            if (article.Prix > 20)
            {
                return 5;
            }
            return 0;
        }

        public static void Main(string[] args)
        {
            // Liste de publications
            List<Publication> publications = new List<Publication>
            {
                new Livre("Harry Potter", 15.99, 10, 400),
                new Disque("Thriller", 9.99, 5, "Epic Records"),
                new Video("Inception", 19.99, 3, 150)
            };

            // Instances du délégué
            DiscountStrategy percentageDiscount = PercentageDiscount;
            DiscountStrategy bookDiscount = BookDiscount;
            DiscountStrategy priceBasedDiscount = PriceBasedDiscount;

            // Application des remises
            Console.WriteLine("--- Remises sur les Publications ---");

            foreach (var article in publications)
            {
                double remise1 = percentageDiscount(article);
                double remise2 = bookDiscount(article);
                double remise3 = priceBasedDiscount(article);

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
