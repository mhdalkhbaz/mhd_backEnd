using System.Threading.Tasks;
using Abp.Application.Services;
using ShamiCafe.Sessions.Dto;

namespace ShamiCafe.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
