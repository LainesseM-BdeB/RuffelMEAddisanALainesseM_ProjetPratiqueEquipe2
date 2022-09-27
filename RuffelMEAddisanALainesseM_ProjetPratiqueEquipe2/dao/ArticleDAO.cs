using System;
using Oracle.ManagedDataAccess.Client;
public class ArticleDAO	
{
	private OracleConnection connection = DBConnection.GetInstance();
	
	public ArticleDAO()
	{
	}
	
	public void InsertArticle(Article article)
	{
		OracleCommand cmd = new OracleCommand();
		cmd.Connection = connection;
		cmd.CommandText = "INSERT INTO VENTE.ARTICLE VALUES (:NOARTICLE, :DESCRIPTION, :PRIXUNITAIRE, :QUANITEENSTOCK)";
		cmd.Parameters.Add(new OracleParameter("NOARTICLE", ligneCommande.NoArticle));
		cmd.Parameters.Add(new OracleParameter("DESCRIPTION", livraison.Description));
		cmd.Parameters.Add(new OracleParameter("PRIXUNITAIRE", article.PrixUnitaire));
		cmd.Parameters.Add(new OracleParameter("QUANITEENSTOCK", article.QuantiteEnStock));
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
	
	public void DeleteArticleById(int noArticle)
	{
		OracleCommand cmd = new OracleCommand();
		cmd.Connection = connection;
		cmd.CommandText = "DELETE FROM VENTE.ARTICLE WHERE NOARTICLE = :NOARTICLE";
		cmd.Parameters.Add(new OracleParameter("NOARTICLE", noArticle));
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
