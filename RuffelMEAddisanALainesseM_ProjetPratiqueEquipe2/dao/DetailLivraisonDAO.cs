using System;
using Oracle.ManagedDataAccess.Client;
using RuffelMEAddisanALainesseM_ProjetPratiqueEquipe2.model;
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
		cmd.CommandText = "INSERT INTO VENTE.DETAILLIVRAISON VALUES (:NOLIVRAISON, :NOCOMMANDE, :NOARTICLE, :QUANTITELIVREE)";
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
			Console.WriteLine(e.StackTrace);
		}
		finally
		{
			connection.Close();
		}
	}
	
	
	public void DeleteDetailLivraisonById(int noLivraison, int noCommande, int noArticle)
	{
		OracleCommand cmd = new OracleCommand();
		cmd.Connection = connection;
		cmd.CommandText = "DELETE FROM detaillivraison WHERE nolivraison = :nolivraison AND nocommande = :nocommande AND noarticle = :noarticle";
		cmd.Parameters.Add(new OracleParameter("nolivraison", noLivraison));
		cmd.Parameters.Add(new OracleParameter("nocommande", noCommande));
		cmd.Parameters.Add(new OracleParameter("noarticle", noArticle));
		try
		{
			connection.Open();
			cmd.ExecuteNonQuery();

		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
			Console.WriteLine(e.StackTrace);
		}
		finally
		{
			connection.Close();
		}
	}
	
	
	public void GetDetailLivraisonAll()
	{
		OracleCommand cmd = new OracleCommand();
		cmd.Connection = connection;
		cmd.CommandText = "SELECT * FROM detaillivraison";
		try
		{
			connection.Open();
			OracleDataReader response = cmd.ExecuteReader();
			while (response.Read())
			{
				Console.Out.WriteLine("#######################");
				Console.Out.WriteLine(response["nolivraison"]);
				Console.Out.WriteLine(response["nocommande"]);
				Console.Out.WriteLine(response["noarticle"]);
				Console.Out.WriteLine("#######################\n");
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
	}
}
