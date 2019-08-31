using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProject
{
    [Serializable]
    class Task
    {
        private String strName { get; set; }
        private String strDescription { get; set; }
        private DateTime dateStart { get; set; }
        private DateTime dateEnd { get; set; }
        private DateTime datePlannedStart { get; set; }
        private DateTime datePlannedEnd { get; set; }
        private int iStatus { get; set; } //iStatus: 0 = pending, 1 = started, 2 = completed, 3 = canceled

        public Task()
        {
            strName = "";
            strDescription = "";
            dateStart = DateTime.Now;
            dateEnd = DateTime.Now + new System.TimeSpan(7, 0, 0, 0);
            datePlannedStart = DateTime.Now;
            datePlannedEnd = DateTime.Now + new System.TimeSpan(7, 0, 0, 0);
            iStatus = 0;
        }
    }
}
