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
    public class MuhtarManager : IMuhtarService
    {
        IMuhtarDal _muhtarDal;

        public MuhtarManager(IMuhtarDal muhtarDal)
        {
            _muhtarDal = muhtarDal;
        }

        public List<Muhtar> GetAll()
        {
            return _muhtarDal.List();
        }

        public Muhtar GetById(int id)
        {
            return _muhtarDal.Get(x => x.MuhtarId == id);
        }

        public Muhtar GetByIdMuhtar(int id)
        {
            return _muhtarDal.Get(x => x.MuhtarId == id);
        }

        public List<Muhtar> GetList()
        {
            return _muhtarDal.List();
        }

        public List<Muhtar> GetListMuhtar()
        {
            return _muhtarDal.List();
        }

        public void MuhtarAdd(Muhtar muhtar)
        {
            _muhtarDal.Insert(muhtar);
        }

        public void MuhtarDelete(Muhtar muhtar)
        {
            _muhtarDal.Delete(muhtar);
        }

        public void MuhtarUpdate(Muhtar muhtar)
        {
            _muhtarDal.Update(muhtar);
            
        }
    }
}
