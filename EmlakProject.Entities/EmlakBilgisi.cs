using EmlakProject.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmlakProject.Entities
{
    public class EmlakBilgisi: BaseModel
    {
        public EmlakTur EmlakTuru { get; set; } //enum daha iyi satılık veya kiralık diye
        public int EmlakciId { get; set; }
        public decimal MetreKare { get; set; }
        public int OdaSayisi { get; set; }
        public int Kat { get; set; }
        public int BinaKati { get; set; }
        public Emlakci Emlakci { get; set; }
    }

    public enum EmlakTur
    {
        Satılık= 1,
        Kiralık=2
    }
}
