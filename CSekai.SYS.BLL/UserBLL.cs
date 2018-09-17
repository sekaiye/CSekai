using System;
using CSekai.SYS.Entity;
using CSekai.SYS.DAL;
using System.Collections.Generic;

namespace CSekai.SYS.BLL
{
    public class UserBLL
    {
        UserDAL dal = new UserDAL();
        public void AddUser(User user){
            dal.AddUser(user);
        }
        public User GetUser(int id)
        {
            return dal.GetUser(id);
        }
        public List<User> GetUserList(object param)
        {
            return dal.GetUserList(param);
        }
    }
}
