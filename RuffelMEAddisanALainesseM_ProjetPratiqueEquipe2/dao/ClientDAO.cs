using System;

namespace RuffelMEAddisanALainesseM_ProjetPratiqueEquipe2.dao
{

	public class ClientDAO
	{
		OracleConnection connection = DBConnection.GetInstance();
		
		
		public ClientDAO()
		{

		}


		public void GetAllClient(String noClient, String nomClient, String noTelephone)
		{
			OracleCommand cmd = connection.CreateCommand;
			cmd.Connection = connection;
			cmd.CommandText = "SELECT noClient,nomClient,noTelephone FROM Client"
			OracleDataReader rd;
			try
			{
				connection.Open();
				rd = cmd.ExecuteReader();
				
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

		public void GetAllOrder()
		{
			OracleCommand cmd = connection.CreateCommand();
			cmd.CommandText = "SELECT Client.noClient, Client.nomClient, Commande.noCommande FROM Commande" +
			                  "INNER JOIN Client ON Commande.noClient=Client.noClient"
			OracleDataReader rd;
			try
			{
				connection.Open();
				rd = cmd.ExecuteReader();
			
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
}