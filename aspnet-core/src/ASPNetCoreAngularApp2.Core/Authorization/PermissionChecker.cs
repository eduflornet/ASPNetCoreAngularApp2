using Abp.Authorization;
using ASPNetCoreAngularApp2.Authorization.Roles;
using ASPNetCoreAngularApp2.Authorization.Users;

namespace ASPNetCoreAngularApp2.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
