using Abp.Authorization;
using pwabp.Authorization.Roles;
using pwabp.Authorization.Users;

namespace pwabp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
