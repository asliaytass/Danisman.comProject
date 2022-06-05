using DanismanProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanismanProject.Business.Abstract
{
    public interface IJobService
    {
        Job GetById(int id);
        List<Job> GetAll();
        void Create(Job entity);
        void Update(Job entity);
        void Delete(Job entity);
        Job GetJobDetail(string jobName);

    }
}
