using EmlakProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmlakProject.BLL.Abstract
{
    public interface IEmlakBilgisiBLL : IBaseService<EmlakBilgisi>
    {
        
        ICollection<EmlakBilgisi> GetEmlakBYEmlakciId(int emlakciId);
        ICollection<EmlakBilgisi> EmlakBYOdaAndMetre(int oda,decimal metrekare);
    }
}
