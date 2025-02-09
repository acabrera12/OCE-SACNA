using OCESACNA.Engine.Collections.Abstract;
namespace OCESACNA.Engine.Collections
{
    /// <summary>
    /// Entidad clase <see cref="Score"/> que hace referencia a un registro de la base de datos
    /// </summary>
    public class Score : Entity
    {
        /// <summary>
        /// ID correspondiente a la instancia
        /// </summary>
        public int ScoreID { get; set; }

        /// <summary>
        /// Estudiante asociado a la instancia
        /// </summary>
        public Student Student { get; set; }

        /// <summary>
        /// Asignatura asociada a la instancia
        /// </summary>
        public Subject Subject { get; set; }

        /// <summary>
        /// Hace referencia al conjunto de calificaciones de primer lapso
        /// </summary>
        public ScoreModule First { get; set; }

        /// <summary>
        /// Hace referencia al conjunto de calificaciones de segundo lapso
        /// </summary>
        public ScoreModule Second { get; set; }

        /// <summary>
        /// Hace referencia al conjunto de calificaciones de tercer lapso
        /// </summary>
        public ScoreModule Third { get; set; }

        /// <summary>
        /// Hace referencia al conjunto de calificaciones promediados de los anteriores conjuntos
        /// </summary>
        public ScoreModule Final { get; set; }


        /// <summary>
        /// Inicializa una instancia vacía de la entidad <see cref="Score"/>
        /// </summary>
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

        /// <summary>
        /// Inicializa una instancia de la entidad <see cref="Score"/>
        /// </summary>
        /// <param name="id">ID del registro</param>
        /// <param name="student">Estudiante asociado</param>
        /// <param name="subject">Asignatura asociada</param>
        /// <param name="first">Conjunto de calificaciones de primer lapso</param>
        /// <param name="second">Conjunto de calificaciones de segundo lapso</param>
        /// <param name="third">Conjunto de calificaciones de tercer lapso</param>
        /// <param name="final">Conjunto promediado de la calificaciones finales</param>
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

    /// <summary>
    /// Clase <see cref="ScoreModule"/> Conjunto de calificaciones
    /// </summary>
    public class ScoreModule
    {
        /// <summary>
        /// Calificación
        /// </summary>
        public float Score { get; set; }
        /// <summary>
        /// Calificación final
        /// </summary>
        public float DefScore { get; set; }
        /// <summary>
        /// Inasistencias
        /// </summary>
        public int Inas { get; set; }

        /// <summary>
        /// Inicializa una instancia de clase <see cref="ScoreModule"/>
        /// </summary>
        /// <param name="score">Calificación</param>
        /// <param name="def">Calificación definitiva</param>
        /// <param name="inas">Inasistencias</param>
        public ScoreModule(float score = -1f, float def = -1f, int inas = -1)
        {
            this.Score = score;
            this.DefScore = def;
            this.Inas = inas;
        }
    }
}