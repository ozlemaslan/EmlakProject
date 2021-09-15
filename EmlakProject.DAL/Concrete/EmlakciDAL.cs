using EmlakProject.Core.DataAccess.EntityFramework;
using EmlakProject.DAL.Abstract;
using EmlakProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmlakProject.DAL.Concrete
{
    public class EmlakciDAL : EFRepositoryBase<Emlakci, EmlakContext>, IEmlakciDAL
    {
    }
}
