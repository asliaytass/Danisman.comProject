using DanismanProject.Business.Abstract;
using DanismanProject.Data.Abstract;
using DanismanProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanismanProject.Business.Concrete
{
    public class JobManager : IJobService
    {
        private IJobRepository _jobRepository;
        public JobManager(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }
        public void Create(Job entity)
        {
            _jobRepository.Create(entity);
        }

        public void Delete(Job entity)
        {
            _jobRepository.Delete(entity);
        }

        public List<Job> GetAll()
        {
            return _jobRepository.GetAll();
        }

        public Job GetById(int id)
        {
            return _jobRepository.GetById(id);
        }

        public Job GetJobDetail(string jobName)
        {
            return _jobRepository.GetJobDetail(jobName);
        }

        public void Update(Job entity)
        {
            _jobRepository.Update(entity);
        }

        public void UpdateJob(Job entity)
        {
            _jobRepository.UpdateJob(entity);
        }
    }
}
