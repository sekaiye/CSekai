using System;
using MySql.Data.MySqlClient;
using Dapper;

namespace CSekai.DBCommon
{
    public class DbUtils
    {
        public MySqlConnection GetConnection(){
            return new MySqlConnection(new DbConn().GetConnectionString());
        }
        public void Execute(string sql, object param = null)
        {
            using(MySqlConnection conn = GetConnection())
            {
                conn.Open();
                conn.Execute(sql,param);
                conn.Close();
            }
        }
    }
}
