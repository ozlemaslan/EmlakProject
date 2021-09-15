using System;
using System.Collections.Generic;
using System.Text;

namespace EmlakProject.Core
{
    public class BaseModel
    {
        public BaseModel()
        {
            IsActive = true; // satıldı mı anlamında aktiflik için
            CreateTime = DateTime.Now;
            ModificationTime = DateTime.Now;
        }
        public int Id { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime ModificationTime { get; set; }
        public bool IsActive { get; set; }
    }
}
