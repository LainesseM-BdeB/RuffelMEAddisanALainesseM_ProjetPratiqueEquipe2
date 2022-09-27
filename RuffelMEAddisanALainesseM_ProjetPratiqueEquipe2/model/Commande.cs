namespace RuffelMEAddisanALainesseM_ProjetPratiqueEquipe2.model;

public class Commande
{
    private int noCommande;
    private DateTime dateCommande;
    private int noClient;

    public Commande(DateTime dateCommande, int noClient)
    {
        this.dateCommande = dateCommande;
        this.noClient = noClient;
    }

    public Commande(int noCommande, DateTime dateCommande, int noClient)
    {
        this.noCommande = noCommande;
        this.dateCommande = dateCommande;
        this.noClient = noClient;
    }

    public int NoCommande => noCommande;

    public DateTime DateCommande
    {
        get => dateCommande;
        set => dateCommande = value;
    }

    public int NoClient
    {
        get => noClient;
        set => noClient = value;
    }
}