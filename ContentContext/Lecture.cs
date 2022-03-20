using Main.ContentContext.Enums;

namespace Main.ContentContext
{
  public class Lecture
  {
    public int ClassOrder { get; set; }
    public string Title { get; set; }
    public int DurationInMinutes { get; set; }
    public EContentLevel Level { get; set; }
  }
}