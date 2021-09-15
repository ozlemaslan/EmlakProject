using EmlakProject.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmlakProject.Entities
{
    public class Musteri: BaseModel
    {
        public int EmlakciId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string EvTel { get; set; }
        public string CepTel { get; set; }
        public string Email { get; set; }
        public Emlakci Emlakci { get; set; }
    }
}
