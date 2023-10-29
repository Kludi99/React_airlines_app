using React_airlines_common.Dto;

namespace React_airlines_ServiceInterface
{
    public interface IUserService : IGenericService
    {
        UserDto GetUserById(int id);
    }
}