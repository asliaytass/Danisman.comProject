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
    public class SubcategoryManager : ISubcategoryService
    {
        private ISubcategoryRepository _subcategoryRepository;
        public SubcategoryManager(ISubcategoryRepository subcategoryRepository)
        {
            _subcategoryRepository = subcategoryRepository;
        }
        public void Create(Subcategory entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Subcategory entity)
        {
            throw new NotImplementedException();
        }

        public List<Subcategory> GetAll()
        {
            return _subcategoryRepository.GetAll();
        }

        public Subcategory GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Subcategory entity)
        {
            throw new NotImplementedException();
        }
    }
}
