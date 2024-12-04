using System;
using System.Collections.Generic;

namespace ManipulationsAvancees
{
    public static class Extensions
    {
        public static void AfficherTous(this List<ArticleTypé> articles)
        {
            Console.WriteLine("--- Liste des Articles ---");
            foreach (var article in articles)
            {
                Console.WriteLine($"Nom: {article.Nom}, Prix: {article.Prix:F2} €, Quantité: {article.Quantite}, Type: {article.Type}");
            }
        }
    }
}
