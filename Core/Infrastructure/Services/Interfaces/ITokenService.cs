﻿using AppZeroAPI.Entities;
using AppZeroAPI.Models;
using AppZeroAPI.Shared;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;

namespace AppZeroAPI.Services
{

    public interface ITokenService
    {
        TokenDto generateAccessToken(UserInfo user);

        TokenDto generateRefreshToken(UserInfo user);

        ClaimsPrincipal getPrincipalFromToken(string token);

        bool IsRefreshToken(JwtSecurityToken token);
        int AccessTokenLifeTimeMints();
        ClaimsPrincipal getSession(); 
        JwtSecurityToken decodeToken(string accessToken);
        TokenValidationParameters getTokenValidationParameters();
    }
}
