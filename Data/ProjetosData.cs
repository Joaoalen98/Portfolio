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
                Descricao = "Portfolio criado em Blazor WebAssembly, utilizando a biblioteca MudBlazor",
                RepoUrl = "https://github.com/Joaoalen98/Portfolio",
                Tecnologias = new List<string>
                {
                    "Blazor Web Assembly",
                },
            },
            new ProjetoModel
            {
                Titulo = "Controle de Gastos",
                Descricao = @"Aplicação para controle de despesas e receitas criadas com ASP.NET Core + Angular, 
                    com foco no estudo dos fundamentos do Angular, como organização da aplicação por módulos, 
                    componetização e reaproveitando de componentes, interceptadores de HTTP e route Guards.",
                RepoUrl = "https://github.com/Joaoalen98/ControleGastos",
                Tecnologias = new List<string>
                {
                    "Angular",
                    "ASP NET Core WebAPI",
                },
            },
            new ProjetoModel
            {
                Titulo = "Cadastro Contatos",
                Descricao = "Projeto desenvolvido com ASP NET CORE API e Angular, para cadastro e gerenciamento de contatos, além de um sistema de login",
                RepoUrl = "https://github.com/Joaoalen98/CadastroContatos",
                Tecnologias = new List<string>
                {
                    "SQLite",
                    "ASP.NET WebAPI",
                    "Angular"
                },
            },
            new ProjetoModel
            {
                Titulo = "Net Bank",
                Descricao = "Aplicativo de banco fictício desenvolvido em NET MAUI e Web API",
                RepoUrl = "https://github.com/Joaoalen98/NetBank",
                Tecnologias = new List<string>
                {
                    "SQL Server",
                    "ASP.NET WebAPI",
                    ".NET MAUI",
                },
            },
            new ProjetoModel {
                Titulo = "API Autenticação JWT",
                Descricao = "Sistema de autenticação desenvolvido com Web API e Json Web Token",
                RepoUrl = "https://github.com/Joaoalen98/SistemaAutenticacao",
                Tecnologias = new List<string>
                {
                    "ASP.NET WebAPI"
                },
            },
            new ProjetoModel
            {
                Titulo = "Mvc Autenticação Cookies",
                Descricao = "Projeto demonstrando a autenticação por cookies do ASP.NET Identity",
                RepoUrl = "https://github.com/Joaoalen98/MvcAutenticacao",
                Tecnologias = new List<string>
                {
                    "ASP.NET MVC"
                },
            }
        };
    }
}