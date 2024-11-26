namespace Engine.ClassDB.Asbtract
{
    public class Course
    {
        public int Year { get; set; }
        public int Mention { get; set; }
        public int Section { get; set; }

        public Course(int year, int mention, int section)
        {
            this.Year = year;
            this.Mention = mention;
            this.Section = section;
        }
    }
}
