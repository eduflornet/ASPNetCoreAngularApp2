using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ASPNetCoreAngularApp2.Configuration;
using ASPNetCoreAngularApp2.EntityFrameworkCore;
using ASPNetCoreAngularApp2.Migrator.DependencyInjection;

namespace ASPNetCoreAngularApp2.Migrator
{
    [DependsOn(typeof(ASPNetCoreAngularApp2EntityFrameworkModule))]
    public class ASPNetCoreAngularApp2MigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public ASPNetCoreAngularApp2MigratorModule(ASPNetCoreAngularApp2EntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(ASPNetCoreAngularApp2MigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                ASPNetCoreAngularApp2Consts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ASPNetCoreAngularApp2MigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
