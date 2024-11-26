using Engine.ClassDB.Asbtract;

namespace Engine.ClassDB
{
    public class Score : Entity
    {
        public Student Student { get; set; }
        public Course Course { get; set; }

        public ScoreModule FirsLapse { get; set; }
        public ScoreModule SecondLapse { get; set; }
        public ScoreModule LastLapse { get; set; }
        public ScoreModule FinalScore { get; set; }

        public Score(int id, Student student, Course course, ScoreModule firsLapse, ScoreModule secondLapse, ScoreModule lastLapse, ScoreModule finalScore)
        {
            this.ID = id;
            this.Student = student;
            this.Course = course;
            this.FirsLapse = firsLapse;
            this.SecondLapse = secondLapse;
            this.LastLapse = lastLapse;
            this.FinalScore = finalScore;
        }
    }

    public class ScoreModule
    {
        public float FirsScore { get; set; }
        public float DefScore { get; set; }
        public int Inas { get; set; }

        public ScoreModule(float firsScore, float defScore, int inas)
        {
            this.FirsScore = firsScore;
            this.DefScore = defScore;
            this.Inas = inas;
        }
    }
}
