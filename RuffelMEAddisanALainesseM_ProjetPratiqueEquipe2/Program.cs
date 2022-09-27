using System.Numerics;
using Oracle.ManagedDataAccess.Client;
using RuffelMEAddisanALainesseM_ProjetPratiqueEquipe2.dao;
using RuffelMEAddisanALainesseM_ProjetPratiqueEquipe2.model;


// TEST Client + Commande + Article
Client client1 = new Client(1, "Maxime", "555-5555");
Client client2 = new Client(3, "John", "555-5555");
Client client3 = new Client(2, "Bob", "555-5555");

SortedSet<Client> clients = new SortedSet<Client>(new Client.compareNoClient());

clients.Add(client1);
clients.Add(client2);
clients.Add(client3);

foreach (var client in clients)
{
    Console.Out.WriteLine(client.NoClient);
}

Article article1 = new Article(1, "TEST", new BigInteger(10.00), 10);
Commande commande1 = new Commande(1, DateTime.Now, client1.NoClient);
commande1.ajouterLigneCommande(new LigneCommande(commande1.NoCommande, article1.NoArticle, 5));

foreach (var (key, value) in commande1.LigneCommandes)
{
    Console.Out.WriteLine("#Commande: " + value.NoCommande);
    Console.Out.WriteLine("#Article: " + value.NoArticle);
    Console.Out.WriteLine("Qté: " + value.Quantite);
}

commande1.ajouterLigneCommande(new LigneCommande(commande1.NoCommande, article1.NoArticle, 5));

foreach (var (key, value) in commande1.LigneCommandes)
{
    Console.Out.WriteLine("#Commande: " + value.NoCommande);
    Console.Out.WriteLine("#Article: " + value.NoArticle);
    Console.Out.WriteLine("Qté: " + value.Quantite);
}

Article article2 = new Article(2, "TEST", new BigInteger(5.00), 10);
commande1.ajouterLigneCommande(new LigneCommande(commande1.NoCommande, article2.NoArticle, 2));

foreach (var (key, value) in commande1.LigneCommandes)
{
    Console.Out.WriteLine("#Commande: " + value.NoCommande);
    Console.Out.WriteLine("#Article: " + value.NoArticle);
    Console.Out.WriteLine("Qté: " + value.Quantite);
}

// TEST Connection à la DB et recherche de données
OracleConnection connection = DBConnection.GetInstance();
OracleCommand query = new OracleCommand("SELECT * FROM client");
query.Connection = connection;
OracleDataReader response = null;
try
{
    connection.Open();
    response = query.ExecuteReader();
    while (response.Read())
    {
        Console.Out.WriteLine(response["nomclient"]);
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
    connection.Close();
}

// TEST Livraison + DetailLivraison
Livraison livraison1 = new Livraison(1, DateTime.Now);
livraison1.ajouterDetailLivraison(new DetailLivraison(1, 1, 3));
try
{
    livraison1.ajouterDetailLivraison(new DetailLivraison(1, 1, 5));
}
catch (Exception e)
{
    Console.Out.WriteLine(e.Message);
}
livraison1.modifierDetailLivraison(new DetailLivraison(1, 1, 5));
try {
livraison1.modifierDetailLivraison(new DetailLivraison(1, 2, 3));
}
catch (Exception e)
{
    Console.Out.WriteLine(e.Message);
}


// TEST LivraisonDAO insert and selectALL
LivraisonDAO livraisonDao = new LivraisonDAO();
Console.Out.WriteLine("\n\n###################################");
livraisonDao.GetLivraisonAll();
livraisonDao.InsertLivraison(new Livraison(99999, DateTime.Now));
Console.Out.WriteLine("\n\n###################################\nADDED 99999");
livraisonDao.GetLivraisonAll();
livraisonDao.DeleteLivraison(99999);
Console.Out.WriteLine("\n\n###################################\nDELETE 99999");
livraisonDao.GetLivraisonAll();

// TEST ClientDAO
ClientDAO clientDao = new ClientDAO();
clientDao.GetAllClient();
clientDao.GetAllOrder();

