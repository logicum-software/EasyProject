using System;

namespace EasyProject
{
    [Serializable]
    class Task
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime Enddate { get; set; }
        public DateTime Plannedstartdate { get; set; }
        public DateTime Plannedenddate { get; set; }
        public int Status { get; set; } //iStatus: 0 = pending, 1 = started, 2 = completed, 3 = canceled

        public Task()
        {
            Name = "";
            Description = "";
            Startdate = DateTime.Now;
            Enddate = DateTime.Now + new TimeSpan(7, 0, 0, 0);
            Plannedstartdate = DateTime.Now;
            Plannedenddate = DateTime.Now + new TimeSpan(7, 0, 0, 0);
            Status = 0;
        }

        public Task(String tmpname, String tmpdescription, DateTime start, DateTime end, DateTime plannedstart,
            DateTime plannedend, int tmpstatus)
        {
            Name = tmpname;
            Description = tmpdescription;
            Startdate = start;
            Enddate = end;
            Plannedstartdate = plannedstart;
            Plannedenddate = plannedend;
            Status = tmpstatus;
        }
    }
}
