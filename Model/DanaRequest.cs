using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempleManagementSystem.Model
{
    public class DanaRequest
    {
    

        private int requestID;
        public int RequestID
        {
            get { return requestID; }
            set { requestID = value; }
        }
        private int donorID;
        public int DonorID
        {
            get { return donorID; }
            set { donorID = value; }
        }
        public DateTime DanaDate { get; set; }
        public string DanaType { get; set; }
        public string MealType { get; set; }
        public string Status { get; set; }
        public DateTime RequestDate { get; set; }
    }
}
