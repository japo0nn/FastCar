using FastCarServer.Data;
using FastCarServer.Migrations;
using System.Security.Claims;

namespace FastCarServer.Helpers
{
    public static class ClaimsExtensions
    {
        public static UserInfo ToUserInfo(this ClaimsPrincipal claimsPrincipal)
        {
            return new UserInfo
            {
                Username = claimsPrincipal.Identity.Name
            };
        }
    }
}
