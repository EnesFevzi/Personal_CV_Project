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
    public class ExperienceManager : IExperienceService
    {
        IExperienceDal _experienceDal;

        public ExperienceManager(IExperienceDal experienceDal)
        {
            _experienceDal = experienceDal;
        }

        public void TAdd(Experience experience)
        {
            _experienceDal.Add(experience);
        }

        public void TDelete(Experience experience)
        {
            _experienceDal.Delete(experience);
        }

        public List<Experience> TGetList()
        {
            return _experienceDal.GetList();
        }

        public Experience TGetByID(int id)
        {
            return _experienceDal.GetByID(id);
        }

        public void TUpdate(Experience experience)
        {
            _experienceDal.Update(experience);
        }

        public List<Experience> TGetListbyFilter()
        {
            return _experienceDal.GetList();
        }
    }
}
