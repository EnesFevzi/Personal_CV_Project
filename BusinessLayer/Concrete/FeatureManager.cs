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
    public class FeatureManager : IGenericService<Feature>
    {
        IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void TAdd(Feature feature)
        {
            _featureDal.Add(feature);
        }

        public void TDelete(Feature feature)
        {
            _featureDal.Delete(feature);
        }

        public List<Feature> TGetList()
        {
            return _featureDal.GetList();
        }

        public Feature TGetByID(int id)
        {
            return _featureDal.GetByID(id);
        }

        public void TUpdate(Feature feature)
        {
            _featureDal.Update(feature);
        }

        public List<Feature> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }
    }
}
