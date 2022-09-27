using System.Numerics;
using Oracle.ManagedDataAccess.Client;
using RuffelMEAddisanALainesseM_ProjetPratiqueEquipe2.dao;
using RuffelMEAddisanALainesseM_ProjetPratiqueEquipe2.model;

#region Test ClientDAO

ClientDAO clientDao = new ClientDAO();
Client client1 = new Client(99999, "ClientTest", "555-5555");
clientDao.InsertClient(client1);
clientDao.GetAllClient();

#endregion

#region Test ArticleDAO

ArticleDAO articleDao = new ArticleDAO();
Article article1 = new Article(99999, "ArticleTest", new BigInteger(9.99), 10);
articleDao.InsertArticle(article1);
articleDao.GetAllArticle();

#endregion

#region Test CommandeDAO

CommandeDAO commandeDao = new CommandeDAO();
Commande commande1 = new Commande(99999, DateTime.Now, 99999);
commandeDao.InsertCommande(commande1);
//commandeDao.GetAllCommande();

#endregion

#region Test LigneCommandeDAO

LigneCommandeDAO ligneCommandeDao = new LigneCommandeDAO();
LigneCommande ligneCommande1 = new LigneCommande(99999, 99999, 10);
ligneCommandeDao.InsertLigneCommande(ligneCommande1);
//ligneCommandeDao.GetAllLigneCommande();

#endregion

#region Test LivraisonDAO

LivraisonDAO livraisonDao = new LivraisonDAO();
Livraison livraison1 = new Livraison(99999, DateTime.Now);
livraisonDao.InsertLivraison(livraison1);
livraisonDao.GetLivraisonAll();


#endregion

#region Test DetailLivraisonDAO

DetailLivraisonDAO detailLivraisonDao = new DetailLivraisonDAO();
DetailLivraison detailLivraison1 = new DetailLivraison(99999, 99999, 99999, 10);
detailLivraisonDao.InsertDetailLivraison(detailLivraison1);
detailLivraisonDao.GetDetailLivraisonAll();

#endregion


#region Test Delete All Insert

detailLivraisonDao.DeleteDetailLivraisonById(99999, 99999, 99999);
detailLivraisonDao.GetDetailLivraisonAll();
livraisonDao.DeleteLivraisonById(99999);
livraisonDao.GetLivraisonAll();
ligneCommandeDao.DeleteLigneCommandeById(99999, 99999);
//ligneCommandeDao.GetAllLigneCommande();
commandeDao.DeleteCommandeById(99999);
//commandeDao.GetAllCommande();
articleDao.DeleteArticleById(99999);
articleDao.GetAllArticle();
clientDao.DeleteClientById(99999);
clientDao.GetAllClient();

#endregion