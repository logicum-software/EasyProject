using System;

namespace EasyProject
{
    [Serializable]
    class Milestone
    {
        public String Name { get; set; }
        public int Status { get; set; } //iStatus: 0 = pending, 1 = completed, 2 = canceled
        public DateTime Datecompleted { get; set; }

        public Milestone()
        {
            Name = "";
            Status = 0;
            Datecompleted = DateTime.Now + new TimeSpan(7, 0, 0, 0);
        }

        public Milestone(String tmpname, int tmpstatus, DateTime tmpcompleted)
        {
            Name = tmpname;
            Status = tmpstatus;
            Datecompleted = tmpcompleted;
        }
    }
}
