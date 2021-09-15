using EmlakProject.BLL.Abstract;
using EmlakProject.DAL.Abstract;
using EmlakProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmlakProject.BLL.Concrete
{
    public class MusteriBLL : IMusteriBLL
    {
        private readonly IMusteriDAL _musteriDAL;
        public MusteriBLL(IMusteriDAL musteriDAL)
        {
            _musteriDAL = musteriDAL;
        }
        public bool Add(Musteri entity)
        {
            return _musteriDAL.Add(entity) > 0;
        }

        public bool Delete(int entityID)
        {
            Musteri course = _musteriDAL.Get(a => a.Id == entityID);
            return _musteriDAL.Delete(course) > 0;
        }

        public List<Musteri> GetAll()
        {
            return _musteriDAL.GetAll().ToList();
        }

        public Musteri GetByID(int entityID)
        {
            return _musteriDAL.Get(a => a.Id == entityID);
        }

        public bool Update(Musteri entity)
        {
            return _musteriDAL.Update(entity) > 0;
        }
    }
}
