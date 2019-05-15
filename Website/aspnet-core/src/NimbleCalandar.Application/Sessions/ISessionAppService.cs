using System.Threading.Tasks;
using Abp.Application.Services;
using NimbleCalandar.Sessions.Dto;

namespace NimbleCalandar.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
