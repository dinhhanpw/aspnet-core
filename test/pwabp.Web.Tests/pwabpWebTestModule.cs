using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using pwabp.EntityFrameworkCore;
using pwabp.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace pwabp.Web.Tests
{
    [DependsOn(
        typeof(pwabpWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class pwabpWebTestModule : AbpModule
    {
        public pwabpWebTestModule(pwabpEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(pwabpWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(pwabpWebMvcModule).Assembly);
        }
    }
}