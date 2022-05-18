using DanismanProject.Data.Abstract;
using DanismanProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanismanProject.Data.Concrete.EfCore
{
    public class EfCoreAdvisorRepository : EfCoreGenericRepository<Advisor, DanismanContext>, IAdvisorRepository
    {
    }
}
