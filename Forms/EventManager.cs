using System;
using System.Collections.Generic;
using System.Linq;

namespace TempleManagementSystem.EventManagement
{
    public class EventResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public EventResult(bool success, string message)
        {
            Success = success;
            Message = message;
        }
    }

    public class EventManager
    {
        private readonly EventRepository _repo;

        public EventManager(string connectionString)
        {
            _repo = new EventRepository(connectionString);
        }

        public EventResult AddEvent(TempleEvent ev)
        {
            if (string.IsNullOrWhiteSpace(ev.EventName))
                return new EventResult(false, "Event name is required.");

            if (ev.EventDate < DateTime.Today)
                return new EventResult(false, "Event date cannot be in the past.");

            if (ev.StartTime.HasValue && ev.EndTime.HasValue && ev.EndTime <= ev.StartTime)
                return new EventResult(false, "End time must be after start time.");

            if (_repo.HasConflict(ev))
                return new EventResult(false, "Scheduling conflict: another event is already booked at '" + ev.Location + "' at this time.");

            bool saved = _repo.AddEvent(ev);
            return new EventResult(saved, saved ? "Event added successfully." : "Failed to save event. Please try again.");
        }

        public EventResult UpdateEvent(TempleEvent ev)
        {
            if (string.IsNullOrWhiteSpace(ev.EventName))
                return new EventResult(false, "Event name is required.");

            if (ev.StartTime.HasValue && ev.EndTime.HasValue && ev.EndTime <= ev.StartTime)
                return new EventResult(false, "End time must be after start time.");

            if (_repo.HasConflict(ev))
                return new EventResult(false, "Scheduling conflict: another event is already booked at '" + ev.Location + "' at this time.");

            bool updated = _repo.UpdateEvent(ev);
            return new EventResult(updated, updated ? "Event updated successfully." : "Failed to update event. Please try again.");
        }

        public EventResult DeleteEvent(int eventID)
        {
            bool deleted = _repo.DeleteEvent(eventID);
            return new EventResult(deleted, deleted ? "Event deleted successfully." : "Failed to delete event. Please try again.");
        }

        public List<TempleEvent> GetAllEvents()          { return _repo.GetAllEvents(); }
        public List<TempleEvent> GetUpcomingEvents()     { return _repo.GetUpcomingEvents(); }
        public TempleEvent       GetEventByID(int id)    { return _repo.GetEventByID(id); }
        public List<TempleEvent> GetEventsByType(int id) { return _repo.GetEventsByType(id); }

        public List<TempleEvent> GetEventsByStatus(string status)
        {
            List<TempleEvent> all = _repo.GetAllEvents();
            List<TempleEvent> filtered = new List<TempleEvent>();
            foreach (TempleEvent e in all)
            {
                if (string.Equals(e.Status, status, StringComparison.OrdinalIgnoreCase))
                    filtered.Add(e);
            }
            return filtered;
        }

        public List<TempleEvent> SearchEvents(string keyword)
        {
            List<TempleEvent> all = _repo.GetAllEvents();
            List<TempleEvent> filtered = new List<TempleEvent>();
            foreach (TempleEvent e in all)
            {
                if (e.EventName.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
                    filtered.Add(e);
            }
            return filtered;
        }
    }
}
