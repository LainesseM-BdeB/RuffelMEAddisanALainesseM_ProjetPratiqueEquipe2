using System;
using Oracle.ManagedDataAccess.Client;
public class DetailLivraisonDAO
{
	private OracleConnection connection = DBConnection.GetInstance();

	public DetailLivraisonDAO()
	{
	}
	
	public void InsertDetailLivraison(DetailLivraison detailLivraison)
	{
		OracleCommand cmd = new OracleCommand();
		cmd.Connection = connection;
		cmd.CommandText = "INSERT INTO VENTE.DETAILLIVRAISON VALUES (:NOLIVRAISON, :NOCOMMANDE, :NOARTICLE, :QUANTITELIVREE")";
		cmd.Parameters.Add(new OracleParameter("NOLIVRAISON", detailLivraison.NoDetailLivraison));
		cmd.Parameters.Add(new OracleParameter("NOCOMMANDE", detailLivraison.NoCommande));
		cmd.Parameters.Add(new OracleParameter("NOARTICLE", detailLivraison.NoArticle));
		cmd.Parameters.Add(new OracleParameter("QUANTITELIVREE", detailLivraison.QuantiteLivree));
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
	public void DeleteDetailLivraisonById(int noLivraison)
	{
		OracleCommand cmd = new OracleCommand();
		cmd.Connection = connection;
		cmd.CommandText = "DELETE FROM Livraison WHERE NOLIVRAISON = :NOLIVRAISON";
		cmd.Parameters.Add(new OracleParameter("NOLIVRAISON", noLivraison));
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
