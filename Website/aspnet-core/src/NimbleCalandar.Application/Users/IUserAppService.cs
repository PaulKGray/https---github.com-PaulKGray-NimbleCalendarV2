using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using NimbleCalandar.Roles.Dto;
using NimbleCalandar.Users.Dto;

namespace NimbleCalandar.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
