namespace Portfolio.Models
{
    public class ProjetoModel
    {
        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public string RepoUrl { get; set; }

        public string? SiteUrl { get; set; }

        public List<string> Tecnologias { get; set; }
    }
}