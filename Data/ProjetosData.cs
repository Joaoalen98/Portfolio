using Portfolio.Models;

namespace Portfolio.Data
{
    public static class ProjetosData
    {
        public static List<ProjetoModel> Projetos = new List<ProjetoModel>
        {
            new ProjetoModel
            {
                Titulo = "Portfolio (este projeto)",
                Descricao = "Portfolio criado em Blazor WebAssembly",
                RepoUrl = "https://github.com/Joaoalen98/Portfolio",
                Tecnologias = new List<string> { "C#", "Blazor Web Assembly" },
            },
            new ProjetoModel
            {
                Titulo = "Calc Bolsa",
                Descricao = "Projeto para gerenciamento de operações em renda variável na B3",
                RepoUrl = "https://github.com/Joaoalen98/CalcBolsa",
                Tecnologias = new List<string> { "C#", "Entity Framework", "ASP.NET MVC", "DDD" },
            },
            new ProjetoModel
            {
                Titulo = "Net Bank",
                Descricao = "Aplicativo de banco fictício desenvolvido em NET MAUI e Web API",
                RepoUrl = "https://github.com/Joaoalen98/NetBank",
                Tecnologias = new List<string> { "C#", "Entity Framework", "Web API", "DDD", ".NET MAUI", "Jwt", "Xaml" },
            },
            new ProjetoModel {
                Titulo = "API Autenticação JWT",
                Descricao = "Sistema de autenticação desenvolvido com Web API e Json Web Token",
                RepoUrl = "https://github.com/Joaoalen98/SistemaAutenticacao",
                Tecnologias = new List<string> { "C#", "Web API", "Jwt" },
            },
            new ProjetoModel
            {
                Titulo = "Mvc Autenticação Cookies",
                Descricao = "Projeto demonstrando a autenticação por cookies do ASP.NET Identity",
                RepoUrl = "https://github.com/Joaoalen98/MvcAutenticacao",
                Tecnologias = new List<string> { "C#", "ASP.NET MVC", "Cookie Authentication", "Identity" },
            }
        };
    }
}