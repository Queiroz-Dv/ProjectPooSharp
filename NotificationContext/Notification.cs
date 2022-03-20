namespace Main.NotificationContext
{
  //Essa classe segue um padrão para todo o sistema
  public sealed class Notification
  {
    public Notification()
    {
      
    }

    public Notification(string property, string message)
    {
      Property = property;
      Message = message;
    }

    public string Property { get; set; }
    public string Message { get; set; }
  }
}