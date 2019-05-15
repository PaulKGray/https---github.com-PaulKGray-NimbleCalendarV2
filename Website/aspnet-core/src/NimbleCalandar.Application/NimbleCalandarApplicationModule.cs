using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using NimbleCalandar.Authorization;

namespace NimbleCalandar
{
    [DependsOn(
        typeof(NimbleCalandarCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class NimbleCalandarApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<NimbleCalandarAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(NimbleCalandarApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
