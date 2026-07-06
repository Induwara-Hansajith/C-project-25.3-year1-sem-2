using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempleManagementSystem.Model
{
    public class User
    { 
        private int userId;
        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public int UserID 
        {
            get { return userId;}
            set { userId = value; }
        }

        public string UserName{ get; set;  }
        public string Role {  get; set; }
    }
}
