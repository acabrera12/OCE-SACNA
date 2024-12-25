namespace OCESACNA.Engine.DBCollections
{
    public class DBScore
    {
        public int ScoreID { get; set; }
        public int StudentID { get; set; }
        public int SubjectID { get; set; }
        public float First { get; set; }
        public float FirstDef { get; set; }
        public int FirstInas { get; set; }
        public float Second { get; set; }
        public float SecondDef { get; set; }
        public int SecondInas { get; set; }
        public float Third { get; set; }
        public float ThirdDef { get; set; }
        public int ThirdInas { get; set; }
        public float Final { get; set; }
        public float FinalDef { get; set; }
        public int FinalInas { get; set; }

        public DBScore(int scoreid = -1, int studentid = -1, int subjectid = -1, float first = -1f, float firstdef = -1f, int firstinas = -1, float second = -1f, float seconddef = -1f, int secondinas = -1, float third = -1f, float thirddef = -1f, int thirdinas = -1, float final = -1f, float finaldef = -1f, int finalinas = -1)
        {
            this.ScoreID = scoreid;
            this.StudentID = studentid;
            this.SubjectID = subjectid;
            this.First = first;
            this.FirstDef = firstdef;
            this.FirstInas = firstinas;
            this.Second = second;
            this.SecondDef = seconddef;
            this.SecondInas = secondinas;
            this.Third = third;
            this.ThirdDef = thirddef;
            this.ThirdInas = thirdinas;
            this.Final = final;
            this.FinalDef = finaldef;
            this.FinalInas = finalinas;
        }
    }
}