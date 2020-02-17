using System.Threading.Tasks;
using Abp.Application.Services;
using MyBusiness.Sessions.Dto;

namespace MyBusiness.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
