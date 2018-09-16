using System;
using CSekai.SYS.Entity;
using CSekai.SYS.DAL;

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
    }
}
