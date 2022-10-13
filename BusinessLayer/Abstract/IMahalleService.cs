using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMahalleService
    {
        List<Mahalle> GetList();
        List<Mahalle> GetListMahalle();
        void AddMahalle(Mahalle mahalle);
        void DeleteMahalle(Mahalle mahalle);
        Mahalle GetById(int id);
        void UpdateMahalle(Mahalle mahalle);
       
    }
}
