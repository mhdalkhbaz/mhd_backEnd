using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ShamiCafe.Configuration.Dto;

namespace ShamiCafe.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ShamiCafeAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
