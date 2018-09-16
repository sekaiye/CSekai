using System;
using CSekai.SYS.Entity;
using CSekai.DBCommon;

namespace CSekai.SYS.DAL
{
    public class UserDAL
    {
        public void AddUser(User ent)
        {
            string sql = @"insert into sys_user(UserName,NickName,Pwd,Forbid)
                            values (?UserName,?NickName,?Pwd,?Forbid)";
            new DbUtils().Execute(sql, ent);
        }
        public void UpdateUser()
        {
            
        }
        public void GetUser()
        {
            
        }
        public void DeleteUser()
        {
            
        }
    }
}
