using System;
using System.Collections.Generic;

namespace EasyProject
{
    [Serializable]
    class Project
    {
        private String Name { get; set; }
        private String Description { get; set; }
        private DateTime Startdate { get; set; }
        private DateTime Enddate { get; set; }
        private DateTime Plannedstartdate { get; set; }
        private DateTime Plannedenddate { get; set; }
        private int Status { get; set; } //Status: 0 = pending, 1 = started, 2 = completed, 3 = canceled
        private List<Task> Tasks { get; set; }
        private List<Milestone> Milestones { get; set; }

        public Project()
        {
            Name = "";
            Description = "";
            Startdate = DateTime.Now;
            Enddate = DateTime.Now + new TimeSpan(7, 0, 0, 0);
            Plannedstartdate = DateTime.Now;
            Plannedenddate = DateTime.Now + new TimeSpan(7, 0, 0, 0);
            Status = 0;
            Tasks = new List<Task>();
            Milestones = new List<Milestone>();
        }

        public Project(String tmpname, String tmpdescription, DateTime start, DateTime end, DateTime plannedstart,
            DateTime plannedend, int status, List<Task> tmptasks, List<Milestone> tmpmilestones)
        {
            Name = tmpname;
            Description = tmpdescription;
            Startdate = start;
            Enddate = end;
            Plannedstartdate = plannedstart;
            Plannedenddate = plannedend;
            Status = status;
            Tasks = tmptasks;
            Milestones = tmpmilestones;
        }
    }
}
