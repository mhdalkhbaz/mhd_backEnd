using Abp.Application.Services;
using ShamiCafe.MultiTenancy.Dto;

namespace ShamiCafe.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

