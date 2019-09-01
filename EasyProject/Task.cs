using System;

namespace EasyProject
{
    [Serializable]
    class Task
    {
        private String Name { get; set; }
        private String Description { get; set; }
        private DateTime Startdate { get; set; }
        private DateTime Enddate { get; set; }
        private DateTime Plannedstartdate { get; set; }
        private DateTime Plannedenddate { get; set; }
        private int Status { get; set; } //iStatus: 0 = pending, 1 = started, 2 = completed, 3 = canceled

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
