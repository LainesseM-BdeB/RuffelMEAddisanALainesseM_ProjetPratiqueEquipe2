using System;
public class LivraisonDAO
{
	OracleConnection connection = DBConnection.GetInstance();
	public LivraisonDAO()
	{
	}
	
	void InsertLivraison(Livraison livraison)
	{
		OracleCommand cmd = new OracleCommand();
		cmd.Connection = connection;
		cmd.CommandText = "INSERT INTO VENTE.LIVRAISON VALUES (:NOLIVRAISON, :DATELIVRAISON");
		cmd.Parameters.Add(new OracleParameter("NOLIVRAISON", livraison.NoLivraison));
		cmd.Parameters.Add(new OracleParameter("DATELIVRAISON", livraison.DateLivraison));
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
