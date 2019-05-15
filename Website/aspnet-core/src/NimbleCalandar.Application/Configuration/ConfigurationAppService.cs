using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using NimbleCalandar.Configuration.Dto;

namespace NimbleCalandar.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : NimbleCalandarAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
