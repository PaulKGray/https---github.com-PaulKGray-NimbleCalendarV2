using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using NimbleCalandar.Configuration;

namespace NimbleCalandar.Web.Host.Startup
{
    [DependsOn(
       typeof(NimbleCalandarWebCoreModule))]
    public class NimbleCalandarWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public NimbleCalandarWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(NimbleCalandarWebHostModule).GetAssembly());
        }
    }
}
