using Autofac;
using EmlakProject.BLL.Abstract;
using EmlakProject.BLL.Concrete;
using EmlakProject.DAL.Abstract;
using EmlakProject.DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmlakProject.BLL.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MusteriBLL>().As<IMusteriBLL>().SingleInstance();
            builder.RegisterType<MusteriDAL>().As<IMusteriDAL>().SingleInstance();

            builder.RegisterType<EmlakciBLL>().As<IEmlakciBLL>();
            builder.RegisterType<EmlakciDAL>().As<IEmlakciDAL>();

            builder.RegisterType<EmlakBilgisiBLL>().As<IEmlakBilgisiBLL>();
            builder.RegisterType<EmlakBilgisiDAL>().As<IEmlakBilgisiDAL>();

        }
    }
}
