using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyBusiness.MultiTenancy.Dto;

namespace MyBusiness.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

