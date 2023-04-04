namespace Balta.ContentContext;

public class Career : Content
{

  public Career()
  {
    Items = new List<CareerItem>();
  }

  public IList<CareerItem> Items { get; set; }
  public int TotalCourses => Items.Count; // expression body, podemos usar quando nao temos o set
  
  /* public int TotalCourses 
  { 
    get 
    {
      return Items.Count;
    } 
  }  */ // forma padrao de setar a prop que foi substituida pelo expression body. 
}
