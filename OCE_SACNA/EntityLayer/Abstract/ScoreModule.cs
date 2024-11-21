namespace EntityLayer.Abstract
{
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
