using System;

namespace TempleManagementSystem.EventManagement
{
    public class DhammaEvent : TempleEvent
    {
        public string Speaker { get; set; }
        public string Topic { get; set; }

        public DhammaEvent(string eventName, DateTime eventDate, string location,
                           string speaker, string topic)
            : base(eventName, eventDate, location)
        {
            Speaker     = speaker;
            Topic       = topic;
            EventTypeID = 5; // Dhamma Sermon
        }

        public DhammaEvent() { }

        public override string GetEventTypeName() => "Dhamma Sermon";

        public override string GetDetails()
        {
            return base.GetDetails() +
                   $"\nSpeaker: {Speaker}" +
                   $"\nTopic  : {Topic}";
        }
    }
}
