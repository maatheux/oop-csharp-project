namespace Balta.ContentContext;
using Balta.ContentContext.Enums;

public class Course : Content
{
  public Course (string title, string url, EContentLevel level) : base(title, url)
  {
    Modules = new List<Module>();
    Level = level;
  }

  public string? Tag { get; set; }
  public IList<Module> Modules { get; set; }
  public int DurationInMinutes { get; set; }
  public EContentLevel Level { get; set; }

}
