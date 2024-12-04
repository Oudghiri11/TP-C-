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

    // Constructeur
    public ArticleTypé(string nom, double prix, int quantite, TypeArticle type)
    {
        Nom = nom;
        Prix = prix;
        Quantite = quantite;
        Type = type;
    }

    // Méthode pour afficher les détails de l'article
    public void AfficherDetails()
    {
        Console.WriteLine($"Nom: {Nom}, Prix: {Prix}, Quantité: {Quantite}, Type: {Type}");
    }
}
