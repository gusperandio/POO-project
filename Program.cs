using System;
using System.Linq;
using POO.Context;
namespace POO
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
            articles.Add(new Article("Artigo sobre C#", "csharp-iniciantes"));
            articles.Add(new Article("Artigo xamarim forms", "xamarim-forms"));

            // foreach (var item in articles)
            // {   
            //     Console.WriteLine(item.Id);
            //     Console.WriteLine(item.Title);
            //     Console.WriteLine(item.Url + "\n");
            // }

            var courses = new List<Course>();
            var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
            var courseCSharp = new Course("Fundamentos C#", "fundamentos-csharp");
            var courseXamarim = new Course("Fundamentos Xamarim", "fundamentos-xamarim");
            courses.Add(courseOOP);
            courses.Add(courseCSharp);
            courses.Add(courseXamarim);



            var careers = new List<Career>();
            var carrerXamarim = new Career("Especialista Xamarim", "especialista-xamarim");
            var careerItem2 = new CareerItem(2, "Ultra xamarim APP", "Curso iniciando com xamarim forms", null);
            var careerItem3 = new CareerItem(3, "Layout bala", "Curso iniciando com xamarim forms", courseXamarim);
            var careerItem = new CareerItem(1, "Comece por aqui", "Curso iniciando com xamarim forms", courseXamarim);
            carrerXamarim.Items.Add(careerItem3);
            carrerXamarim.Items.Add(careerItem);
            carrerXamarim.Items.Add(careerItem2);
            careers.Add(carrerXamarim);

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title + "\n");
                foreach (var item in career.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{item.Course?.Title} - {item.Course?.Level}");
                    foreach (var not in item.Notifications)
                    {
                        Console.WriteLine($"{not.Property} - {not.Message}");
                    }
                }
                Console.WriteLine("\n\n");

            }
        }
    }
}