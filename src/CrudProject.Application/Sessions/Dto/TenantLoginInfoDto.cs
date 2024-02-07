using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using CrudProject.MultiTenancy;

namespace CrudProject.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
