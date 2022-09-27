using System;
using Oracle.ManagedDataAccess.Client;
using RuffelMEAddisanALainesseM_ProjetPratiqueEquipe2.model;
public class CommandeDAO
{
	private OracleConnection connection = DBConnection.GetInstance();

	public CommandeDAO()
	{
	}
	
	public void InsertCommande(Commande commande)
	{
		OracleCommand cmd = new OracleCommand();
		cmd.Connection = connection;
		cmd.CommandText = "INSERT INTO VENTE.COMMANDE VALUES (:NOCOMMANDE, :DATECOMMANDE, :NOCLIENT)";
		cmd.Parameters.Add(new OracleParameter("NOCOMMANDE", commande.NoCommande));
		cmd.Parameters.Add(new OracleParameter("DATECOMMANDE", commande.DateCommande));
		cmd.Parameters.Add(new OracleParameter("NOCLIENT", commande.NoClient));
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
