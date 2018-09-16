using System;
using CSekai.SYS.Entity;
using CSekai.DBCommon;
using System.Collections.Generic;

namespace CSekai.SYS.DAL
{
    public class UserDAL
    {
        DbUtils db = new DbUtils();
        public void AddUser(User ent)
        {
            string sql = @"insert into sys_user(UserName,NickName,Pwd,Forbid)
                        values (#:UserName,#:NickName,#:Pwd,#:Forbid)";
            db.Execute(sql, ent);
        }
        public void UpdateUser(User ent)
        {
            string sql = @"update sys_user set 
                        UserName=#:UserName,NickName=#:NickName,
                        Pwd=#:Pwd,Forbid=#:Forbid
                        where UserId=#:UserId";
            db.Execute(sql, ent);
        }
        public User GetUser(int id)
        {
            string sql = "select * from sys_user where UserId=#:id";
            return db.Query<User>(sql, new { id });
        }
        public void DeleteUser(int id)
        {
            string sql = @"delete from sys_user where UserId=#:id";
            db.Execute(sql, id);
        }
        public List<User> GetUserList()
        {
            string sql = "select * from sys_user";
            return db.QueryList<User>(sql, null);
        }
    }
}
