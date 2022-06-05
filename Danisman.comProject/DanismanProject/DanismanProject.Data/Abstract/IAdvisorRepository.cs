using DanismanProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanismanProject.Data.Abstract
{
    public interface IAdvisorRepository: IRepository<Advisor>
    {
        List<Advisor> GetAdvisorByCategory(string jobName);
        Advisor GetAdvisorDetail(string advisorname);
        void CreateAdvisor(Advisor entity);
        Advisor GetByIdWithJobs(int id);
        void Create(Advisor entity, int jobId);



    }
}
