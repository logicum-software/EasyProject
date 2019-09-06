using System;
using System.Collections.Generic;

namespace EasyProject
{
    [Serializable]
    class Project
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime Enddate { get; set; }
        public DateTime Plannedstartdate { get; set; }
        public DateTime Plannedenddate { get; set; }
        public int Status { get; set; } //Status: 0 = pending, 1 = started, 2 = completed, 3 = canceled
        public List<Task> Tasks { get; set; }
        public List<Milestone> Milestones { get; set; }

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
