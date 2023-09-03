using System.Security.Claims;

namespace CarSharing.Web.Infrastructure
{
    public static class ClaimsPrincipalExtensions
    {
        //Returns the current User's ID in string format
        public static string? GetId(this ClaimsPrincipal user)
        {
            return user.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}
