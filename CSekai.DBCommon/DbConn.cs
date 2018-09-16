using System;

namespace CSekai.DBCommon
{
    public class DbConn
    {
        public string GetConnectionString()
        {
            string connStr = "Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)"
                            + "(HOST = 10.2.0.228)(PORT = 1521)))(CONNECT_DATA = (SERVICE_NAME = K3)));"
                            + " User Id = fgedev; Password = fgedev;";
            connStr = "server=localhost;database=csekai;user=root;password=Aa123456;SslMode = none;";
            return connStr;    
        }
    }
}
