using Abp.Authorization;
using NimbleCalandar.Authorization.Roles;
using NimbleCalandar.Authorization.Users;

namespace NimbleCalandar.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
