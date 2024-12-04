using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace ImportJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Chemin du fichier JSON
            string cheminFichier = "articles.json";

            // Vérifier si le fichier existe
            if (!File.Exists(cheminFichier))
            {
                Console.WriteLine($"Le fichier {cheminFichier} n'existe pas. Assurez-vous d'avoir exporté les articles.");
                return;
            }

            // Lire le contenu du fichier JSON
            string json = File.ReadAllText(cheminFichier);

            // Désérialiser le JSON en une liste d'articles
            List<ArticleTypé> articles = JsonSerializer.Deserialize<List<ArticleTypé>>(json);

            // Afficher les articles
            Console.WriteLine("--- Articles chargés depuis le fichier JSON ---");
            foreach (var article in articles)
            {
                Console.WriteLine($"Nom: {article.Nom}, Prix: {article.Prix:F2} €, Quantité: {article.Quantite}, Type: {article.Type}");
            }
        }
    }

    // Définition de la classe ArticleTypé
    public enum TypeArticle
    {
        Alimentaire,
        Droguerie,
        Habillement
    }

    public class ArticleTypé
    {
        public string Nom { get; set; }
        public double Prix { get; set; }
        public int Quantite { get; set; }
        public TypeArticle Type { get; set; }

        public ArticleTypé(string nom, double prix, int quantite, TypeArticle type)
        {
            Nom = nom;
            Prix = prix;
            Quantite = quantite;
            Type = type;
        }
    }
}
