using System.Numerics;

namespace RuffelMEAddisanALainesseM_ProjetPratiqueEquipe2.model;

public class Article
{
    private int noArticle;
    private string description;
    private BigInteger prixUnitaire;
    private int quantiteEnStock;

    public Article(string description, BigInteger prixUnitaire, int quantiteEnStock)
    {
        this.description = description;
        this.prixUnitaire = prixUnitaire;
        this.quantiteEnStock = quantiteEnStock;
    }

    public Article(int noArticle, string description, BigInteger prixUnitaire, int quantiteEnStock)
    {
        this.noArticle = noArticle;
        this.description = description;
        this.prixUnitaire = prixUnitaire;
        this.quantiteEnStock = quantiteEnStock;
    }

    public int NoArticle => noArticle;

    public string Description
    {
        get => description;
        set => description = value ?? throw new ArgumentNullException(nameof(value));
    }

    public BigInteger PrixUnitaire
    {
        get => prixUnitaire;
        set => prixUnitaire = value;
    }

    public int QuantiteEnStock
    {
        get => quantiteEnStock;
        set => quantiteEnStock = value;
    }
}