using Abp.Application.Services.Dto;

namespace NimbleCalandar.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

