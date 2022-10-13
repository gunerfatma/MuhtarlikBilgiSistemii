using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IEnvanterService
    {
        
        List<Envanter> GetList();
        List<Envanter> GetListEnvanter();
        void AddEnvanter(Envanter envanter);
        Envanter GetById(int id);
        Envanter GetByIdEnvanter(int id);
        void UpdateEnvanter(Envanter envanter);
        void DeleteEnvanter(Envanter envanter);
        List<Envanter> GetAllByMuhtar(int id);


    }
    
    
    
    
    
}
