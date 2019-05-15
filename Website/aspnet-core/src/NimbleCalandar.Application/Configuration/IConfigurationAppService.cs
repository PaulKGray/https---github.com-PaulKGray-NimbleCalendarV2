using System.Threading.Tasks;
using NimbleCalandar.Configuration.Dto;

namespace NimbleCalandar.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
