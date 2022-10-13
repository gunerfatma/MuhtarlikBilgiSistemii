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
    public class MuhtarLoginManager : IMuhtarLoginService
    {
        IMuhtarDal _muhtarDal;

        public MuhtarLoginManager(IMuhtarDal muhtarDal)
        {
            _muhtarDal = muhtarDal;
        }
        public Muhtar GetMuhtar(string userName, string password)
        {

            return _muhtarDal.Get(x => x.Eposta == userName && x.Sifre == password);
        }

     }
}
