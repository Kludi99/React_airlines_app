using React_airlines_Core.Interfaces.Models.Dto;
using React_airlines_EFCore.Models;
using Riok.Mapperly.Abstractions;

namespace React_airlines_Core.Mapper
{
    [Mapper]
    public static partial class UserMapper
    {
        public static partial UserDto UserToUserDto(User user);
    }
}
