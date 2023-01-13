using System.Threading.Tasks;
using Abp.Application.Services;
using ShamiCafe.Authorization.Accounts.Dto;

namespace ShamiCafe.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
