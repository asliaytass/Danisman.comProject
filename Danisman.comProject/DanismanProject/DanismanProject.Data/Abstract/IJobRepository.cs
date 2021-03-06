using DanismanProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanismanProject.Data.Abstract
{
    public interface IJobRepository : IRepository<Job>
    {
        Job GetJobDetail(string jobName);
        void UpdateJob(Job entity);
 
    }
}
