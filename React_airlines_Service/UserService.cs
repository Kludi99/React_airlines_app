using React_airlines_common.Dto;
using React_airlines_EFCore.Mapper;
using React_airlines_EFCore.Models;
using React_airlines_RepositoryInterface;
using React_airlines_ServiceInterface;

namespace React_airlines_Service
{
    public class UserService : /*GenericService,*/ IUserService
    {
        private IGenericRepository<User> userRepository;

        public UserService(IGenericRepository<User> userRepository)
        {
            this.userRepository = userRepository;
        }
        public UserDto GetUserById(int id)
        {
            var user = userRepository.GetById(id);
            var userDto = UserMapper.UserToUserDto(user);
            return userDto;
        }
    }
}