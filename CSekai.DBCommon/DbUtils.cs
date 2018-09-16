using System;
using MySql.Data.MySqlClient;
using Dapper;
using System.Data;
using System.Collections.Generic;

namespace CSekai.DBCommon
{
    public class DbUtils
    {

        public int Execute(string sql, object param = null)
        {
            using(IDbConnection conn = new DbConn().GetConnection())
            {
                return conn.Execute(sql,param);
            }
        }
        public T ExecuteScalar<T>(string sql, object param = null)
        {
            using (IDbConnection conn = new DbConn().GetConnection())
            {
                return conn.ExecuteScalar<T>(sql, param);
            }
        }
        public T Query<T>(string sql, object param = null)
        {
            using (IDbConnection conn = new DbConn().GetConnection())
            {
                return conn.QuerySingleOrDefault<T>(sql, param);
            }
        }
        public List<T> QueryList<T>(string sql, object param = null) 
        {
            using (IDbConnection conn = new DbConn().GetConnection())
            {
                return conn.Query<T>(sql, param).AsList();
            }
        }

    }
}
