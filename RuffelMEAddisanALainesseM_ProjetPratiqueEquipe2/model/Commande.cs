namespace RuffelMEAddisanALainesseM_ProjetPratiqueEquipe2.model;

public class Commande
{
    private int noCommande;
    private DateTime dateCommande;
    private int noClient;
    private Dictionary<int, LigneCommande> ligneCommandes = new Dictionary<int, LigneCommande>();

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

    public Dictionary<int, LigneCommande> LigneCommandes => ligneCommandes;

    public void ajouterLigneCommande(LigneCommande ligneCommande)
    {
        if (ligneCommande.NoCommande != NoCommande)
        {
            throw new Exception("Vous ne pouvez pas ajouter la ligne de commande car " +
                                "elle n'appartient pas à cette commande.\n" +
                                "NoCommande: " + NoCommande + " vs NoCommandeLigneCommande: " + ligneCommande.NoCommande);
        }

        if (LigneCommandes.ContainsKey(ligneCommande.NoArticle))
        {
            LigneCommandes[ligneCommande.NoArticle].Quantite += ligneCommande.Quantite;
        }
        else
        {
            LigneCommandes.Add(ligneCommande.NoArticle, ligneCommande);
        }
    }

    public class compareNoCommande : IComparer<Commande>
    {
        public int Compare(Commande commandeOne, Commande commandeTwo)
        {
            return commandeOne.NoCommande.CompareTo(commandeTwo.NoCommande);
        }
    }

}