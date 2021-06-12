using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using pwabp.Authorization;

namespace pwabp
{
    [DependsOn(
        typeof(pwabpCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class pwabpApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<pwabpAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(pwabpApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
