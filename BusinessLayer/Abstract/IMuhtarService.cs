using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMuhtarService
    {
        List<Muhtar> GetAll();
        List<Muhtar> GetList();
        List<Muhtar> GetListMuhtar();
        void MuhtarAdd(Muhtar muhtar);
        void MuhtarDelete(Muhtar muhtar);
        void MuhtarUpdate(Muhtar muhtar);
        Muhtar GetById(int id);
        Muhtar GetByIdMuhtar(int id);
        //List<Muhtar> GetAll();

    }
}
