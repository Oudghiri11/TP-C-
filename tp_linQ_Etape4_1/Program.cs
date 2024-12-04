using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace ExportJSON
{
    public class Program
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

            // Sérialisation de la liste d'articles en JSON
            string json = JsonSerializer.Serialize(articles, new JsonSerializerOptions { WriteIndented = true });

            // Export du JSON dans un fichier
            string cheminFichier = "articles.json";
            File.WriteAllText(cheminFichier, json);

            Console.WriteLine($"Liste des articles exportée vers le fichier {cheminFichier}");
        }
    }
}
