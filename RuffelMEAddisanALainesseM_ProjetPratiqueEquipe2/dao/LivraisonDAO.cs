﻿using System;
using Oracle.ManagedDataAccess.Client;
using RuffelMEAddisanALainesseM_ProjetPratiqueEquipe2.model;
public class LivraisonDAO
{
	OracleConnection connection = DBConnection.GetInstance();
	public LivraisonDAO()
	{
	}
	
	
	public void InsertLivraison(Livraison livraison)
	{
		OracleCommand cmd = new OracleCommand();
		cmd.Connection = connection;
		cmd.CommandText = "INSERT INTO VENTE.LIVRAISON VALUES (:NOLIVRAISON, :DATELIVRAISON)";
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

	public void DeleteLivraison(int noLivraison)
	{
		Oracle cmd = new OracleCommand();
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
	
	public void GetLivraisonAll()
	{
		OracleCommand cmd = new OracleCommand();
		cmd.Connection = connection;
		cmd.CommandText = "SELECT * FROM livraison";
		try
		{
			connection.Open();
			OracleDataReader response = cmd.ExecuteReader();
			while (response.Read())
			{
				Console.Out.WriteLine(response["datelivraison"]);
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
