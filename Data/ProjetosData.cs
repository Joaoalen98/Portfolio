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
                Tecnologias = new List<string> { "Blazor Web Assembly" },
            },
            new ProjetoModel
            {
                Titulo = "Cadastro Contatos",
                Descricao = "Projeto desenvolvido com ASP NET CORE API e Angular, para cadastro e gerenciamento de contatos, além de um sistema de login",
                RepoUrl = "https://github.com/Joaoalen98/CadastroContatos",
                Tecnologias = new List<string> { "Entity Framework", "SQLite", "ASP.NET WebAPI", "Angular" },
            },
            new ProjetoModel
            {
                Titulo = "Calc Bolsa",
                Descricao = "Projeto para gerenciamento de operações em renda variável na B3",
                RepoUrl = "https://github.com/Joaoalen98/CalcBolsa",
                Tecnologias = new List<string> { "Entity Framework", "ASP.NET MVC" },
            },
            new ProjetoModel
            {
                Titulo = "Net Bank",
                Descricao = "Aplicativo de banco fictício desenvolvido em NET MAUI e Web API",
                RepoUrl = "https://github.com/Joaoalen98/NetBank",
                Tecnologias = new List<string> { "Entity Framework", "ASP.NET WebAPI", "MAUI", "XAML" },
            },
            new ProjetoModel {
                Titulo = "API Autenticação JWT",
                Descricao = "Sistema de autenticação desenvolvido com Web API e Json Web Token",
                RepoUrl = "https://github.com/Joaoalen98/SistemaAutenticacao",
                Tecnologias = new List<string> { "ASP.NET WebAPI" },
            },
            new ProjetoModel
            {
                Titulo = "Mvc Autenticação Cookies",
                Descricao = "Projeto demonstrando a autenticação por cookies do ASP.NET Identity",
                RepoUrl = "https://github.com/Joaoalen98/MvcAutenticacao",
                Tecnologias = new List<string> { "ASP.NET MVC" },
            }
        };
    }
}