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
            throw new NotImplementedException();
        }

        public void Delete(Advisor entity)
        {
            throw new NotImplementedException();
        }

        public List<Advisor> GetAll()
        {
            return _advisorRepository.GetAll();
        }

        public Advisor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Advisor entity)
        {
            throw new NotImplementedException();
        }
    }
}
