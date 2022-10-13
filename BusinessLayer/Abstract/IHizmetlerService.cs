using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IHizmetlerService
    {
        List<Hizmetler> GetList();
        List<Hizmetler> GetListHizmet();
        void HizmetlerAdd(Hizmetler hizmetler);
        void HizmetlerDelete(Hizmetler hizmetler);
        void HizmetlerUpdate(Hizmetler hizmetler);
        Hizmetler GetById(int id);
        Hizmetler GetByIdHizmet(int id);
    }
}
