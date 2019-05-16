using IdentityServer4;
using IdentityServer4.Models;
using IdentityServer4.Quickstart.UI;
using IdentityServer4.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace IdentityServer
{
    public static class Config
    {

        /// <summary>
        /// Identity resources map to scopes that give access to identity related information
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),             // ensures OpenID claims are included (EG: SubjectID)
                new IdentityResources.Profile(),            // ensures Profile claims are included (EG: CompanyName)
                new IdentityResource(                       // new scope
                    "roles", 
                    "Your role(s)", 
                    new List<string>() { "role" })          // list of claims attributed to this scope
            };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {
                /// IMPORTANT: The client details declared in here must be matched with their exact copy on the client
                new Client
                {
                    ClientId = "3TL",
                    ClientName = "3 Tier Logistics",
                    //using hybrid flow to authenticate users
                    AllowedGrantTypes = GrantTypes.Hybrid,
                    // limits the URIs the user can be redirected to after getting authenticated or logging out
                    RedirectUris = {"https://localhost:44321/signin-oidc" },
                    PostLogoutRedirectUris = { "https://localhost:44321/signout-callback-oidc" },
                    AllowedScopes =                                     // configures the allowed scopes for this particular client (aka what user info to share from all the available)
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "roles"
                    },
                    ClientSecrets =
                    {
                        new Secret("test_secret".Sha256())
                    }
                }
            };
        }

        public static List<TestUser> GetUsers()
        {
            return TestUsers.Users;
        }
    }

}
