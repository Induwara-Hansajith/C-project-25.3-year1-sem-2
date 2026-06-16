using TempleManagementSystem.Models.Base;

namespace TempleManagementSystem.Models.Visitors
{
    public class Visitor : TempleEntity
    {
        public string Contact { get; set; }
        public DateTime ArrivalDate { get; set; }
        public string Purpose { get; set; }
    }
}
