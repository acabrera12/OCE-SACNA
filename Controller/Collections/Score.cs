using OCESACNA.Model;
using System.Linq;

namespace OCESACNA.Controller
{
    /// <summary>
    /// Representa una calificación
    /// </summary>
    public class Score : Entity
    {
        /// <summary>
        /// Obtiene o establece el ID
        /// </summary>
        public int ScoreID { get; set; }

        /// <summary>
        /// Obtiene o establece el estudiante
        /// </summary>
        public Student Student { get; set; }

        /// <summary>
        /// Obtiene o establece el 
        /// </summary>
        public Subject Subject { get; set; }

        /// <summary>
        /// Obtiene o esblece la calificación del primer lapso
        /// </summary>
        public float First { get; set; }

        /// <summary>
        /// Obtiene o esblece la calificación del segundo lapso
        /// </summary>
        public float Second { get; set; }

        /// <summary>
        /// Obtiene o esblece la calificación del tercer lapso
        /// </summary>
        public float Third { get; set; }

        /// <summary>
        /// Obtiene o esblece la calificación final
        /// </summary>
        public float Final { get; set; }

        /// <summary>
        /// Obtiene o esblece las inasistencias
        /// </summary>
        public int Absences { get; set; }

        /// <summary>
        /// Letras de calificación
        /// </summary>
        public enum ScoreLetters
        {
            NULL = 0,
            F = 1,
            E = 2,
            D = 3,
            C = 4,
            B = 5,
            A = 6,
            Aa = 7
        }

        /// <summary>
        /// Inicializa una instancia de la clase <see cref="Score"/>
        /// </summary>
        /// <param name="scoreID">ID</param>
        /// <param name="student">Estuadiante</param>
        /// <param name="subject">Asignatura</param>
        /// <param name="first">calificación del primer lapso</param>
        /// <param name="second">calificación del segundo lapso</param>
        /// <param name="third">calificación del tercer lapso</param>
        /// <param name="absences">Inasistencias</param>
        public Score(int scoreID = -1, Student student = null, Subject subject = null, float first = 0, float second = 0, float third = 0, int absences = 0)
        {
            ScoreID = scoreID;
            Student = student;
            Subject = subject;
            First = first;
            Second = second;
            Third = third;
            Final = absences;
        }

        /// <summary>
        /// Calcula el promedio de un arreglo de de calificaciones
        /// </summary>
        /// <param name="values">Arreglo de conjuntos</param>
        /// <returns>Un valor <see langword="float"/> resultante de la operación</returns>
        public static float Average(params float[] values)
        {
            var count = values.Length;
            if (count == 0)
                return 0;

            else if (count == 1)
                return values[0];

            var sum = 0f;
            foreach (float value in values)
                sum += value;

            return sum / count;
        }

        /// <summary>
        /// Obtiene el texto que representa a la letra de calificación poporcionada
        /// </summary>
        /// <param name="scoreLetters">Letra de calificación</param>
        /// <returns>Una cadena que representa a <paramref name="scoreLetters"/></returns>
        public static string GetScoreLettersText(ScoreLetters scoreLetters)
        {
            switch (scoreLetters)
            {
                case ScoreLetters.NULL:
                    return "Nulo";
                case ScoreLetters.F:
                    return "F";
                case ScoreLetters.E:
                    return "E";
                case ScoreLetters.D:
                    return "D";
                case ScoreLetters.C:
                    return "C";
                case ScoreLetters.B:
                    return "B";
                case ScoreLetters.A:
                    return "A";
                case ScoreLetters.Aa:
                    return "A+";
                default:
                    return "Error";
            }
        }

        /// <summary>
        /// Obtiene la letra correspondiente a calificación proporcionada
        /// </summary>
        /// <param name="score">Calificación</param>
        /// <returns></returns>
        public static ScoreLetters GetScoreLetter(float score)
        {
            if (score == 20)            //20 puntos
            {
                return ScoreLetters.Aa;
            }
            else if (score >= 18)       //18-19 puntos
            {
                return ScoreLetters.A;
            }
            else if (score >= 14)        //14-17 puntos
            {
                return ScoreLetters.B;
            }
            else if (score >= 12)        //12-13 puntos
            {
                return ScoreLetters.C;
            }
            else if (score >= 10)        //10-11 puntos
            {
                return ScoreLetters.E;
            }
            else                        //0-9 puntos
            {
                return ScoreLetters.F;
            }
        }

        /// <summary>
        /// <see cref="DBScore"/> -> <see cref="Score"/>
        /// </summary>
        public static implicit operator Score(DBScore DBScore)
        {
            var score = new Score()
            {
                ScoreID = DBScore.ScoreID,
                Student = DataController.GetStudent(DBScore.StudentID),
                Subject = DataController.GetSubject(DBScore.SubjetID),
                First = DBScore.First,
                Second = DBScore.Second,
                Third = DBScore.Third
            };

            score.Final = Average(score.First, score.Second, score.Third);
            return score;
        }

        /// <summary>
        /// <see cref="Score"/> -> <see cref="DBScore"/>
        /// </summary>
        public static implicit operator DBScore(Score score)
        {
            return new DBScore()
            {
                ScoreID = score.ScoreID,
                StudentID = score.Student.StudentID,
                SubjetID = score.Subject.SubjetID,
                First = score.First,
                Second = score.Second,
                Third = score.Third,
                Final = score.Final,
                Absences = score.Absences
            };
        }
    }
}
