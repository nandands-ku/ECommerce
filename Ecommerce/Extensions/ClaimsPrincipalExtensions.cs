using System.Linq;
using System.Security.Claims;

namespace Ecommerce.Extensions
{
    public static class ClaimsPrincipalExtensions
    {
        public static string GetUserEmail(this ClaimsPrincipal User)
        {
            return User?.Claims?.FirstOrDefault(x => x.Type == ClaimTypes.Email)?.Value;

        }
    }
}
