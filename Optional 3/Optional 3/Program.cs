using Optional_3.Models;

namespace Optional_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Student Nurlan = new Student("Nurlan", false, false);
            Student Kamil = new Student("Kamil", true, false);
            Student Anar = new Student("Anar", true, true);
            Student Emil = new Student("Emil", false, true);
            Lion lion = new Lion();

            Student[] students = { Nurlan, Kamil, Anar, Emil };


            foreach (Student student in students)
            {
                if (student.IsPlagiated || student.IsHelpedToPlagiate)
                {

                    lion.Parçalamaq(student);

                }
                if (student.IsPlagiated == false && student.IsHelpedToPlagiate == false)
                {
                    Console.WriteLine($"{student.Name} Halal olsun sene. bir 100luk hak edirsen\n" );
                }
            }
        }
    }
}
