using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempleManagementSystem.Model
{
    public class Donor
    {
        private int donorID;
        public int DonorID
        {
            get { return donorID; }
            set { donorID = value; }
        }
        private int userID;
        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        public string Name { get; set; }

        private string phoneNumber;
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public DateTime Createddate{ get; set; }
    }
}
        
    
