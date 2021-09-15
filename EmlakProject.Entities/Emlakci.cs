using EmlakProject.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmlakProject.Entities
{
    public class Emlakci :BaseModel
    {
        public Emlakci()
        {
            Musteris =new HashSet<Musteri>();
            EmlakBilgisis = new HashSet<EmlakBilgisi>();
        }
        public string EmlakciAdi { get; set; }
        public string YetkiliAdSoyad { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public int Fax { get; set; }
        public ICollection<Musteri> Musteris { get; set; }
        public ICollection<EmlakBilgisi> EmlakBilgisis { get; set; }

    }
}
