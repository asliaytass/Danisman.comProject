using DanismanProject.Data.Abstract;
using DanismanProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanismanProject.Data.Concrete.EfCore
{
    public class EfCoreJobRepository : EfCoreGenericRepository<Job, DanismanContext>, IJobRepository
    {
       

        public Job GetJobDetail(string jobName)
        {
            using (var context = new DanismanContext())
            {
                return context.Jobs.Where(i => i.JobName == jobName).FirstOrDefault();
                   
            }
        }
    }
}
