using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using ResitalWE.Business.Abstract;
using ResitalWE.Business.Concrete;
using ResitalWE.DataAccess.Abstract;
using ResitalWE.DataAccess.Concrete.EntityFramework;
using ResitalWE.Entities.Concrete;
using ResitalWE.Entities.Report;

namespace ResitalWE.Business.DependecyResolver.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CrKartManager>().As<ICrKartService>();
            builder.RegisterType<EfCrKartDal>().As<ICrKartDal>();

            builder.RegisterType<SKartManager>().As<ISkartService>();
            builder.RegisterType<EfSkartDal>().As<ISkartDal>();

            builder.RegisterType<ChareManager>().As<IChareService>();
            builder.RegisterType<EfCHareDal>().As<ICHareDal>();

            builder.RegisterType<CariHareketOzet>().As<ICariHareketOzet>();
            builder.RegisterType<EfABFCariHareketOzet>().As<IABGCariHareketDal>();

            builder.RegisterType<SatisRaporManager>().As<ISatisRaporService>();
            builder.RegisterType<EfSatisRaporDal>().As<ISatisRaporDal>();

            builder.RegisterType<SatisYillikManager>().As<ISatisYillikService>();
            builder.RegisterType<EFSatisYillikDal>().As<ISatisYillikDal>();

            builder.RegisterType<AlisYillikManager>().As<IAlisYillikService>();
            builder.RegisterType<EfAlisYillikDal>().As<IAlisYillikDal>();
        }
    }
}
