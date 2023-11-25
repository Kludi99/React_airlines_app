using React_airlines_Core.Interfaces.Models.Dto;
using React_airlines_Core.Interfaces.Services;
using React_airlines_Core.Mapper;
using React_airlines_EFCore.Interfaces.Repositories;
using React_airlines_EFCore.Models;

namespace React_airlines_Core.Features.Users
{
    public class UserService : IUserService
    {
        private IGenericRepository<User> userRepository;

        public UserService(IGenericRepository<User> userRepository)
        {
            this.userRepository = userRepository;
        }
        public async Task<UserDto> GetUserById(int id)
        {
            var user = await userRepository.GetById(id);
            var userDto = UserMapper.UserToUserDto(user);
            return userDto;
        }
    }
}