namespace Main.ContentContext
{
  // Dentro dessa classe
  // está tudo que é comum para as outras
  public abstract class Content
  {
    public Content(string title, string url)
    {
      // Construtor para não criar outros Id's e campos nulos
      Id = Guid.NewGuid();
      Title = title;
      Url = url;
    }
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Url { get; set; }
  }
}