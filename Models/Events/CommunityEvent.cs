namespace TempleManagementSystem.Models.Events
{
    public class CommunityEvent : Event
    {
        public int ExpectedAttendees { get; set; }
        public string ActivityType { get; set; }
    }
}
