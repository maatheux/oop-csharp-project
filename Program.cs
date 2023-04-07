﻿using Balta.ContentContext;

namespace Balta;
class Program
{
    static void Main(string[] args)
    {
        /////////// Article /////////////////
        /* var articles = new List<Article>();
        articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
        articles.Add(new Article("Artigo sobre C#", "csharp"));
        articles.Add(new Article("Artigo sobre .NET", ".NET"));

        foreach (var article in articles)
        {
            Console.WriteLine($"{article.Id} - {article.Title} - {article.Url}");
        } */

        //////////// Carrer ////////////
        
        var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
        var courseCsharp = new Course("Fundamentos C#", "fundamentos-csharp");
        var courseAspNet = new Course("Fundamentos ASP.NET", "fundamentos-aspnet");

        var courses = new List<Course>();
        courses.Add(courseOOP);
        courses.Add(courseCsharp);
        courses.Add(courseAspNet);
        
        var careers = new List<Career>();
        var careerDotnet = new Career("Especialista .NET", "especialista-dotnet");
        var careerItemDotnet3 = new CareerItem(3, "Aprenda .NET", "", null);
        var careerItemDotnet = new CareerItem(1, "Comece por aqui", "", null);
        var careerItemDotnet2 = new CareerItem(2, "Aprenda OOP", "", null);
        careerDotnet.Items.Add(careerItemDotnet3);
        careerDotnet.Items.Add(careerItemDotnet);
        careerDotnet.Items.Add(careerItemDotnet2);
        careers.Add(careerDotnet);

        foreach (var career in careers)
        {
            Console.WriteLine(career.Title);

            foreach (var careerItem in career.Items.OrderBy(x => x.Order))
            {
                Console.WriteLine($" . {careerItem.Order} - {careerItem.Title}");
            }
        }

    }
}
