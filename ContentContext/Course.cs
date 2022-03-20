using Main.ContentContext.Enums;

namespace Main.ContentContext
{
  public class Course : Content
  {
    public Course(string title, string url)
    : base(title, url) // Repassando para o Content
    {

      //Inicilizar os módulos sempre que criar listas
      Modules = new List<Module>();
    }
    public string Tag { get; set; }
    public IList<Module> Modules { get; set; }
    public int DurationInMinutes { get; set; }
    public EContentLevel Level { get; set; }
  }
}