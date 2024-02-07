using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CrudProject.Authorization;

namespace CrudProject
{
    [DependsOn(
        typeof(CrudProjectCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class CrudProjectApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<CrudProjectAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(CrudProjectApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
