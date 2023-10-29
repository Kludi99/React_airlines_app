using React_airlines_common.Dto;
using React_airlines_EFCore.Models;
using Riok.Mapperly.Abstractions;

namespace React_airlines_EFCore.Mapper
{
    [Mapper]
    public static partial class UserMapper
    {
        public static partial UserDto UserToUserDto(User user);
    }
}
