using DanismanProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanismanProject.Business.Abstract
{
    public interface IContactMessageService
    {
        ContactMessage GetById(int id);
        List<ContactMessage> GetAll();
        void Create(ContactMessage entity);
        void Update(ContactMessage entity);
        void Delete(ContactMessage entity);
    }
}
