using System;
using System.Collections.Generic;
using InternshipTest.Person;

namespace InternshipTest.Institution.InterLink
{
    public class Internship
    {

        private String intershipName;

        private List<Student> interns = new List<Student>();

        public Internship(string name)
        {
            this.intershipName = name;
        }

        public void addInterns(University university){
            double averageLevel = university.averageKnowlege();

            foreach(Student student in university.getStudents()){
                if(student.GetKnowledge().getLevel() >= averageLevel){
                    interns.Add(student);
                }
            }
        }
        public string GetStudents()
        {
            return string.Join("\n", interns);
        }
    }
}
