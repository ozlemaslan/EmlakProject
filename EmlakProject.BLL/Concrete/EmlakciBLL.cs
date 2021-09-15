using EmlakProject.BLL.Abstract;
using EmlakProject.DAL.Abstract;
using EmlakProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmlakProject.BLL.Concrete
{
    public class EmlakciBLL :IEmlakciBLL
    {
        private readonly IEmlakciDAL _emlakciDAL;
        public EmlakciBLL(IEmlakciDAL emlakciDAL)
        {
            _emlakciDAL = emlakciDAL;
        }
        public bool Add(Emlakci entity)
        {
            return _emlakciDAL.Add(entity) > 0;
        }

        public bool Delete(int entityID)
        {
            Emlakci course = _emlakciDAL.Get(a => a.Id == entityID);
            return _emlakciDAL.Delete(course) > 0;
        }

        public List<Emlakci> GetAll()
        {
            return _emlakciDAL.GetAll().ToList();
        }

        public Emlakci GetByID(int entityID)
        {
            return _emlakciDAL.Get(a => a.Id == entityID);
        }

        public bool Update(Emlakci entity)
        {
            return _emlakciDAL.Update(entity) > 0;
        }
    }
}
