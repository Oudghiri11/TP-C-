using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectionAnonyme
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

            // Projection en types anonymes (nom et prix seulement)
            var vueSimplifiee = articles.Select(a => new { a.Nom, a.Prix });

            // Affichage des types anonymes
            Console.WriteLine("--- Vue simplifiée des articles ---");
            foreach (var item in vueSimplifiee)
            {
                Console.WriteLine($"Nom: {item.Nom}, Prix: {item.Prix:F2} €");
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
