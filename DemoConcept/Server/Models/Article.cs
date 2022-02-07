using DemoConcept.Shared;

namespace DemoConcept.Server.Models
{
    public class ArticleService
    {
        

        public static List<Article> ListeArticle { get; set; } =
            new List<Article>()
        {
            new Article{ Id = 1, Name = "Souris", Price = 10},
            new Article{ Id = 2, Name = "Clavier", Price = 15},
        };
    }

    
}
