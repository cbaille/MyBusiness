using System.Threading.Tasks;
using MyBusiness.Configuration.Dto;

namespace MyBusiness.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
