using Balta.ContentContext;

namespace Balta;
class Program
{
    static void Main(string[] args)
    {
        var articles = new List<Article>();
        articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
        articles.Add(new Article("Artigo sobre C#", "csharp"));
        articles.Add(new Article("Artigo sobre .NET", ".NET"));

        foreach (var article in articles)
        {
            Console.WriteLine($"{article.Id} - {article.Title} - {article.Url}");
        }
    }
}
