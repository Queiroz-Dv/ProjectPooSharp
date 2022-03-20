using Main.NotificationContext;
using Main.SharedContext;

namespace Main.ContentContext
{
  // Dentro dessa classe
  // está tudo que é comum para as outras
  public abstract class Content : Base
  {
    public Content(string title, string url)
    {
      // Construtor para não criar outros campos nulos
      Title = title;
      Url = url;
    }
    public string Title { get; set; }
    public string Url { get; set; }
  }
}