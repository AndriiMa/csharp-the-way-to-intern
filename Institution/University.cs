using InternshipTest.Person;
using System.Collections.Generic;
using System;

namespace InternshipTest.Institution
{
    public class University
    {

        private List<Student> students { get; } = new List<Student>();

        private String universityName { get; set; }
        public University(string name)
        {
            this.universityName = name;
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public List<Student> getStudents(){
            return students;
        }
        public double averageKnowlege()
        {
            int studentsCount = students.Count;
            double result = 0;
            foreach (Student student in students)
            {
                result += student.GetKnowledge().getLevel();
            }

            return result / studentsCount;
        }

    }
}
