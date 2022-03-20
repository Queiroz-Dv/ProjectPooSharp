namespace Main.ContentContext
{
  public class Article : Content
  {
    public Article(string title, string url)
    : base(title, url) // Repassa para o construtor do content
    {

    }
  }
}