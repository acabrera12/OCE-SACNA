namespace OCESACNA.Controller
{
    public static partial class DataController
    {
        /// <summary>
        /// Delegado encargado de soportar los evento relacionados con la modificación de los datos
        public delegate void DataModifiedEventHandler();

        /// <summary>
        /// Evento llamado cuando <see cref="DataController"/> informa que los datos de los usurios han sido modificados
        /// </summary>
        public static event DataModifiedEventHandler UserDataModified;

        /// <summary>
        /// Evento llamado cuando <see cref="DataController"/> informa que los datos de los cursos han sido modificados
        /// </summary>
        public static event DataModifiedEventHandler CourseDataModified;

        /// <summary>
        /// Evento llamado cuando <see cref="DataController"/> informa que los datos de los representantes han sido modificados
        /// </summary>
        public static event DataModifiedEventHandler RepresentativeDataModified;

        /// <summary>
        /// Evento llamado cuando <see cref="DataController"/> informa que los datos de los docentes han sido modificados
        /// </summary>
        public static event DataModifiedEventHandler TeacherDataModified;

        /// <summary>
        /// Evento llamado cuando <see cref="DataController"/> informa que los datos de las áreas de formación han sido modificados
        /// </summary>
        public static event DataModifiedEventHandler SubjectModuleDataModified;

        /// <summary>
        /// Evento llamado cuando <see cref="DataController"/> informa que los datos de las asignaturas han sido modificados
        /// </summary>
        public static event DataModifiedEventHandler SubjectDataModified;

        /// <summary>
        /// Evento llamado cuando <see cref="DataController"/> informa que los datos de los estudiantes han sido modificados
        /// </summary>
        public static event DataModifiedEventHandler StudentDataModified;

        /// <summary>
        /// Evento llamado cuando <see cref="DataController"/> informa que los datos de las materias pendientes han sido modificados
        /// </summary>
        public static event DataModifiedEventHandler PendingSubjectDataModified;

        /// <summary>
        /// Evento llamado cuando <see cref="DataController"/> informa que los datos de las calificaciones han sido modificados
        /// </summary>
        public static event DataModifiedEventHandler ScoreDataModified;

        /// <summary>
        /// Dispara el evento <see cref="UserDataModified"/>
        /// </summary>
        private static void OnUserDataModified()
        {
            UserDataModified?.Invoke();
        }

        /// <summary>
        /// Dispara el evento <see cref="CourseDataModified"/>
        /// </summary>
        private static void OnCourseDataModified()
        {
            CourseDataModified?.Invoke();
        }

        /// <summary>
        /// Dispara el evento <see cref="RepresentativeDataModified"/>
        /// </summary>
        private static void OnRepresentativeDataModified()
        {
            RepresentativeDataModified?.Invoke();
        }

        /// <summary>
        /// Dispara el evento <see cref="TeacherDataModified"/>
        /// </summary>
        private static void OnTeacherDataModified()
        {
            TeacherDataModified?.Invoke();
        }

        /// <summary>
        /// Dispara el evento <see cref="SubjectModuleDataModified"/>
        /// </summary>
        private static void OnSubjectModuleDataModified()
        {
            SubjectModuleDataModified?.Invoke();
        }

        /// <summary>
        /// Dispara el evento <see cref="SubjectDataModified"/>
        /// </summary>
        private static void OnSubjectDataModified()
        {
            SubjectDataModified?.Invoke();
        }

        /// <summary>
        /// Dispara el evento <see cref="StudentDataModified"/>
        /// </summary>
        private static void OnStudentDataModified()
        {
            StudentDataModified?.Invoke();
        }

        /// <summary>
        /// Dispara el evento <see cref="PendingSubjectDataModified"/>
        /// </summary>
        private static void OnPendingSubjectDataModified()
        {
            PendingSubjectDataModified?.Invoke();
        }

        /// <summary>
        /// Dispara el evento <see cref="ScoreDataModified"/>
        /// </summary>
        private static void OnScoreDataModified()
        {
            ScoreDataModified?.Invoke();
        }
    }
}
