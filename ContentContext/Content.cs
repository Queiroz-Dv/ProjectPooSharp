namespace Main.ContentContext
{
  // Dentro dessa classe
  // está tudo que é comum para as outras
  public abstract class Content
  {
    public Content()
    {
      // Construtor para não criar outros Id's
      Id = Guid.NewGuid();
    }
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Url { get; set; }
  }
}