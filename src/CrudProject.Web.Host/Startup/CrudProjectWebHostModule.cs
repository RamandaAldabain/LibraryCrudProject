using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CrudProject.Configuration;

namespace CrudProject.Web.Host.Startup
{
    [DependsOn(
       typeof(CrudProjectWebCoreModule))]
    public class CrudProjectWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public CrudProjectWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CrudProjectWebHostModule).GetAssembly());
        }
    }
}
