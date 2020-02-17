using Abp.Authorization;
using MyBusiness.Authorization.Roles;
using MyBusiness.Authorization.Users;

namespace MyBusiness.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
