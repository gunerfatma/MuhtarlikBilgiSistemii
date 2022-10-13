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
    public class MahalleManager : IMahalleService
    {
        IMahalleDal _mahalleDal;

        public MahalleManager(IMahalleDal mahalleDal)
        {
            _mahalleDal = mahalleDal;
        }

        public void AddMahalle(Mahalle mahalle)
        {
            _mahalleDal.Insert(mahalle);
        }

       

        public void DeleteMahalle(Mahalle mahalle)
        {
            _mahalleDal.Delete(mahalle);
        }


        public Mahalle GetById(int id)
        {
            return _mahalleDal.Get(x => x.MahalleId == id);
        }

        public List<Mahalle> GetList()
        {
            return _mahalleDal.List();
        }

        public List<Mahalle> GetListMahalle()
        {
            return _mahalleDal.List();
        }

        public void UpdateMahalle(Mahalle mahalle)
        {
            _mahalleDal.Update(mahalle);
        }
    }
}
