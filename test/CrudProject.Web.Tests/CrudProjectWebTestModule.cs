using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CrudProject.EntityFrameworkCore;
using CrudProject.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace CrudProject.Web.Tests
{
    [DependsOn(
        typeof(CrudProjectWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class CrudProjectWebTestModule : AbpModule
    {
        public CrudProjectWebTestModule(CrudProjectEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CrudProjectWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(CrudProjectWebMvcModule).Assembly);
        }
    }
}