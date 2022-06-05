using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanismanProject.Entity
{
    public class Job
    {
        public int JobId { get; set; }
        public string JobName { get; set; }
        public string JobDescription { get; set; }
        public string JobImg { get; set; }
        public string Url { get; set; }
        public List<Advisor> Advisors { get; set; }
    }
}
