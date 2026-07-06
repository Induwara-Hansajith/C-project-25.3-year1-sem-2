using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempleManagementSystem.Model
{
    internal class MealArrangement
    {
        private int mealID;
        public int MealID
        {
            get { return mealID; }
            set { mealID = value; }
        }
        private int requestID;
        public int RequestID
        {
            get { return requestID; }
            set { requestID = value; }
        }
        public string MealType { get; set; }
        public int MonksCount { get; set; }
        public int DevoteeCount { get; set; }
    }
}
