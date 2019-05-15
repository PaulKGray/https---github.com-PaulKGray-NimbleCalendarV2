using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using NimbleCalandar.Configuration;
using NimbleCalandar.EntityFrameworkCore;
using NimbleCalandar.Migrator.DependencyInjection;

namespace NimbleCalandar.Migrator
{
    [DependsOn(typeof(NimbleCalandarEntityFrameworkModule))]
    public class NimbleCalandarMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public NimbleCalandarMigratorModule(NimbleCalandarEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(NimbleCalandarMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                NimbleCalandarConsts.ConnectionStringName
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
            IocManager.RegisterAssemblyByConvention(typeof(NimbleCalandarMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
