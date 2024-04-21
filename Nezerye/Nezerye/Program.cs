using Nezerye.Models;

namespace Nezerye
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group ab106 = new("AB106");
            Group ab105 = new("AB105");

            List<Student> students = new();

            students.Add(new Student("Nurlan", "Abbasov", 20, 270, ab105));
            students.Add(new Student("abcd", "dcba", 20, 190, ab106));
            students.Add(new Student("Anar", "Gasimzada", 19, 300, ab105));
            students.Add(new Student("Shahin", "Alizada", 20, 310, ab105));
            students.Add(new Student("Rauf", "Dostuyev", 21, 350, ab106));
            students.Add(new Student("Garib", "Garibzada", 20, 150, ab106));

           /* students.FindAll(s => s.Group == ab106)
                .ForEach(s => Console.WriteLine(s.Id + " " + s.Name));*/

           /* students.FindAll(s => s.Credits < 300)
                .ForEach(s => Console.WriteLine(s.Id + " " + s.Name));*/

               /*students.ForEach(s => Console.WriteLine(s.Name + " " + s.Surname));*/

            /*students.FindAll(s => s.Name.ToLower().Contains("b") )
               .ForEach(s => Console.WriteLine(s.Id + " " + s.Name));*/

            students.FindAll(s.Orderby(s => s.Credits);
               .ForEach(s => Console.WriteLine(s.Id + " " + s.Name));

           /* Console.WriteLine(students.Sum(s=>s.Credits));*/


           /* students.FindAll(s => s.Age < 18)
                .ForEach(s => Console.WriteLine(s.Id + " " + s.Name));*/

           /* students.FindAll(s => s.Credits > 200)
                .ForEach(s => Console.WriteLine(s.Id + " " + s.Name));*/

            students.FindAll(s => )
               .ForEach(s => Console.WriteLine(s.Id + " " + s.Name));

            

        }
    }
}
