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
    public class OnemliMekanlarManager : IOnemliMekanlarService
    {

        IOnemliMekanlarDal _onemliMekanlarDal;

        public OnemliMekanlarManager(IOnemliMekanlarDal onemliMekanlarDal)
        {
            _onemliMekanlarDal = onemliMekanlarDal;
        }

        public void AddOnemliMekanlar(OnemliMekanlar entity)
        {
            _onemliMekanlarDal.Insert(entity);
        }

        public void DeleteOnemliMekanlar(OnemliMekanlar entity)
        {
            _onemliMekanlarDal.Delete(entity);
        }

        public List<OnemliMekanlar> GetAll()
        {
            return _onemliMekanlarDal.List();
        }

        public List<OnemliMekanlar> GetAllOnemliMekanlar()
        {
            return _onemliMekanlarDal.List();
        }

        public OnemliMekanlar GetById(int id)
        {
            return _onemliMekanlarDal.Get(x => x.OnemliMekanlarId == id);
        }

        public OnemliMekanlar GetByIdOnemliMekanlar(int id)
        {
            return _onemliMekanlarDal.Get(x => x.OnemliMekanlarId == id);
        }

        public List<OnemliMekanlar> GetListOnemliMekanlar()
        {
            return _onemliMekanlarDal.List();
        }

        public void UpdateOnemliMekanlar(OnemliMekanlar entity)
        {
            _onemliMekanlarDal.Update(entity);
        }
    }
}
