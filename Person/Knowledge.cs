namespace InternshipTest.Person
{
    public class Knowledge
    {
        private int level;
        public Knowledge(int level)
        {
            this.level = level;
        }

        public int getLevel(){
            return level;
        }

        public override string ToString()
        {
            return level.ToString();
        }
    }
}
