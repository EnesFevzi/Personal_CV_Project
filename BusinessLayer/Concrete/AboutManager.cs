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
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void TAdd(About about)
        {
            _aboutDal.Add(about);
        }

        public void TDelete(About about)
        {
            _aboutDal.Delete(about);
        }

        public List<About> TGetList()
        {
            return _aboutDal.GetList();
        }

        public About TGetByID(int id)
        {
            return _aboutDal.GetByID(id);
        }

        public void TUpdate(About about)
        {
            _aboutDal.Update(about);
        }

        public List<About> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }
    }
}
