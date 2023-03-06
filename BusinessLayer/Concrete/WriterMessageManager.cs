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
    public class WriterMessageManager : IWriterMessageService
    {
        IWriterMessageDal _writerMessageDal;

        public WriterMessageManager(IWriterMessageDal writerMessageDal)
        {
            _writerMessageDal = writerMessageDal;
        }

        public List<WriterMessage> GetListReceiverMessage(string p)
        {
            return _writerMessageDal.GetbyFilter(x => x.Receiver == p);
        }

        public List<WriterMessage> GetListSenderMessage(string p)
        {
            return _writerMessageDal.GetbyFilter(x => x.Sender == p);
        }

        public void TAdd(WriterMessage writerMessage)
        {
            _writerMessageDal.Add(writerMessage);
        }

        public void TDelete(WriterMessage writerMessage)
        {
            _writerMessageDal.Delete(writerMessage);
        }

        public WriterMessage TGetByID(int id)
        {
            return _writerMessageDal.GetByID(id);
        }

        public List<WriterMessage> TGetList()
        {
            throw new NotImplementedException();
        }

        //public List<WriterMessage> TGetListbyFilter(string p)
        //{
        //    return _writerMessageDal.GetbyFilter(x => x.Receiver == p);
        //}

        public List<WriterMessage> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(WriterMessage writerMessage)
        {
            throw new NotImplementedException();
        }
    }
}
