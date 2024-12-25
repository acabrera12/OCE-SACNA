using OCESACNA.Engine.Collections.Abstract;
namespace OCESACNA.Engine.Collections
{
    public class Score : Entity
    {
        public int ScoreID { get; set; }
        public Student Student { get; set; }
        public Subject Subject { get; set; }
        public ScoreModule First { get; set; }
        public ScoreModule Second { get; set; }
        public ScoreModule Third { get; set; }
        public ScoreModule Final { get; set; }

        public Score()
        {
            this.ScoreID = -1;
            this.Student = new Student();
            this.Subject = new Subject();
            this.First = new ScoreModule();
            this.Second = new ScoreModule();
            this.Third = new ScoreModule();
            this.Final = new ScoreModule();
        }

        public Score(int id, Student student, Subject subject, ScoreModule first, ScoreModule second, ScoreModule third, ScoreModule final)
        {
            this.ScoreID = id;
            this.Student = student;
            this.Subject = subject;
            this.First = first;
            this.Second = second;
            this.Third = third;
            this.Final = final;
        }
    }

    public class ScoreModule
    {
        public float Score { get; set; }
        public float DefScore { get; set; }
        public int Inas { get; set; }

        public ScoreModule(float score = -1f, float def = -1f, int inas = -1)
        {
            this.Score = score;
            this.DefScore = def;
            this.Inas = inas;
        }
    }
}