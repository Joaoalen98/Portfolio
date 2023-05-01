﻿using Newtonsoft.Json;
using Portfolio.Models;

namespace Portfolio.Services
{
    public class GithubApiService
    {
        private HttpClient _http;

        public GithubApiService()
        {
            _http = new HttpClient()
            {
                BaseAddress = new Uri("https://api.github.com"),
            };
        }



        public async Task<Owner> GetDonoRepositorio(string userName)
        {
            var req = await _http.GetAsync($"users/{userName}");

            if (req.IsSuccessStatusCode)
            {
                var res = await req.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Owner>(res);
            }
            else
            {
                throw new Exception($"Erro ao requisitar usuário do GitHub");
            }
        }



        public async Task<IEnumerable<GitHubRepository>> GetRepositorios(string userName)
        {
            var req = await _http.GetAsync($"users/{userName}/repos");

            if (req.IsSuccessStatusCode)
            {
                var res = await req.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<GitHubRepository>>(res);
            }
            else
            {
                throw new Exception($"Erro ao requisitar repositórios");
            }
        }
    }
}
