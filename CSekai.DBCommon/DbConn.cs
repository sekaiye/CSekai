using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace CSekai.DBCommon
{
    public class DbConn
    {
        public string dbType;
        public string MYSQL = "mysql";
        public string SQLSERVER = "sqlserver";
        public string ORACLE = "oracle";

        public DbConn()
        {
            dbType = GetDbType();
        }
        public string GetDbType()
        {
            return "mysql";
        }
        
        public string GetConnectionString()
        {
            string connStr = null;
            if (dbType.Equals(MYSQL)) {
                connStr = "server=localhost;database=csekai;user=root;password=Aa123456;SslMode = none;";
            }else if (dbType.Equals(ORACLE))
            {
                connStr = "Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)"
                            + "(HOST = 10.2.0.228)(PORT = 1521)))(CONNECT_DATA = (SERVICE_NAME = K3)));"
                            + " User Id = fgedev; Password = fgedev;";
            }
            return connStr;
        }
        public IDbConnection GetConnection()
        {
            IDbConnection conn = new MySqlConnection(GetConnectionString());
            conn.Open();
            return conn;
        }
        
    }
}
