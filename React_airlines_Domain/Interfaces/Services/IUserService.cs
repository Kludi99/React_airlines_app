using React_airlines_Core.Interfaces.Models.Dto;

namespace React_airlines_Core.Interfaces.Services
{
    public interface IUserService : IGenericService
    {
        Task<UserDto> GetUserById(int id);
    }
}