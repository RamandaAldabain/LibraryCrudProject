using System.Threading.Tasks;
using CrudProject.Configuration.Dto;

namespace CrudProject.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
