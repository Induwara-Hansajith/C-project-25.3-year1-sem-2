using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempleManagementSystem.Model
{
 
        public class DanaOffering
        {
            private int danaID;
            public int DanaID
            {
                get { return danaID; }
                set { danaID = value; }
            }

            private int donorID;
            public int DonorID
            {
                get { return donorID; }
                set { donorID = value; }
            }

            private int eventID;
            public int EventID
            {
                get { return eventID; }
                set { eventID = value; }
            }

            public DateTime DanaDate { get; set; }

            public string MealType { get; set; }

            public int NumberOfPeople { get; set; }

            public string Description { get; set; }

            public string Status { get; set; }

            public DateTime CreatedDate { get; set; }
        }
}