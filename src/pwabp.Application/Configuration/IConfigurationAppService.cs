using System.Threading.Tasks;
using pwabp.Configuration.Dto;

namespace pwabp.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
