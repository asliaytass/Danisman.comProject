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
    public class ContactMessageManager : IContactMessageService
    {
        private IContactMessageRepository _contactMessageRepository;
        public ContactMessageManager(IContactMessageRepository contactMessageRepository)
        {
            _contactMessageRepository = contactMessageRepository;
        }
        public void Create(ContactMessage entity)
        {
           _contactMessageRepository.Create(entity);
        }

        public void Delete(ContactMessage entity)
        {
            throw new NotImplementedException();
        }

        public List<ContactMessage> GetAll()
        {
            return _contactMessageRepository.GetAll();
        }

        public ContactMessage GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(ContactMessage entity)
        {
            throw new NotImplementedException();
        }
    }
}
