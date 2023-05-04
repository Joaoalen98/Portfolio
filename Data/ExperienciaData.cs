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
                Duracao = "10/2022 - atualmente",
                Tecnologias = new List<string>() { "HTML", "CSS", "Javascript", "Jquery", ".NET Core", ".NET Framework", "SQL Server" },
            }
        };
    }
}