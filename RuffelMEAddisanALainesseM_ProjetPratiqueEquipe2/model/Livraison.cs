namespace RuffelMEAddisanALainesseM_ProjetPratiqueEquipe2.model;

public class Livraison
{
    private int noLivraison;
    private DateTime dateLivraison;
    private Dictionary<int, DetailLivraison> detailsLivraison = new Dictionary<int, DetailLivraison>();

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

    public Dictionary<int, DetailLivraison> DetailsLivraison => detailsLivraison;

    public DateTime DateLivraison
    {
        get => dateLivraison;
        set => dateLivraison = value;
    }

    public void ajouterDetailLivraison(DetailLivraison detailLivraison)
    {
        if (DetailsLivraison.ContainsKey(detailLivraison.NoArticle))
        {
            throw new Exception(
                "Un détail pour cet article existe déjà.\n" +
                "Veuillez utiliser modifierDetailLivraison() pour faire des changements."
                );
        }
        DetailsLivraison.Add(detailLivraison.NoArticle, detailLivraison);
    }

    public void modifierDetailLivraison(DetailLivraison detailLivraison)
    {
        if (!DetailsLivraison.ContainsKey(detailLivraison.NoArticle))
        {
            throw new Exception("Aucun détail de Livraison existant à modifier.\n" +
                                "Veuillez utiliser ajouterDetailLivraison()."
                                );
        }

        DetailsLivraison[detailLivraison.NoArticle] = detailLivraison;
    }
    
}