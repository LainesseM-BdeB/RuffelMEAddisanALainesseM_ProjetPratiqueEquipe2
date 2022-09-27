using System;
using Oracle.ManagedDataAccess.Client;
using RuffelMEAddisanALainesseM_ProjetPratiqueEquipe2.model;

namespace RuffelMEAddisanALainesseM_ProjetPratiqueEquipe2.dao
{

	public class ClientDAO
	{
		private OracleConnection connection = DBConnection.GetInstance();
		
		
		public ClientDAO()
		{

		}

		public void InsertClient(Client client)
		{
			OracleCommand cmd = new OracleCommand();
			cmd.Connection = connection;
			cmd.CommandText = "INSERT INTO VENTE.CLIENT VALUES (:NOCLIENT, :NOMCLIENT, :NOTELEPHONE)";
			cmd.Parameters.Add(new OracleParameter("NOCOMMANDE", client.NoClient));
			cmd.Parameters.Add(new OracleParameter("NOARTICLE", client.NomClient));
			cmd.Parameters.Add(new OracleParameter("QUANTITE", client.NoTelephone));
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
		
		public void DeleteClientById(int noClient)
		{
			OracleCommand cmd = new OracleCommand();
			cmd.Connection = connection;
			cmd.CommandText = "DELETE FROM VENTE.CLIENT WHERE NOCLIENT = :NOCLIENT";
			cmd.Parameters.Add(new OracleParameter("NOCLIENT", noClient));
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
			
			OracleCommand cmd = connection.CreateCommand();
			cmd.CommandText = "SELECT cli.noclient, COUNT(cmd.noCommande) FROM commande cmd INNER JOIN client cli ON cmd.noClient = cli.noClient GROUP BY cli.noclient";
			OracleDataReader response = null;
			try
			{
				connection.Open();
				response = cmd.ExecuteReader();
				while (response.Read())
				{
					Console.Out.WriteLine("#######################");
					Console.Out.WriteLine(response[0]);
					Console.Out.WriteLine(response[1]);
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