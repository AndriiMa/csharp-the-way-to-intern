using System;

namespace InternshipTest.Person
{
    public class Student
    {
        private String name;

        private Knowledge knowledge;
        public Student(string name, Knowledge knowledge)
        {
            this.name = name;
            this.knowledge = knowledge;
        }

        public String GetName(){
            return name;
        }

        public Knowledge GetKnowledge(){
            return knowledge;
        }

        public override string ToString()
        {
            return $"Name: {this.name}\t Knowlege: {this.knowledge}";
        }
    }
}