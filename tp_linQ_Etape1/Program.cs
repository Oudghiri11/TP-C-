using System;
using System.Collections.Generic;

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

        // Affichage des articles
        Console.WriteLine("--- Articles ---");
        foreach (var article in articles)
        {
            article.AfficherDetails();
        }
    }
}
