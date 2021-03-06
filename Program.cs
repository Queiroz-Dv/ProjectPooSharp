using System.Net.Http.Headers;
using Main.ContentContext;
//Lista de Artigos
var articles = new List<Article>();
articles.Add(new Article("Artigos sobre C#", "estudos-chsarp"));
articles.Add(new Article("Artigos sobre .NET", "estudos-.net"));
articles.Add(new Article("Artigos sobre EntityFramework", "estudos-entity"));

foreach (var article in articles)
{
  Console.WriteLine(article.Id);
  Console.WriteLine(article.Title);
  Console.WriteLine(article.Url);
}

//Lista de Cursos
var courses = new List<Course>();
var courseCSharp = new Course("Fundamentos de C#", "fundamentos-csharp");
var courseAsp = new Course("Fundamentos de ASP Core", "fundamentos-aspcore");
var courseEF = new Course("Fundamentos de EntityFramework", "fundamentos-entity");

courses.Add(courseCSharp);
courses.Add(courseAsp);
courses.Add(courseEF);

// Lista de Carreiras
var careers = new List<Career>();
var careerDotnet = new Career("Desenvolvedor .NET", "desenvolvedor-dotnet");
var careerItem2 = new CareerItem(2, "Aprenda ASP NET", "", courseAsp);
var careerItem1 = new CareerItem(1, "Comece sua jornada por aqui", "", courseCSharp);
var careerItem3 = new CareerItem(3, "Desenvolva suas habilidades com EF", "", courseEF);

careerDotnet.Items.Add(careerItem2);
careerDotnet.Items.Add(careerItem3);
careerDotnet.Items.Add(careerItem1);

careers.Add(careerDotnet);

// Apresentando dados para o usuário
foreach (var career in careers)
{
  Console.WriteLine(career.Title);
  foreach (var item in career.Items.OrderBy(x => x.Order))
  {
    Console.WriteLine($"{item.Order} - {item.Title}");
    Console.WriteLine(item.Course?.Title);
    // O ponto de interrogação checa se o objeto é nulo
    Console.WriteLine(item.Course?.Level);

    foreach (var notification in item.Notifications)
    {
      Console.WriteLine($"{notification.Property}- {notification.Message}");
    }
  }
}