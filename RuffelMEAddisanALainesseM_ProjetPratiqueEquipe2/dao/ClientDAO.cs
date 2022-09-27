using System;
using Oracle.ManagedDataAccess.Client;
using RuffelMEAddisanALainesseM_ProjetPratiqueEquipe2.model;

namespace RuffelMEAddisanALainesseM_ProjetPratiqueEquipe2.dao
{

	public class ClientDAO
	{
		OracleConnection connection = DBConnection.GetInstance();
		
		
		public ClientDAO()
		{

		}


		public void GetAllClient()
		{
			OracleCommand cmd = connection.CreateCommand();
			cmd.Connection = connection;
			cmd.CommandText = "SELECT noClient,nomClient,noTelephone FROM Client";
			OracleDataReader rd;
			try
			{
				connection.Open();
				OracleDataReader response = cmd.ExecuteReader();
				while (response.Read())
				{
					Console.Out.WriteLine("#######################");
					Console.Out.WriteLine(response["noClient"]);
					Console.Out.WriteLine(response["nomClient"]);
					Console.Out.WriteLine(response["noTelephone"]);
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

		public void GetAllOrder()
		{
			OracleConnection connection = DBConnection.GetInstance();
			OracleCommand query = connection.CreateCommand();
			query.CommandText = "SELECT cli.noClient, cli.nomClient, cmd.noCommande FROM commande cmd " +
			                    "INNER JOIN client cli ON cmd.noClient = cli.noClient";
			OracleDataReader response = null;
			try
			{
				connection.Open();
				response = query.ExecuteReader();
				while (response.Read())
				{
					Console.Out.WriteLine("#######################");
					Console.Out.WriteLine(response["noClient"]);
					Console.Out.WriteLine(response["nomClient"]);
					Console.Out.WriteLine(response["noCommande"]);
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
}