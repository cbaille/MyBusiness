using System.Collections.Generic;
using MyBusiness.Roles.Dto;
using MyBusiness.Users.Dto;

namespace MyBusiness.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
