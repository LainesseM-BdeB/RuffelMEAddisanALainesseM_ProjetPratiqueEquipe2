namespace RuffelMEAddisanALainesseM_ProjetPratiqueEquipe2.model;

public class DetailLivraison
{
    private int noDetailLivraison;
    private int noCommande;
    private int noArticle;
    private int quantiteLivree;

    public DetailLivraison(int noCommande, int noArticle, int quantiteLivree)
    {
        this.noCommande = noCommande;
        this.noArticle = noArticle;
        this.quantiteLivree = quantiteLivree;
    }

    public DetailLivraison(int noDetailLivraison, int noCommande, int noArticle, int quantiteLivree)
    {
        this.noDetailLivraison = noDetailLivraison;
        this.noCommande = noCommande;
        this.noArticle = noArticle;
        this.quantiteLivree = quantiteLivree;
    }

    public int NoDetailLivraison => noDetailLivraison;

    public int NoCommande => noCommande;

    public int NoArticle => noArticle;

    public int QuantiteLivree
    {
        get => quantiteLivree;
        set => quantiteLivree = value;
    }
    
    
}