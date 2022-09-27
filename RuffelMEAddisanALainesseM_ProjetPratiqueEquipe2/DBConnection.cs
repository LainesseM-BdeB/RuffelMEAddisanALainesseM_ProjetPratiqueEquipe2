using System;
using Oracle.ManagedDataAccess.Client;

public sealed class DBConnection
{
	private static OracleConnection oracleConnection = null;
	private static readonly object cadenas = new object();

	private DBConnection()
	{
		string conParam = "DATA SOURCE=144.217.163.57:1521/XE; USER ID=vente; Password=anypw";
		oracleConnection = new OracleConnection();
		oracleConnection.ConnectionString = conParam;
	}

	public static OracleConnection GetInstance()
    {
		if (oracleConnection == null)
        {
			lock (cadenas)
            {
	           new DBConnection();
            }
        }

		return oracleConnection;
    }
}
