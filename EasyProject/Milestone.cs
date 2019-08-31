using System;

namespace EasyProject
{
    [Serializable]
    class Milestone
    {
        private String strName { get; set; }
        private int iStatus { get; set; } //iStatus: 0 = pending, 1 = completed, 2 = canceled
        private DateTime dateCompleted { get; set; }

        public Milestone()
        {
            strName = "";
            iStatus = 0;
            dateCompleted = DateTime.Now + new TimeSpan(7, 0, 0, 0);
        }

        public Milestone(String name, int status, DateTime completed)
        {
            strName = name;
            iStatus = status;
            dateCompleted = completed;
        }
    }
}
