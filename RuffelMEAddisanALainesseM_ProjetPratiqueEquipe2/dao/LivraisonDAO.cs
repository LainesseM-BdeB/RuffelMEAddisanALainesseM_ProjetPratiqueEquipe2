using System;
public class LivraisonDAO
{
	public LivraisonDAO()
	{
		InsertLivraison(Livraison livraison)
		{
			OracleConnection connection = DBConnection.GetInstance();
			OracleCommand cmd = new OracleCommand();
			cmd.Connection = connection;
			cmd.CommandText = "INSERT INTO VENTE.LIVRAISON VALUES (:NOLIVRAISON, :DATELIVRAISON");
			cmd.Parameters.Add(new OracleParameter("NOLIVRAISON", livraison.NoLivraison));
			cmd.Parameters.Add(new OracleParameter("DATELIVRAISON", livraison.DateLivraison));
			connection.Open();
			cmd.ExecuteNonQuery();
			connection.Close();
		}
	}
}
