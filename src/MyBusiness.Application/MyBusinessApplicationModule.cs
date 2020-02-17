using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyBusiness.Authorization;

namespace MyBusiness
{
    [DependsOn(
        typeof(MyBusinessCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MyBusinessApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MyBusinessAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MyBusinessApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
