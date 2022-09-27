namespace RuffelMEAddisanALainesseM_ProjetPratiqueEquipe2.model;

public class Livraison
{
    private int noLivraison;
    private DateTime dateLivraison;

    public Livraison(DateTime dateLivraison)
    {
        this.dateLivraison = dateLivraison;
    }

    public Livraison(int noLivraison, DateTime dateLivraison)
    {
        this.noLivraison = noLivraison;
        this.dateLivraison = dateLivraison;
    }

    public int NoLivraison => noLivraison;

    public DateTime DateLivraison
    {
        get => dateLivraison;
        set => dateLivraison = value;
    }
}