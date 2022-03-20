namespace Main.ContentContext
{
  public class Career : Content
  {
    public Career(string title, string url)
    : base(title, url)
    {
      Items = new List<CareerItem>();
    }
    public IList<CareerItem> Items { get; set; }
    // Podemos usar o expression body ao invés do get
    public int TotalCourses => Items.Count;
  }
}