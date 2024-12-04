using System;
using System.Collections.Generic;
using System.Linq;

namespace FiltrageAvance
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Collection hétérogène : articles + autres types d'objets
            var collection = new List<object>
            {
                new ArticleTypé("Pomme", 2.5, 50, TypeArticle.Alimentaire),
                new ArticleTypé("Savon", 3.2, 30, TypeArticle.Droguerie),
                "Ceci est une chaîne de texte",
                42, // Entier
                new ArticleTypé("T-shirt", 15.0, 20, TypeArticle.Habillement),
                3.14 // Nombre flottant
            };

            // Utilisation de OfType<ArticleTypé>() pour extraire uniquement les articles typés
            var articles = collection.OfType<ArticleTypé>();

            // Affichage des articles extraits
            Console.WriteLine("--- Articles extraits de la collection ---");
            foreach (var article in articles)
            {
                Console.WriteLine($"{article.Nom}, Prix: {article.Prix}, Quantité: {article.Quantite}, Type: {article.Type}");
            }
        }
    }
}
