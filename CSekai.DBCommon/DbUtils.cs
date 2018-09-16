using System;
using MySql.Data.MySqlClient;
using Dapper;
using System.Data;
using System.Collections.Generic;

namespace CSekai.DBCommon
{
    public class DbUtils
    {
        DbConn dbConn;
        public DbUtils()
        {
            dbConn = new DbConn();
        }
        string TranslateParam(string sql)
        {
            string dbType = dbConn.GetDbType();
            if (dbType.Equals(dbConn.MYSQL))
            {
                sql = sql.Replace("#:", "?");
            }
            else if (dbType.Equals(dbConn.ORACLE))
            {
                sql = sql.Replace("#:", ":");
            }
            else if (dbType.Equals(dbConn.SQLSERVER))
            {
                sql = sql.Replace("#:", "@");
            }
            return sql;
        }
        public int Execute(string sql, object param = null)
        {
            using(IDbConnection conn = new DbConn().GetConnection())
            {
                sql = TranslateParam(sql);
                return conn.Execute(sql,param);
            }
        }
        public T ExecuteScalar<T>(string sql, object param = null)
        {
            using (IDbConnection conn = new DbConn().GetConnection())
            {
                sql = TranslateParam(sql);
                return conn.ExecuteScalar<T>(sql, param);
            }
        }
        public T Query<T>(string sql, object param = null)
        {
            using (IDbConnection conn = new DbConn().GetConnection())
            {
                sql = TranslateParam(sql);
                return conn.QuerySingleOrDefault<T>(sql, param);
            }
        }
        public List<T> QueryList<T>(string sql, object param = null) 
        {
            using (IDbConnection conn = new DbConn().GetConnection())
            {
                sql = TranslateParam(sql);
                return conn.Query<T>(sql, param).AsList();
            }
        }

    }
}
