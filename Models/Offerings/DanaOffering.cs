using TempleManagementSystem.Models.Base;

namespace TempleManagementSystem.Models.Offerings
{
    public class DanaOffering : TempleEntity
    {
        public string Donor { get; set; }
        public decimal Amount { get; set; }
        public string Category { get; set; }
    }
}
