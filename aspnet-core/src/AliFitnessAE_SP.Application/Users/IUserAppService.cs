using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AliFitnessAE_SP.Roles.Dto;
using AliFitnessAE_SP.Users.Dto;

namespace AliFitnessAE_SP.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);

        Task<bool> ChangePassword(ChangePasswordDto input);
    }
}
