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
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public void TAdd(Message message)
        {
            _messageDal.Add(message);
        }

        public void TDelete(Message message)
        {
            _messageDal.Delete(message);
        }

        public List<Message> TGetList()
        {
            return _messageDal.GetList();
        }

        public Message TGetByID(int id)
        {
            return _messageDal.GetByID(id);
        }

        public void TUpdate(Message message)
        {
            throw new NotImplementedException();
        }

        public List<Message> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }
    }
}
