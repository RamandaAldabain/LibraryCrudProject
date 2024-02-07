using Abp.Authorization;
using CrudProject.Authorization.Roles;
using CrudProject.Authorization.Users;

namespace CrudProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
