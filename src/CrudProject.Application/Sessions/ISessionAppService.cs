using System.Threading.Tasks;
using Abp.Application.Services;
using CrudProject.Sessions.Dto;

namespace CrudProject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
