// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityModel;
using IdentityServer4.Test;
using System.Collections.Generic;
using System.Security.Claims;

namespace IdentityServer4.Quickstart.UI
{
    public class TestUsers
    {
        public static List<TestUser> Users = new List<TestUser>
        {
            new TestUser{SubjectId = "1", Username = "Andrei ApS", Password = "123456", 
                Claims = 
                {
                    new Claim(JwtClaimTypes.Name, "Andrei ApS"),
                    new Claim(JwtClaimTypes.Role, "customer"),
                    new Claim(JwtClaimTypes.GivenName, "Andrei"),
                    new Claim(JwtClaimTypes.FamilyName, "ApS"),
                    new Claim(JwtClaimTypes.Email, "AliceSmith@email.com"),
                    new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                    new Claim(JwtClaimTypes.WebSite, "http://alice.com"),
                    new Claim(JwtClaimTypes.Address, @"{ 'street_address': 'One Hacker Way', 'locality': 'Heidelberg', 'postal_code': 69118, 'country': 'Germany' }", IdentityServer4.IdentityServerConstants.ClaimValueTypes.Json)
                }
            },
            new TestUser{SubjectId = "10", Username = "crudenc a.s.", Password = "123456",
                Claims =
                {
                    new Claim(JwtClaimTypes.Name, "Patricia ApS"),
                    new Claim(JwtClaimTypes.Role, "contractor"),
                    new Claim(JwtClaimTypes.GivenName, "Andrei"),
                    new Claim(JwtClaimTypes.FamilyName, "ApS"),
                    new Claim(JwtClaimTypes.Email, "AliceSmith@email.com"),
                    new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                    new Claim(JwtClaimTypes.WebSite, "http://alice.com"),
                    new Claim(JwtClaimTypes.Address, @"{ 'street_address': 'One Hacker Way', 'locality': 'Heidelberg', 'postal_code': 69118, 'country': 'Germany' }", IdentityServer4.IdentityServerConstants.ClaimValueTypes.Json)
                }
            },
            new TestUser{SubjectId = "2", Username = "Patricia ApS", Password = "123456",
                Claims =
                {
                    new Claim(JwtClaimTypes.Name, "Andrei ApS"),
                    new Claim(JwtClaimTypes.Role, "customer"),
                    new Claim(JwtClaimTypes.GivenName, "Andrei"),
                    new Claim(JwtClaimTypes.FamilyName, "ApS"),
                    new Claim(JwtClaimTypes.Email, "AliceSmith@email.com"),
                    new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                    new Claim(JwtClaimTypes.WebSite, "http://alice.com"),
                    new Claim(JwtClaimTypes.Address, @"{ 'street_address': 'One Hacker Way', 'locality': 'Heidelberg', 'postal_code': 69118, 'country': 'Germany' }", IdentityServer4.IdentityServerConstants.ClaimValueTypes.Json)
                }
            },
            new TestUser{SubjectId = "3", Username = "Duchon ApS", Password = "123456",
                Claims =
                {
                    new Claim(JwtClaimTypes.Name, "Andrei ApS"),
                    new Claim(JwtClaimTypes.Role, "customer"),
                    new Claim(JwtClaimTypes.GivenName, "Andrei"),
                    new Claim(JwtClaimTypes.FamilyName, "ApS"),
                    new Claim(JwtClaimTypes.Email, "AliceSmith@email.com"),
                    new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                    new Claim(JwtClaimTypes.WebSite, "http://alice.com"),
                    new Claim(JwtClaimTypes.Address, @"{ 'street_address': 'One Hacker Way', 'locality': 'Heidelberg', 'postal_code': 69118, 'country': 'Germany' }", IdentityServer4.IdentityServerConstants.ClaimValueTypes.Json)
                }
            },
            new TestUser{SubjectId = "4", Username = "Piga ApS", Password = "123456",
                Claims =
                {
                    new Claim(JwtClaimTypes.Name, "Andrei ApS"),
                    new Claim(JwtClaimTypes.Role, "customer"),
                    new Claim(JwtClaimTypes.GivenName, "Andrei"),
                    new Claim(JwtClaimTypes.FamilyName, "ApS"),
                    new Claim(JwtClaimTypes.Email, "AliceSmith@email.com"),
                    new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                    new Claim(JwtClaimTypes.WebSite, "http://alice.com"),
                    new Claim(JwtClaimTypes.Address, @"{ 'street_address': 'One Hacker Way', 'locality': 'Heidelberg', 'postal_code': 69118, 'country': 'Germany' }", IdentityServer4.IdentityServerConstants.ClaimValueTypes.Json)
                }
            },
            new TestUser{SubjectId = "5", Username = "Zainuddeen el Bahri", Password = "123456",
                Claims =
                {
                    new Claim(JwtClaimTypes.Name, "Andrei ApS"),
                    new Claim(JwtClaimTypes.Role, "customer"),
                    new Claim(JwtClaimTypes.GivenName, "Andrei"),
                    new Claim(JwtClaimTypes.FamilyName, "ApS"),
                    new Claim(JwtClaimTypes.Email, "AliceSmith@email.com"),
                    new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                    new Claim(JwtClaimTypes.WebSite, "http://alice.com"),
                    new Claim(JwtClaimTypes.Address, @"{ 'street_address': 'One Hacker Way', 'locality': 'Heidelberg', 'postal_code': 69118, 'country': 'Germany' }", IdentityServer4.IdentityServerConstants.ClaimValueTypes.Json)
                }
            },
            new TestUser{SubjectId = "6", Username = "Christian Rakotondrasoa", Password = "123456",
                Claims =
                {
                    new Claim(JwtClaimTypes.Name, "Andrei ApS"),
                    new Claim(JwtClaimTypes.Role, "customer"),
                    new Claim(JwtClaimTypes.GivenName, "Andrei"),
                    new Claim(JwtClaimTypes.FamilyName, "ApS"),
                    new Claim(JwtClaimTypes.Email, "AliceSmith@email.com"),
                    new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                    new Claim(JwtClaimTypes.WebSite, "http://alice.com"),
                    new Claim(JwtClaimTypes.Address, @"{ 'street_address': 'One Hacker Way', 'locality': 'Heidelberg', 'postal_code': 69118, 'country': 'Germany' }", IdentityServer4.IdentityServerConstants.ClaimValueTypes.Json)
                }
            },
            new TestUser{SubjectId = "7", Username = "Amaya G Cardona", Password = "123456",
                Claims =
                {
                    new Claim(JwtClaimTypes.Name, "Andrei ApS"),
                    new Claim(JwtClaimTypes.Role, "customer"),
                    new Claim(JwtClaimTypes.GivenName, "Andrei"),
                    new Claim(JwtClaimTypes.FamilyName, "ApS"),
                    new Claim(JwtClaimTypes.Email, "AliceSmith@email.com"),
                    new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                    new Claim(JwtClaimTypes.WebSite, "http://alice.com"),
                    new Claim(JwtClaimTypes.Address, @"{ 'street_address': 'One Hacker Way', 'locality': 'Heidelberg', 'postal_code': 69118, 'country': 'Germany' }", IdentityServer4.IdentityServerConstants.ClaimValueTypes.Json)
                }
            },
            new TestUser{SubjectId = "8", Username = "Aufderhar, Dare and Crona", Password = "123456",
                Claims =
                {
                    new Claim(JwtClaimTypes.Name, "Andrei ApS"),
                    new Claim(JwtClaimTypes.Role, "contractor"),
                    new Claim(JwtClaimTypes.GivenName, "Andrei"),
                    new Claim(JwtClaimTypes.FamilyName, "ApS"),
                    new Claim(JwtClaimTypes.Email, "AliceSmith@email.com"),
                    new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                    new Claim(JwtClaimTypes.WebSite, "http://alice.com"),
                    new Claim(JwtClaimTypes.Address, @"{ 'street_address': 'One Hacker Way', 'locality': 'Heidelberg', 'postal_code': 69118, 'country': 'Germany' }", IdentityServer4.IdentityServerConstants.ClaimValueTypes.Json)
                }
            },
            new TestUser{SubjectId = "9", Username = "Najeem el Niazi", Password = "123456",
                Claims =
                {
                    new Claim(JwtClaimTypes.Name, "Andrei ApS"),
                    new Claim(JwtClaimTypes.Role, "contractor"),
                    new Claim(JwtClaimTypes.GivenName, "Andrei"),
                    new Claim(JwtClaimTypes.FamilyName, "ApS"),
                    new Claim(JwtClaimTypes.Email, "AliceSmith@email.com"),
                    new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                    new Claim(JwtClaimTypes.WebSite, "http://alice.com"),
                    new Claim(JwtClaimTypes.Address, @"{ 'street_address': 'One Hacker Way', 'locality': 'Heidelberg', 'postal_code': 69118, 'country': 'Germany' }", IdentityServer4.IdentityServerConstants.ClaimValueTypes.Json)
                }
            },
            new TestUser{SubjectId = "11", Username = "Blaaaava s.r.o.", Password = "123456",
                Claims =
                {
                    new Claim(JwtClaimTypes.Name, "Andrei ApS"),
                    new Claim(JwtClaimTypes.Role, "contractor"),
                    new Claim(JwtClaimTypes.GivenName, "Andrei"),
                    new Claim(JwtClaimTypes.FamilyName, "ApS"),
                    new Claim(JwtClaimTypes.Email, "AliceSmith@email.com"),
                    new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                    new Claim(JwtClaimTypes.WebSite, "http://alice.com"),
                    new Claim(JwtClaimTypes.Address, @"{ 'street_address': 'One Hacker Way', 'locality': 'Heidelberg', 'postal_code': 69118, 'country': 'Germany' }", IdentityServer4.IdentityServerConstants.ClaimValueTypes.Json)
                }
            }
        };
    }
}