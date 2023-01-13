using Abp.Authorization;
using ShamiCafe.Authorization.Roles;
using ShamiCafe.Authorization.Users;

namespace ShamiCafe.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
