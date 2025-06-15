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
        /// Obtiene o esblece el módulo de calificaciones del primer lapso
        /// </summary>
        public ScoreModule FirstLapse { get; set; }

        /// <summary>
        /// Obtiene o esblece el módulo de calificaciones del segundo lapso
        /// </summary>
        public ScoreModule SecondLapse { get; set; }

        /// <summary>
        /// Obtiene o esblece el módulo de calificaciones del tercer lapso
        /// </summary>
        public ScoreModule ThirdLapse { get; set; }

        /// <summary>
        /// Obtiene o esblece el módulo de calificaciones finales
        /// </summary>
        public ScoreModule Final { get; set; }

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
        /// <param name="scoreID"></param>
        /// <param name="student"></param>
        /// <param name="subject"></param>
        /// <param name="firstLapse"></param>
        /// <param name="secondLapse"></param>
        /// <param name="thirdLapse"></param>
        /// <param name="final"></param>
        public Score(int scoreID = -1, Student student = null, Subject subject = null, ScoreModule? firstLapse = null, ScoreModule? secondLapse = null, ScoreModule? thirdLapse = null, ScoreModule? final = null)
        {
            ScoreID = scoreID;
            Student = student;
            Subject = subject;
            FirstLapse = (ScoreModule)firstLapse;
            SecondLapse = (ScoreModule)secondLapse;
            ThirdLapse = (ScoreModule)thirdLapse;
            Final = (ScoreModule)final;
        }

        /// <summary>
        /// Calcula el promedio de un arreglo de conjuntos de calificaciones
        /// </summary>
        /// <param name="values">Arreglo de conjuntos</param>
        /// <returns>Un conjunto <see cref="ScoreModule"/> con valores resultantes del cálculo</returns>
        public static ScoreModule Average(ScoreModule[] values)
        {
            var scores = from item in values select item.Score;
            var scoresdef = from item in values select item.ScoreDef;
            var inas = from item in values select item.Inas;

            float
                totalScores = scores.Sum() / scores.Count(),
                totalScoreDefs = scoresdef.Sum() / scoresdef.Count();

            int totalInas = inas.Sum();

            return new ScoreModule()
            {
                Score = totalScores,
                ScoreDef = totalScoreDefs,
                Inas = totalInas
            };
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

                FirstLapse = new ScoreModule()
                {
                    Score = DBScore.First,
                    ScoreDef = DBScore.FirstDef,
                    Inas = DBScore.FirstInas
                },

                SecondLapse = new ScoreModule()
                {
                    Score = DBScore.Second,
                    ScoreDef = DBScore.SecondDef,
                    Inas = DBScore.SecondInas
                },

                ThirdLapse = new ScoreModule()
                {
                    Score = DBScore.Third,
                    ScoreDef = DBScore.ThirdDef,
                    Inas = DBScore.ThirdInas
                }
            };

            score.Final = Average(new ScoreModule[] { score.FirstLapse, score.SecondLapse, score.ThirdLapse });

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
                First = score.FirstLapse.Score,
                FirstDef = score.FirstLapse.ScoreDef,
                FirstInas = score.FirstLapse.Inas,
                Second = score.SecondLapse.Score,
                SecondDef = score.SecondLapse.ScoreDef,
                SecondInas = score.SecondLapse.Inas,
                Third = score.ThirdLapse.Score,
                ThirdDef = score.ThirdLapse.ScoreDef,
                ThirdInas = score.ThirdLapse.Inas,
                Final = score.Final.Score,
                FinalDef = score.Final.ScoreDef,
                FinalInas = score.Final.Inas
            };
        }
    }

    /// <summary>
    /// Representa un conjunto de calificaciones e inasistencias
    /// </summary>
    public struct ScoreModule
    {
        /// <summary>
        /// Obtiene o establece la calificación
        /// </summary>
        public float Score { get; set; }

        /// <summary>
        /// Obtiene o establece la calificación definitiva
        /// </summary>
        public float ScoreDef { get; set; }

        /// <summary>
        /// Obtiene o establece las inasistencias
        /// </summary>
        public int Inas { get; set; }

        /// <summary>
        /// Inicializa una instancia de la estructura <see cref="ScoreModule"/>
        /// </summary>
        /// <param name="score">Calificación</param>
        /// <param name="scoreDef">Calificación definitiva</param>
        /// <param name="inas">Inasistencias</param>
        public ScoreModule(float score = -1, float scoreDef = -1, int inas = -1)
        {
            Score = score;
            ScoreDef = scoreDef;
            Inas = inas;
        }
    }
}
