using System;

namespace CSekai.SYS.Entity
{
    public class User
    {
        public int UserId{get;set;}
        public string UserName{get;set;}
        public string NickName{get;set;}
        public string Pwd{get;set;}
        public int Forbid{get;set;}
        public string Email { get; set; }
        public string Cellphone { get; set; }
    }
}
