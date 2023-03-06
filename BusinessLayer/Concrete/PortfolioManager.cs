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
    public class PortfolioManager : IPortfolioService
    {
        IPortfolioDal _portfolioDal;

        public PortfolioManager(IPortfolioDal portfolioDal)
        {
            _portfolioDal = portfolioDal;
        }

        public void TAdd(Portfolio portfolio)
        {
            _portfolioDal.Add(portfolio);
        }

        public void TDelete(Portfolio portfolio)
        {
            _portfolioDal.Delete(portfolio);
        }

        public List<Portfolio> TGetList()
        {
            return _portfolioDal.GetList();
        }

        public Portfolio TGetByID(int id)
        {
            return _portfolioDal.GetByID(id);
        }

        public void TUpdate(Portfolio portfolio)
        {
            _portfolioDal.Update(portfolio);
        }

        public List<Portfolio> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }
    }
}
