namespace TempleManagementSystem.Models.Base
{
    public abstract class TempleEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
