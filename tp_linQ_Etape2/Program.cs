using System;
using System.Collections.Generic;
using System.Linq;

namespace SimplifiedDiscounts
{
    class Program
    {
        static void Main(string[] args)
        {
            // Liste d'articles
            List<ArticleTypé> articles = new List<ArticleTypé>
            {
                new ArticleTypé("Pomme", 2.5, 50, TypeArticle.Alimentaire),
                new ArticleTypé("Savon", 3.2, 30, TypeArticle.Droguerie),
                new ArticleTypé("T-shirt", 15.0, 20, TypeArticle.Habillement)
            };

            // a. Lister les articles Alimentaires
            var alimentaires = articles.Where(a => a.Type == TypeArticle.Alimentaire);
            Console.WriteLine("--- Articles Alimentaires ---");
            foreach (var article in alimentaires)
            {
                Console.WriteLine($"{article.Nom}, Prix: {article.Prix}, Quantité: {article.Quantite}");
            }

            // b. Trier les articles par prix décroissant
            var articlesTries = articles.OrderByDescending(a => a.Prix);
            Console.WriteLine("\n--- Articles triés par prix décroissant ---");
            foreach (var article in articlesTries)
            {
                Console.WriteLine($"{article.Nom}, Prix: {article.Prix}, Quantité: {article.Quantite}");
            }

            // c. Calculer le stock total
            var stockTotal = articles.Sum(a => a.Quantite);
            Console.WriteLine($"\n--- Stock total : {stockTotal} articles ---");
        }
    }
}
