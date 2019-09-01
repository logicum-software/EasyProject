using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProject
{
    [Serializable]
    class AppData
    {
        public List<Project> Projects { get; set; }
        public String Filename { get; set; }

        public AppData()
        {
            Projects = new List<Project>();
            Filename = "udata.dat";
        }

        public AppData(List<Project> tmpProjects, String tmpFilename)
        {
            Projects = tmpProjects;
            Filename = tmpFilename;
        }
    }
}
