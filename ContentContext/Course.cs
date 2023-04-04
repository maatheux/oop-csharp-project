namespace Balta.ContentContext;

public class Course : Content
{
  public Course ()
  {
    Modules = new List<Module>();
  }

  public string? Tag { get; set; }
  public IList<Module> Modules { get; set; } // recomendado sempre inicializar uma lista para nao ter exception de null, de preferencia no constructor
}

public class Module
{
  public Module ()
  {
    Lectures = new List<Lecture>();
  }

  public int Order { get; set; }
  public string? Title { get; set; }
  public IList<Lecture> Lectures { get; set; }
}

public class Lecture
{
  public int Order { get; set; }
  public string? Title { get; set; }
}
