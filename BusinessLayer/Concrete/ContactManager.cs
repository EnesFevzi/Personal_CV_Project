using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void TAdd(Contact contact)
        {
            _contactDal.Add(contact);
        }

        public void TDelete(Contact contact)
        {
            _contactDal.Delete(contact);
        }

        public List<Contact> TGetList()
        {
            return _contactDal.GetList();
        }

        public Contact TGetByID(int id)
        {
            return _contactDal.GetByID(id);
        }

        public void TUpdate(Contact contact)
        {
            _contactDal.Update(contact);
        }

        public List<Contact> TGetListbyFilter()
        {
            return _contactDal.GetList();
        }
    }
}
