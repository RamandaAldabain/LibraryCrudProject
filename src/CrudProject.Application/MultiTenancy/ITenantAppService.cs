using Abp.Application.Services;
using CrudProject.MultiTenancy.Dto;

namespace CrudProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

