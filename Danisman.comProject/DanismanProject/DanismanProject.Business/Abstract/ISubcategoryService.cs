using DanismanProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanismanProject.Business.Abstract
{
    public interface ISubcategoryService
    {
        Subcategory GetById(int id);
        List<Subcategory> GetAll();
        void Create(Subcategory entity);
        void Update(Subcategory entity);
        void Delete(Subcategory entity);
    }
}
