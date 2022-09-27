using System;
using Oracle.ManagedDataAccess.Client;
public class CommandeDAO
{
	private OracleConnection connection = DBConnection.GetInstance();

	public CommandeDAO()
	{
	}
}
