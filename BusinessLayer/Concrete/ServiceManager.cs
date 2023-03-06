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
    public class ServiceManager : IServiceService
    {
        IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public void TAdd(Service service)
        {
            _serviceDal.Add(service);
        }

        public void TDelete(Service service)
        {
            _serviceDal.Delete(service);
        }

        public List<Service> TGetList()
        {
            return _serviceDal.GetList();
        }

        public Service TGetByID(int id)
        {
            return _serviceDal.GetByID(id);
        }

        public void TUpdate(Service service)
        {
            _serviceDal.Update(service);
        }

        public List<Service> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }
    }
}
