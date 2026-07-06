using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace TempleManagementSystem.EventManagement
{
    // Handles all database operations for Events
    public class EventRepository
    {
        private readonly string _connectionString;

        public EventRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        // ── CREATE ──────────────────────────────────────────────────────────

        public bool AddEvent(TempleEvent ev)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                string query = @"
                    INSERT INTO Events
                        (EventTypeID, EventName, EventDate, StartTime, EndTime,
                         Location, Description, OrganizedBy, Status,
                         MonkCount, Offerings, Speaker, Topic, Sponsor, GuestCount)
                    VALUES
                        (@EventTypeID, @EventName, @EventDate, @StartTime, @EndTime,
                         @Location, @Description, @OrganizedBy, @Status,
                         @MonkCount, @Offerings, @Speaker, @Topic, @Sponsor, @GuestCount)";

                SqlCommand cmd = new SqlCommand(query, con);
                MapParameters(cmd, ev);
                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // ── READ ─────────────────────────────────────────────────────────────

        public List<TempleEvent> GetAllEvents()
        {
            List<TempleEvent> list = new List<TempleEvent>();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                string query = @"
                    SELECT e.*, et.TypeName
                    FROM Events e
                    JOIN EventTypes et ON e.EventTypeID = et.EventTypeID
                    ORDER BY e.EventDate, e.StartTime";

                SqlCommand    cmd    = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                    list.Add(MapReaderToEvent(reader));
            }
            return list;
        }

        public List<TempleEvent> GetUpcomingEvents()
        {
            List<TempleEvent> list = new List<TempleEvent>();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                string query = @"
                    SELECT e.*, et.TypeName
                    FROM Events e
                    JOIN EventTypes et ON e.EventTypeID = et.EventTypeID
                    WHERE e.EventDate >= CAST(GETDATE() AS DATE)
                      AND e.Status = 'Scheduled'
                    ORDER BY e.EventDate, e.StartTime";

                SqlCommand    cmd    = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                    list.Add(MapReaderToEvent(reader));
            }
            return list;
        }

        public TempleEvent GetEventByID(int eventID)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                string query = @"
                    SELECT e.*, et.TypeName
                    FROM Events e
                    JOIN EventTypes et ON e.EventTypeID = et.EventTypeID
                    WHERE e.EventID = @EventID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@EventID", eventID);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                return reader.Read() ? MapReaderToEvent(reader) : null;
            }
        }

        public List<TempleEvent> GetEventsByType(int eventTypeID)
        {
            List<TempleEvent> list = new List<TempleEvent>();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                string query = @"
                    SELECT e.*, et.TypeName
                    FROM Events e
                    JOIN EventTypes et ON e.EventTypeID = et.EventTypeID
                    WHERE e.EventTypeID = @EventTypeID
                    ORDER BY e.EventDate DESC";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@EventTypeID", eventTypeID);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                    list.Add(MapReaderToEvent(reader));
            }
            return list;
        }

        // ── UPDATE ───────────────────────────────────────────────────────────

        public bool UpdateEvent(TempleEvent ev)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                string query = @"
                    UPDATE Events SET
                        EventTypeID  = @EventTypeID,
                        EventName    = @EventName,
                        EventDate    = @EventDate,
                        StartTime    = @StartTime,
                        EndTime      = @EndTime,
                        Location     = @Location,
                        Description  = @Description,
                        OrganizedBy  = @OrganizedBy,
                        Status       = @Status,
                        MonkCount    = @MonkCount,
                        Offerings    = @Offerings,
                        Speaker      = @Speaker,
                        Topic        = @Topic,
                        Sponsor      = @Sponsor,
                        GuestCount   = @GuestCount
                    WHERE EventID = @EventID";

                SqlCommand cmd = new SqlCommand(query, con);
                MapParameters(cmd, ev);
                cmd.Parameters.AddWithValue("@EventID", ev.EventID);
                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // ── DELETE ───────────────────────────────────────────────────────────

        public bool DeleteEvent(int eventID)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                string     query = "DELETE FROM Events WHERE EventID = @EventID";
                SqlCommand cmd   = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@EventID", eventID);
                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // ── CONFLICT DETECTION ───────────────────────────────────────────────

        public bool HasConflict(TempleEvent ev)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                string query = @"
                    SELECT COUNT(*) FROM Events
                    WHERE Location  = @Location
                      AND EventDate = @EventDate
                      AND Status   != 'Cancelled'
                      AND StartTime < @EndTime
                      AND EndTime   > @StartTime
                      AND EventID  != @EventID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Location",  ev.Location);
                cmd.Parameters.AddWithValue("@EventDate", ev.EventDate);
                cmd.Parameters.AddWithValue("@StartTime", (object)ev.StartTime ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@EndTime",   (object)ev.EndTime   ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@EventID",   ev.EventID);
                con.Open();
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        // ── HELPERS ──────────────────────────────────────────────────────────

        // Maps a DataReader row to the correct subclass based on EventTypeID
        private TempleEvent MapReaderToEvent(SqlDataReader r)
        {
            int typeID = Convert.ToInt32(r["EventTypeID"]);

            TempleEvent ev;

            if (typeID == 1) // Religious Ceremony
            {
                ev = new CeremonyEvent
                {
                    MonkCount = r["MonkCount"] != DBNull.Value ? Convert.ToInt32(r["MonkCount"]) : 0,
                    Offerings = r["Offerings"] != DBNull.Value ? r["Offerings"].ToString() : ""
                };
            }
            else if (typeID == 5) // Dhamma Sermon
            {
                ev = new DhammaEvent
                {
                    Speaker = r["Speaker"] != DBNull.Value ? r["Speaker"].ToString() : "",
                    Topic   = r["Topic"]   != DBNull.Value ? r["Topic"].ToString()   : ""
                };
            }
            else if (typeID == 4) // Special Event
            {
                ev = new SpecialEvent
                {
                    Sponsor    = r["Sponsor"]    != DBNull.Value ? r["Sponsor"].ToString()           : "",
                    GuestCount = r["GuestCount"] != DBNull.Value ? Convert.ToInt32(r["GuestCount"]) : 0
                };
            }
            else
            {
                ev = new CeremonyEvent(); // default fallback
            }

            // Map shared base class fields
            ev.EventID      = Convert.ToInt32(r["EventID"]);
            ev.EventTypeID  = typeID;
            ev.EventName    = r["EventName"].ToString();
            ev.EventDate    = Convert.ToDateTime(r["EventDate"]);
            ev.StartTime    = r["StartTime"] != DBNull.Value ? (TimeSpan?)r["StartTime"] : null;
            ev.EndTime      = r["EndTime"]   != DBNull.Value ? (TimeSpan?)r["EndTime"]   : null;
            ev.Location     = r["Location"]  != DBNull.Value ? r["Location"].ToString()  : "";
            ev.Description  = r["Description"] != DBNull.Value ? r["Description"].ToString() : "";
            ev.OrganizedBy  = r["OrganizedBy"] != DBNull.Value ? (int?)Convert.ToInt32(r["OrganizedBy"]) : null;
            ev.Status       = r["Status"].ToString();
            ev.CreatedDate  = Convert.ToDateTime(r["CreatedDate"]);

            return ev;
        }

        // Maps a TempleEvent object to SQL parameters
        private void MapParameters(SqlCommand cmd, TempleEvent ev)
        {
            cmd.Parameters.AddWithValue("@EventTypeID", ev.EventTypeID);
            cmd.Parameters.AddWithValue("@EventName", ev.EventName);
            cmd.Parameters.AddWithValue("@EventDate", ev.EventDate);
            cmd.Parameters.AddWithValue("@StartTime", (object)ev.StartTime ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@EndTime", (object)ev.EndTime ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Location", ev.Location ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Description", ev.Description ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@OrganizedBy", (object)ev.OrganizedBy ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Status", ev.Status);

            // Subclass-specific — only set if applicable
            cmd.Parameters.AddWithValue("@MonkCount", (ev is CeremonyEvent c1) ? (object)c1.MonkCount : (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Offerings", (ev is CeremonyEvent c2) ? (object)c2.Offerings : (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Speaker", (ev is DhammaEvent d1) ? (object)d1.Speaker : (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Topic", (ev is DhammaEvent d2) ? (object)d2.Topic : (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Sponsor", (ev is SpecialEvent s1) ? (object)s1.Sponsor : (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@GuestCount", (ev is SpecialEvent s2) ? (object)s2.GuestCount : (object)DBNull.Value);
        }
    }
}
