using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class HizmetlerManager : IHizmetlerService
    {
        IHizmetlerDal _hizmetlerDal;

        public HizmetlerManager(IHizmetlerDal hizmetlerDal)
        {
            _hizmetlerDal = hizmetlerDal;
        }

        public Hizmetler GetById(int id)
        {
            return _hizmetlerDal.Get(x => x.HizmetId == id);
        }

        public Hizmetler GetByIdHizmet(int id)
        {
            return _hizmetlerDal.Get(x => x.HizmetId == id);
        }

        public List<Hizmetler> GetList()
        {
            return _hizmetlerDal.List();
        }

        public List<Hizmetler> GetListHizmet()
        {
            return _hizmetlerDal.List();

        }


            public void HizmetlerAdd(Hizmetler hizmetler)
        {
            _hizmetlerDal.Insert(hizmetler);
        }

        public void HizmetlerDelete(Hizmetler hizmetler)
        {
            _hizmetlerDal.Delete(hizmetler);
        }

        public void HizmetlerUpdate(Hizmetler hizmetler)
        {
            _hizmetlerDal.Update(hizmetler);
        }
    }
}
