using DanismanProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanismanProject.Business.Abstract
{
    public interface IAdvisorService
    {
        Advisor GetById(int id);
        List<Advisor> GetAll();
        void Create(Advisor entity);
        void Update(Advisor entity);
        void Delete(Advisor entity);
    }
}
