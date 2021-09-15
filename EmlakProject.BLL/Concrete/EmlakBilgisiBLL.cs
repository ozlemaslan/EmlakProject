using EmlakProject.BLL.Abstract;
using EmlakProject.DAL.Abstract;
using EmlakProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmlakProject.BLL.Concrete
{
    public class EmlakBilgisiBLL : IEmlakBilgisiBLL
    {
        private readonly IEmlakBilgisiDAL _emlakBilgisiDAL;
        public EmlakBilgisiBLL(IEmlakBilgisiDAL emlakBilgisiDAL)
        {
            _emlakBilgisiDAL = emlakBilgisiDAL;
        }
        public bool Add(EmlakBilgisi entity)
        {
            return _emlakBilgisiDAL.Add(entity) > 0;
        }

        public bool Delete(int entityID)
        {
            EmlakBilgisi course = _emlakBilgisiDAL.Get(a => a.Id == entityID);
            return _emlakBilgisiDAL.Delete(course) > 0;
        }

        public List<EmlakBilgisi> GetAll()
        {
            return _emlakBilgisiDAL.GetAll().ToList();
        }

        public EmlakBilgisi GetByID(int entityID)
        {
            return _emlakBilgisiDAL.Get(a => a.Id == entityID);
        }

        public ICollection<EmlakBilgisi> GetEmlakBYEmlakciId(int emlakciId)
        {
            ICollection<EmlakBilgisi> emlakBilgisis = _emlakBilgisiDAL.GetAll(a => a.EmlakciId == emlakciId);
            return emlakBilgisis;
        }

        public ICollection<EmlakBilgisi> EmlakBYOdaAndMetre(int oda,decimal metrekare)
        {
            ICollection<EmlakBilgisi> emlakBilgisis = _emlakBilgisiDAL.GetAll(a => a.OdaSayisi == oda && a.MetreKare==metrekare);
            return emlakBilgisis;
        }

        public bool Update(EmlakBilgisi entity)
        {
            return _emlakBilgisiDAL.Update(entity) > 0;
        }
    }
}
