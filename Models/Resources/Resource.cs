using TempleManagementSystem.Models.Base;

namespace TempleManagementSystem.Models.Resources
{
    public class Resource : TempleEntity
    {
        public int Quantity { get; set; }
        public string Unit { get; set; }
        public string Location { get; set; }
    }
}
