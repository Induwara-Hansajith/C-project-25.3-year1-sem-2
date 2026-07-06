using System;

namespace TempleManagementSystem.EventManagement
{
    public abstract class TempleEvent
    {
        // Encapsulated properties
        public int EventID { get; set; }
        public int EventTypeID { get; set; }
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public int? OrganizedBy { get; set; }
        public string Status { get; set; }   // Scheduled | Completed | Cancelled
        public DateTime CreatedDate { get; set; }

        // Constructor
        protected TempleEvent(string eventName, DateTime eventDate, string location)
        {
            EventName   = eventName;
            EventDate   = eventDate;
            Location    = location;
            Status      = "Scheduled";
            CreatedDate = DateTime.Now;
        }

        // Parameterless constructor for loading from DB
        protected TempleEvent() { }

        // Abstract method — each subclass must override to return its type label
        public abstract string GetEventTypeName();

        // Virtual method — subclasses can override to show their extra details
        public virtual string GetDetails()
        {
            return $"Event: {EventName}\n" +
                   $"Type : {GetEventTypeName()}\n" +
                   $"Date : {EventDate:yyyy-MM-dd}\n" +
                   $"Time : {StartTime} - {EndTime}\n" +
                   $"Venue: {Location}\n" +
                   $"Status: {Status}";
        }

        public override string ToString()
        {
            return $"{EventName} | {EventDate:yyyy-MM-dd} | {Location} | {Status}";
        }
    }
}
