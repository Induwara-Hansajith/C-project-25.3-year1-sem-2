using System;

namespace TempleManagementSystem.EventManagement
{
    // Inherits from TempleEvent — demonstrates Inheritance
    public class CeremonyEvent : TempleEvent
    {
        public int MonkCount { get; set; }
        public string Offerings { get; set; }

        public CeremonyEvent(string eventName, DateTime eventDate, string location,
                             int monkCount, string offerings)
            : base(eventName, eventDate, location)
        {
            MonkCount = monkCount;
            Offerings = offerings;
            EventTypeID = 1; // Religious Ceremony
        }

        public CeremonyEvent() { }

        // Polymorphism — overrides abstract method
        public override string GetEventTypeName() => "Religious Ceremony";

        public override string GetDetails()
        {
            return base.GetDetails() +
                   $"\nMonks Attending: {MonkCount}" +
                   $"\nOfferings: {Offerings}";
        }
    }
}
