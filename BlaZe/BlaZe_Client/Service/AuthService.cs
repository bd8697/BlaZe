using BlaZe_Client.Service.IService;
using Blazored.LocalStorage;
using Common;
using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Components.Authorization;

namespace BlaZe_Client.Service
{
    public class AuthService : IAuthenticationService
    {
        private readonly HttpClient httpClient;
        private readonly ILocalStorageService localStorage;
        private readonly AuthenticationStateProvider authStateProvider;

        public AuthService(HttpClient httpClientPar, ILocalStorageService localStoragePar, AuthenticationStateProvider authStateProviderPar)
        {
            httpClient = httpClientPar;
            localStorage = localStoragePar;
            authStateProvider = authStateProviderPar;
        }

        public async Task<AuthResponseDTO> Login(AuthDTO user)
        {
            var content = JsonConvert.SerializeObject(user);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("api/account/signin", bodyContent);
            var contentTemp = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<AuthResponseDTO>(contentTemp);

            if (response.IsSuccessStatusCode)
            {
                await localStorage.SetItemAsync(Static.Token, result.Token);
                await localStorage.SetItemAsync(Static.User, result.UserDTO);
                ((AuthStateProvider)authStateProvider).NotifyLogin(result.Token);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", result.Token);

                return new AuthResponseDTO { isAuthSucc = true };
            }
            else
            {
                return result;
            }
        }

        public async Task Logout()
        {
            await localStorage.RemoveItemAsync(Static.Token);
            await localStorage.RemoveItemAsync(Static.User);
            ((AuthStateProvider)authStateProvider).NotifyLogout();
            httpClient.DefaultRequestHeaders.Authorization = null;
        }

        public async Task<RegistrationResponseDTO> RegisterUser(UserRequestDTO user)
        {
            var content = JsonConvert.SerializeObject(user);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("api/account/signup", bodyContent);
            var contentTemp = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<RegistrationResponseDTO>(contentTemp);

            if (response.IsSuccessStatusCode)
            {
                return new RegistrationResponseDTO { isRegSucc = true };
            }
            else
            {
                return result;
            }
        }
    }
}
