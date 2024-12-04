using System;
using System.Collections.Generic;
using ManipulationsAvancees; // Assurez-vous d'importer le namespace

namespace ManipulationsAvancees
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<ArticleTypé> articles = new List<ArticleTypé>
            {
                new ArticleTypé("Pomme", 2.5, 50, TypeArticle.Alimentaire),
                new ArticleTypé("Savon", 3.2, 30, TypeArticle.Droguerie),
                new ArticleTypé("T-shirt", 15.0, 20, TypeArticle.Habillement)
            };

            // Utilisation de la méthode d'extension
            articles.AfficherTous();
        }
    }
}
