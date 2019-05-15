using Abp.Application.Services;
using Abp.Application.Services.Dto;
using NimbleCalandar.MultiTenancy.Dto;

namespace NimbleCalandar.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

