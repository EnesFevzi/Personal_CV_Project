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
    public class SkillManager : ISkillService
    {
        ISkillDal _skillDal;

        public SkillManager(ISkillDal skillDal)
        {
            _skillDal = skillDal;
        }

        public void TAdd(Skill skill)
        {
            _skillDal.Add(skill);
        }

        public void TDelete(Skill skill)
        {
            _skillDal.Delete(skill);
        }

        public List<Skill> TGetList()
        {
            return _skillDal.GetList();
        }

        public Skill TGetByID(int id)
        {
            return _skillDal.GetByID(id);
        }

        public void TUpdate(Skill skill)
        {
            _skillDal.Update(skill);
        }

        public List<Skill> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }
    }
}
