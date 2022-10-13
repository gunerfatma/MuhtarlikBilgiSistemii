using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IOnemliMekanlarService
    {
        List<OnemliMekanlar> GetAll();
        List<OnemliMekanlar> GetAllOnemliMekanlar();
        void AddOnemliMekanlar(OnemliMekanlar entity);
        OnemliMekanlar GetById(int id);
        OnemliMekanlar GetByIdOnemliMekanlar(int id);
        void UpdateOnemliMekanlar(OnemliMekanlar entity);
        void DeleteOnemliMekanlar(OnemliMekanlar entity);
        List<OnemliMekanlar> GetListOnemliMekanlar();


    }
}
