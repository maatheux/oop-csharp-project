using Balta.ContentContext;

namespace Balta;
class Program
{
    static void Main(string[] args)
    {
        var course = new Course();
        foreach (var i in course.Modules)
        {
            Console.WriteLine(i);
        } // nao ira dar exception de null pois foi inicializado no constructor
    }
}
