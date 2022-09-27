namespace RuffelMEAddisanALainesseM_ProjetPratiqueEquipe2.model;

public class LigneCommande
{
    private int noCommande;
    private int noArticle;
    private int quantite;

    public LigneCommande(int noArticle, int quantite)
    {
        this.noArticle = noArticle;
        this.quantite = quantite;
    }

    public LigneCommande(int noCommande, int noArticle, int quantite)
    {
        this.noCommande = noCommande;
        this.noArticle = noArticle;
        this.quantite = quantite;
    }

    public int NoCommande => noCommande;

    public int NoArticle => noArticle;
    
    public int Quantite
    {
        get => quantite;
        set => quantite = value;
    }
}