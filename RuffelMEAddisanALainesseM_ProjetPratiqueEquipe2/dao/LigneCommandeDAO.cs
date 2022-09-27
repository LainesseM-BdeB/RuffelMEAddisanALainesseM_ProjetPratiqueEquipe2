using System;
using Oracle.ManagedDataAccess.Client;
using RuffelMEAddisanALainesseM_ProjetPratiqueEquipe2.model;
public class LigneCommandeDAO
{
	private OracleConnection connection = DBConnection.GetInstance();
	public LigneCommandeDAO()
	{
		
	}
	
	public void InsertLigneCommande(LigneCommande ligneCommande)
	{
		OracleCommand cmd = new OracleCommand();
		cmd.Connection = connection;
		cmd.CommandText = "INSERT INTO VENTE.LIGNECOMMANDE VALUES (:NOCOMMANDE, :NOARTICLE, :QUANTITE)";
		cmd.Parameters.Add(new OracleParameter("NOCOMMANDE", ligneCommande.NoCommande));
		cmd.Parameters.Add(new OracleParameter("NOARTICLE", ligneCommande.NoArticle));
		cmd.Parameters.Add(new OracleParameter("QUANTITE", ligneCommande.Quantite));
		try
		{
			connection.Open();
			cmd.ExecuteNonQuery();
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
		}
		finally
		{
			connection.Close();
		}
	}
	
	// A FINIR	
	public void DeleteLigneCommandeById(int noCommande, int noArticle)
	{
		OracleCommand cmd = new OracleCommand();
		cmd.Connection = connection;
		cmd.CommandText = "DELETE FROM VENTE.LIGNECOMMANDE WHERE NOCOMMANDE = :NOCOMMANDE AND NOARTICLE = :NOARTICLE";
		cmd.Parameters.Add(new OracleParameter("NOCOMMANDE", noCommande));
		cmd.Parameters.Add(new OracleParameter("NOARTICLE", noArticle));
		try
		{
			connection.Open();
			cmd.ExecuteNonQuery();

		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
		}
		finally
		{
			connection.Close();
		}
	}
}
