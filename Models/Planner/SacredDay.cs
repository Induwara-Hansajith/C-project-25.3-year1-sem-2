using System;

using TempleManagementSystem.Models.Base;

namespace TempleManagementSystem.Models.Planner
{
    public class SacredDay : TempleEntity
    {
        public DateTime Date { get; set; }
        public string Significance { get; set; }
        public string Checklist { get; set; }
    }
}
