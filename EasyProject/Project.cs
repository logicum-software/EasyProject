using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProject
{
    [Serializable]
    class Project
    {
        private String strName { get; set; }
        private String strDescription { get; set; }
        private DateTime dateStart { get; set; }
        private DateTime dateEnd { get; set; }
        private DateTime datePlannedStart { get; set; }
        private DateTime datePlannedEnd { get; set; }
        private int iStatus { get; set; } //iStatus: 0 = pending, 1 = started, 2 = completed, 3 = canceled
        private List<Task> Tasks { get; set; }

        public Project()
        {
            strName = "";
            strDescription = "";
            dateStart = DateTime.Now;
            dateEnd = DateTime.Now + new TimeSpan(7, 0, 0, 0);
            datePlannedStart = DateTime.Now;
            datePlannedEnd = DateTime.Now + new TimeSpan(7, 0, 0, 0);
            iStatus = 0;
            Tasks = new List<Task>();
        }

        public Project(String name, String description, DateTime start, DateTime end, DateTime plannedstart,
            DateTime plannedend, int status, List<Task> tasks)
        {
            strName = name;
            strDescription = description;
            dateStart = start;
            dateEnd = end;
            datePlannedStart = plannedstart;
            datePlannedEnd = plannedend;
            iStatus = status;
            Tasks = tasks;
        }
    }
}
