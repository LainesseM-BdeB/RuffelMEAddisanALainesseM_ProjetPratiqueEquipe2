namespace RuffelMEAddisanALainesseM_ProjetPratiqueEquipe2.model;

public class Client
{
    private int noClient;
    private string nomClient;
    private string noTelephone;

    public Client(string nomClient, string noTelephone)
    {
        this.nomClient = nomClient;
        this.noTelephone = noTelephone;
    }

    public Client(int noClient, string nomClient, string noTelephone)
    {
        this.noClient = noClient;
        this.nomClient = nomClient;
        this.noTelephone = noTelephone;
    }

    public string NomClient
    {
        get => nomClient;
        set => nomClient = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string NoTelephone
    {
        get => noTelephone;
        set => noTelephone = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int NoClient => noClient;
}