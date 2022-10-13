using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class EnvanterManager : IEnvanterService
    {
        //ctrl . hazır paket şeklinde constructeri getirir.



        IEnvanterDal _envanterDal;

        public EnvanterManager(IEnvanterDal envanterDal)
        {
            _envanterDal = envanterDal;
        }

        public Envanter GetById(int id)
        {
            return _envanterDal.Get(x => x.EnvanterId == id);
        }

        public List<Envanter> GetList()
        {
            return _envanterDal.List();
        }

        public void AddEnvanter(Envanter envanter)
        {
            _envanterDal.Insert(envanter);
        }

        public void UpdateEnvanter(Envanter envanter)
        {
            _envanterDal.Update(envanter);
        }

        public List<Envanter> GetListEnvanter()
        {
            return _envanterDal.List();
        }

        public Envanter GetByIdEnvanter(int id)
        {
            return _envanterDal.Get(x => x.EnvanterId == id);
        }

        public void DeleteEnvanter(Envanter envanter)
        {
            _envanterDal.Delete(envanter);
        }

        public List<Envanter> GetAllByMuhtar(int id)
        {
            
                return _envanterDal.List(x => x.Mahalle.MuhtarId == id);
          
        }
    }
}
