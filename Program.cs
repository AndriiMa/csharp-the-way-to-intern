using System;
using InternshipTest.Person;
using InternshipTest.Institution;
using InternshipTest.Institution.InterLink;

namespace csharp_oop_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            University university = new University("CH.U.I.");
            university.AddStudent(new Student("Andrew Kostenko", new Knowledge(40)));
            university.AddStudent(new Student("Julia Veselkina", new Knowledge(60)));
            university.AddStudent(new Student("Maria Perechrest", new Knowledge(60)));

            Internship internship = new Internship("Interlink");
            Console.WriteLine("List of internship's students:");
            Console.WriteLine(internship.GetStudents());
        }
    }
}
