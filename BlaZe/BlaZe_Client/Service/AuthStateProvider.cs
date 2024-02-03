using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Threading.Tasks;
using BlaZe_Client.Helper;
using Blazored.LocalStorage;
using Common;
using Microsoft.AspNetCore.Components.Authorization;

namespace BlaZe_Client.Service
{
    public class AuthStateProvider: AuthenticationStateProvider
    {
        private readonly HttpClient httpClient;
        private readonly ILocalStorageService localStorage;

        public AuthStateProvider(HttpClient httpClientPar, ILocalStorageService localStoragePar)
        {
            httpClient = httpClientPar;
            localStorage = localStoragePar;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var token = await localStorage.GetItemAsync<string>(Static.Token);
            if (token == null)
            {
                return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));
            }
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", token);
            return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity(JWTParser.ParseClaimsFromJwt(token), "jwtAuthType")));
        }

        public void NotifyLogin(string token)
        {
            var authUser = new ClaimsPrincipal(new ClaimsIdentity(JWTParser.ParseClaimsFromJwt(token), "jwtAuthType"));
            var authState = Task.FromResult(new AuthenticationState(authUser));
            NotifyAuthenticationStateChanged(authState);
        }

        public void NotifyLogout()
        {
            var authState = Task.FromResult(new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity())));
            NotifyAuthenticationStateChanged(authState);
        }
    }
}
