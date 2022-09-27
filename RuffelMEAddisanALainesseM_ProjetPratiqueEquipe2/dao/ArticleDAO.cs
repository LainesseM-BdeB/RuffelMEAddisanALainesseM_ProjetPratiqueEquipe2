using System;
using Oracle.ManagedDataAccess.Client;
public class ArticleDAO	
{
	private OracleConnection connection = DBConnection.GetInstance();
	
	public ArticleDAO()
	{
	}
}
