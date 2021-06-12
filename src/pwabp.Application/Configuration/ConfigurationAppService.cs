using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using pwabp.Configuration.Dto;

namespace pwabp.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : pwabpAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
