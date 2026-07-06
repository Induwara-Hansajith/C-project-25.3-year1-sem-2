using System;

namespace TempleManagementSystem.EventManagement
{
    public class SpecialEvent : TempleEvent
    {
        public string Sponsor { get; set; }
        public int GuestCount { get; set; }

        public SpecialEvent(string eventName, DateTime eventDate, string location,
                            string sponsor, int guestCount)
            : base(eventName, eventDate, location)
        {
            Sponsor     = sponsor;
            GuestCount  = guestCount;
            EventTypeID = 4; // Special Event
        }

        public SpecialEvent() { }

        public override string GetEventTypeName() => "Special Event";

        public override string GetDetails()
        {
            return base.GetDetails() +
                   $"\nSponsor    : {Sponsor}" +
                   $"\nGuest Count: {GuestCount}";
        }
    }
}
