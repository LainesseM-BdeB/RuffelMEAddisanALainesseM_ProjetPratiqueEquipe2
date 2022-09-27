using System;

namespace RuffelMEAddisanALainesseM_ProjetPratiqueEquipe2.dao
{

	public class ClientDAO
	{
		public ClientDAO()
		{

		}


		public void GetAllClient(String noClient, String nomClient, String noTelephone)
		{
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
					Console.Out.WriteLine(response[noClient, nomClient, noTelephone]);
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

		public void GetAllOrder()
		{
			OracleConnection connection = DBConnection.GetInstance();
			OracleCommand query = connection.CreateCommand();
			query.CommandText = "SELECT Client.noClient, Client.nomClient, Commande.noCommande FROM Commande" +
			                    "INNER JOIN Client ON Commande.noClient=Client.noClient"
			OracleDataReader response = null;
			try
			{
				connection.Open();
				response = query.ExecuteReader();
				while (response.Read())
				{
					Console.Out.WriteLine(response[noClient, nomClient, noTelephone]);
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
}