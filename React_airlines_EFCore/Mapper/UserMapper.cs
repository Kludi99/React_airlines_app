using React_airlines_common.Dto;
using React_airlines_EFCore.Models;
using Riok.Mapperly.Abstractions;

namespace React_airlines_EFCore.Mapper
{
    [Mapper]
    public partial class UserMapper
    {
        public partial UserDto UserToUserDto(User user);
    }
}
