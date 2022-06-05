using DanismanProject.Data.Abstract;
using DanismanProject.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanismanProject.Data.Concrete.EfCore
{
    public class EfCoreAdvisorRepository : EfCoreGenericRepository<Advisor, DanismanContext>, IAdvisorRepository
    {
        public void Create(Advisor entity, int jobId)
        {
            using (var context = new DanismanContext())
            {
                context.Advisors.Add(entity);
                context.SaveChanges(entity.JobId==jobId);             
            }
        }
        



        public void CreateAdvisor(Advisor entity)
        {
            using (var context = new DanismanContext())
            {
                context.Advisors.Add(entity );
                context.SaveChanges();
            }
        }

        public List<Advisor> GetAdvisorByCategory(string jobName)
        {
            //return context.Jobs.Where(i => i.JobName == jobName).FirstOrDefault();
            using (var context = new DanismanContext())
            {
                return context.Advisors.Where(i => i.IsApproved == true && i.Job.JobName == jobName).ToList();

            }
        }

        public Advisor GetAdvisorDetail(string advisorname)
        {
            using (var context = new DanismanContext())
            {
                var a= context.Advisors.Where(i => i.AdvisorName == advisorname).FirstOrDefault();
                a.Job = context.Jobs.Where(x => x.JobId == a.JobId).FirstOrDefault();
                return a;
               
            }
        }

        public Advisor GetByIdWithJobs(int id)
        {
            using (var context = new DanismanContext())
            {
                var a = context.Advisors.Find(id);              
                a.Job = context.Jobs.Where(x=>x.JobId==a.JobId).FirstOrDefault();
                return a;

                    
            }
        }
    }
}
