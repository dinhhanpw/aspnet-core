using System.Threading.Tasks;
using Abp.Application.Services;
using pwabp.Sessions.Dto;

namespace pwabp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
