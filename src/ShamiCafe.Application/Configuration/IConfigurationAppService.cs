using System.Threading.Tasks;
using ShamiCafe.Configuration.Dto;

namespace ShamiCafe.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
