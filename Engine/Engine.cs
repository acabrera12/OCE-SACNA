using System;
using System.Collections.Generic;
using System.Linq;
using OCESACNA.Engine.Collections;
using OCESACNA.Engine.Core;

namespace OCESACNA.Engine
{
    /// <summary>
    /// Controlador de los administradores
    /// </summary>
    public static class Engine
    {
        /// <summary>
        /// Inicializa todos los administradores
        /// </summary>
        public static void Initialize(string ServerHost = "localhost")
        {
            AuthManager.Init();
            UpdateManager.Init();
            ConnectManager.Init(ServerHost);

            UpdateData(null, EventArgs.Empty);
            ConnectManager.DataModified.Connect(UpdateData);
            UpdateManager.Updated.Connect(Update);
        }

        /// <summary>
        /// Obtiene una cadena de referencia para la conversion de fomatos <see cref="DateTime"/> de la base de datos
        /// </summary>
        public const string DBDateTimeFormat = "yyyy-MM-dd HH:mm:ss";
        /// <summary>
        /// Usado como referencia para mostrar texto que utilize <see cref="YearsKeys"></see>
        /// </summary>
        public static string[] YearsNames = { "1º Año", "2º Año", "3º Año", "4º Año", "5º Año" };
        /// <summary>
        /// Usado como referencia para acceder a valores relacionados al los cursos
        /// </summary>
        public static string[] YearsKeys = { "1thYear", "2thYear", "3thYear", "4thYear", "5thYear" };
        /// <summary>
        /// Usado como referencia para mostrar los lapsos
        /// </summary>
        public static string[] Lapses = { "Primer Lapso", "Segundo Lapso", "Tercer Lapso" };
        /// <summary>
        /// Lista de cursos
        /// </summary>
        public static List<Course> Courses { get; private set; }
        /// <summary>
        /// Lista de Representantes
        /// </summary>
        public static List<Representative> Representatives { get; private set; }
        /// <summary>
        /// Lista de Calificaciones
        /// </summary>
        public static List<Score> Scores { get; private set; }
        /// <summary>
        /// Lista de estudiantes
        /// </summary>
        public static List<Student> Students { get; private set; }
        /// <summary>
        /// Lista de Asignaturas
        /// </summary>
        public static List<Subject> Subjects { get; private set; }
        /// <summary>
        /// Lista de Areas de formacion
        /// </summary>
        public static List<SubjectModule> SubjectModules { get; private set; }
        /// <summary>
        /// Lista de docentes
        /// </summary>
        public static List<Teacher> Teachers { get; private set; }

        /// <summary>
        /// Actualiza las listas
        /// </summary>
        private static void UpdateData(object sender, EventArgs e)
        {
            ConnectManager.GetAllCourses(ReciveCourses);
            ConnectManager.GetAllRepresentatives(ReciveRepresentatives);
            ConnectManager.GetAllSbjetModules(ReciveSubjectModules);
            ConnectManager.GetAllTeachers(ReciveTeachers);
            ConnectManager.GetAllScores(ReciveScores);
            ConnectManager.GetAllStudents(ReciveStudents);
            ConnectManager.GetAllSubjects(ReciveSubjects);
        }

        /// <summary>
        /// Usado para tener referencia del tiempo transcurrido
        /// </summary>
        private static float TranscurredTime = 0f;

        /// <summary>
        /// Actualiza el Administrador "<see cref="Engine"/>"
        /// </summary>
        private static void Update(object sender, EventArgs e)
        {
            TranscurredTime += (float)(UpdateManager.MillisecondsDelay * 0.001);

            if (TranscurredTime >= 10f)
            {
                TranscurredTime = 0f;
                UpdateData(null, EventArgs.Empty);
            }
        }

        #region Data Reception
        private static void ReciveCourses(object sender, RequestEventArgs e)
        {
            Course[] list = new Course[e.Response.Count];

            int index = 0;
            foreach (Dictionary<string, dynamic> dic in e.Response)
            {
                list.SetValue(ConversionManager.DictionaryToCourse(dic), index);
                index++;
            }

            Courses = list.ToList();
        }

        private static void ReciveRepresentatives(object sender, RequestEventArgs e)
        {
            Representative[] list = new Representative[e.Response.Count];

            int index = 0;
            foreach (Dictionary<string, dynamic> dic in e.Response)
            {
                list.SetValue(ConversionManager.DictionaryToRprsentative(dic), index);
                index++;
            }

            Representatives = list.ToList();
        }

        private static void ReciveScores(object sender, RequestEventArgs e)
        {
            Score[] list = new Score[e.Response.Count];

            int index = 0;
            foreach (Dictionary<string, dynamic> dic in e.Response)
            {
                list.SetValue(ConversionManager.DictionaryToScore(dic), index);
                index++;
            }

            Scores = list.ToList();
        }

        private static void ReciveStudents(object sender, RequestEventArgs e)
        {
            Student[] list = new Student[e.Response.Count];

            int index = 0;
            foreach (Dictionary<string, dynamic> dic in e.Response)
            {
                list.SetValue(ConversionManager.DictonaryToStudent(dic), index);
                index++;
            }

            Students = list.ToList();
        }

        private static void ReciveSubjects(object sender, RequestEventArgs e)
        {
            Subject[] list = new Subject[e.Response.Count];

            int index = 0;
            foreach (Dictionary<string, dynamic> dic in e.Response)
            {
                list.SetValue(ConversionManager.DictionaryToSubject(dic), index);
                index++;
            }

            Subjects = list.ToList();
        }

        private static void ReciveSubjectModules(object sender, RequestEventArgs e)
        {
            SubjectModule[] list = new SubjectModule[e.Response.Count];

            int index = 0;
            foreach (Dictionary<string, dynamic> dic in e.Response)
            {
                list.SetValue(ConversionManager.DictionaryToSbjetModule(dic), index);
                index++;
            }

            SubjectModules = list.ToList();
        }

        private static void ReciveTeachers(object sender, RequestEventArgs e)
        {
            Teacher[] list = new Teacher[e.Response.Count];

            int index = 0;
            foreach (Dictionary<string, dynamic> dic in e.Response)
            {
                dic["Course"] = Courses.Find(t => t.CourseID == dic["CourseID"]);
                list.SetValue(ConversionManager.DictionaryToTeacher(dic), index);
                index++;
            }

            Teachers = list.ToList();
        }
        #endregion
    }
}
