using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ASPNetCoreAngularApp2.Configuration;

namespace ASPNetCoreAngularApp2.Web.Host.Startup
{
    [DependsOn(
       typeof(ASPNetCoreAngularApp2WebCoreModule))]
    public class ASPNetCoreAngularApp2WebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ASPNetCoreAngularApp2WebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ASPNetCoreAngularApp2WebHostModule).GetAssembly());
        }
    }
}
