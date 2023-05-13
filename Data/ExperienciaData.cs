using Portfolio.Models;

namespace Portfolio.Data
{
    public static class ExperienciaData
    {
        public static List<ExperienciaModel> Experiencias = new List<ExperienciaModel>
        {
            new ExperienciaModel
            {
                Empresa = "Seu Din",
                Ocupacao = "Desenvolvedor .NET Jr.",
                Duracao = "10/2022 - 05/2023",
                Tecnologias = new List<string>() { "HTML", "CSS", "Javascript", "Jquery", ".NET Core", ".NET Framework", "SQL Server" },
            },
            new ExperienciaModel
            {
                Empresa = "Mundo Pago",
                Ocupacao = "Desenvolvedor .NET Jr.",
                Duracao = "05/2023 - atualmente",
                Tecnologias = new List<string>() { "Angular", "Jquery", ".NET Core", ".NET Framework", "SQL Server" },
            }
        };
    }
}