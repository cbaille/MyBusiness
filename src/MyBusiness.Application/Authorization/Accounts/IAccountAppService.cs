using System.Threading.Tasks;
using Abp.Application.Services;
using MyBusiness.Authorization.Accounts.Dto;

namespace MyBusiness.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
