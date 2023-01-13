using Abp.Application.Services.Dto;

namespace ShamiCafe.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

