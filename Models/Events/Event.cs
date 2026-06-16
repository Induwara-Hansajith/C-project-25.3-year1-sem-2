using TempleManagementSystem.Models.Base;

namespace TempleManagementSystem.Models.Events
{
    public class Event : TempleEntity
    {
        public DateTime Date { get; set; }
        public string Location { get; set; }
    }
}
