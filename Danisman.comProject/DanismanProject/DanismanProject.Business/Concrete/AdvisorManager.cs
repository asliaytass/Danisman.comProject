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
    public class AdvisorManager: IAdvisorService
    {
        private IAdvisorRepository _advisorRepository;
        public AdvisorManager(IAdvisorRepository advisorRepository)
        {
            _advisorRepository = advisorRepository;
        }

        public void Create(Advisor entity)
        {
            _advisorRepository.Create(entity);
        }

        public void Create(Advisor entity, int jobId)
        {
            _advisorRepository.Create(entity,jobId);
        }

        public void CreateAdvisor(Advisor entity)
        {
            _advisorRepository.CreateAdvisor(entity);
        }

        public void Delete(Advisor entity)
        {
            _advisorRepository.Delete(entity);
        }

        public List<Advisor> GetAdvisorByCategory(string jobName)
        {
            return _advisorRepository.GetAdvisorByCategory(jobName);
        }

        public Advisor GetAdvisorDetail(string advisorname)
        {
            return _advisorRepository.GetAdvisorDetail(advisorname);
        }

        public List<Advisor> GetAll()
        {
            return _advisorRepository.GetAll();
        }

        public Advisor GetById(int id)
        {
            return _advisorRepository.GetById(id);
        }

        public Advisor GetByIdWithJobs(int id)
        {
            return _advisorRepository.GetByIdWithJobs(id);
        }

        public void Update(Advisor entity)
        {
            _advisorRepository.Update(entity);
        }
    }
}
