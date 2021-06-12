using Abp.Application.Services;
using pwabp.MultiTenancy.Dto;

namespace pwabp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

