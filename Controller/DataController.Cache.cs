using OCESACNA.Model;
using System.Collections.ObjectModel;

namespace OCESACNA.Controller
{
    public static partial class DataController
    {
        /// <summary>
        /// Almacena datos en memoria para una respuesta más rápida
        /// </summary>
        public static class Cache
        {
            internal static void Initialize()
            {
                CourseCache = new Collection<DBCourse>();
                RepresentativeCache = new Collection<DBRepresentative>();
                TeacherCache = new Collection<DBTeacher>();
                SubjectModulesCache = new Collection<DBSubjectModule>();
                SubjectCache = new Collection<DBSubject>();
                StudentCache = new Collection<DBStudent>();
                PendingSubjectCache = new Collection<DBPendingSubject>();
            }

            #region Course Cache
            /// <summary>
            /// Obtiene o establece la lista de cursos en cache
            /// </summary>
            public static Collection<DBCourse> CourseCache { get; internal set; }

            /// <summary>
            /// Determina si los datos en cache de los cursos están actualizados
            /// </summary>
            public static bool IsCoursesCacheUpdated
            {
                get
                {
                    return CourseCacheUpdated;
                }
            }

            /// <summary>
            /// Obtiene o establece el estado de acutlización del cache de los cursos
            /// </summary>
            private static bool CourseCacheUpdated { get; set; }

            /// <summary>
            /// Actualiza el cache de los cursos con los datos proporcionados
            /// </summary>
            /// <param name="courses">Lista de cursos</param>
            internal static void UpdateCoursesCache(Collection<DBCourse> courses)
            {
                CourseCache = courses;
                CourseCacheUpdated = true;
            }

            /// <summary>
            /// Establece el estado del cache de los cursos como desactualizado
            /// </summary>
            internal static void SetCoursesCacheOutdated() => CourseCacheUpdated = false;
            #endregion

            #region Representative Cache
            /// <summary>
            /// Obtiene o establece la lista de representantes en cache
            /// </summary>
            public static Collection<DBRepresentative> RepresentativeCache { get; internal set; }

            /// <summary>
            /// Determina si los datos en cache de los representantes están actualizados
            /// </summary>
            public static bool IsRepresentativesCacheUpdated
            {
                get
                {
                    return RepresentativeCacheUpdated;
                }
            }

            /// <summary>
            /// Obtiene o establece el estado de actualización del cache de los representantes
            /// </summary>
            private static bool RepresentativeCacheUpdated { get; set; }

            /// <summary>
            /// Actualiza el cache de los representantes con los datos proporcionados
            /// </summary>
            /// <param name="representatives">Lista de representantes</param>
            internal static void UpdateRepresentativesCache(Collection<DBRepresentative> representatives)
            {
                RepresentativeCache = representatives;
                RepresentativeCacheUpdated = true;
            }

            /// <summary>
            /// Establece el estado del cache de los representantes como desactualizado
            /// </summary>
            internal static void SetRepresentativesCacheOutdated() => RepresentativeCacheUpdated = false;
            #endregion

            #region Teacher Cache
            /// <summary>
            /// Obtiene o establece la lista de docentes en cache
            /// </summary>
            public static Collection<DBTeacher> TeacherCache { get; internal set; }

            /// <summary>
            /// Determina si los datos en cache de los docentes están actualizados
            /// </summary>
            public static bool IsTeachersCacheUpdated
            {
                get
                {
                    return TeacherCacheUpdated;
                }
            }

            /// <summary>
            /// Obtiene o establece el estado de actualización del cache de los docentes
            /// </summary>
            private static bool TeacherCacheUpdated { get; set; }

            /// <summary>
            /// Actualiza el cache de los docentes con los datos proporcionados
            /// </summary>
            /// <param name="teachers">Lista de docentes</param>
            internal static void UpdateTeachersCache(Collection<DBTeacher> teachers)
            {
                TeacherCache = teachers;
                TeacherCacheUpdated = true;
            }

            /// <summary>
            /// Establece el estado del cache de los docentes como desactualizado
            /// </summary>
            internal static void SetTeachersCacheOutdated() => TeacherCacheUpdated = false;
            #endregion

            #region Subject Modules Cache
            /// <summary>
            /// Obtiene o establece la lista de áreas de formación en cache
            /// </summary>
            public static Collection<DBSubjectModule> SubjectModulesCache { get; internal set; }

            /// <summary>
            /// Determina si los datos en cache de las áreas de formación están actualizados
            /// </summary>
            public static bool IsSubjectModulesCacheUpdated
            {
                get
                {
                    return SubjectModulesCacheUpdated;
                }
            }

            /// <summary>
            /// Obtiene o establece el estado de actualización del cache de las áreas de formación
            /// </summary>
            private static bool SubjectModulesCacheUpdated { get; set; }

            /// <summary>
            /// Actualiza el cache de las áreas de formación con los datos proporcionados
            /// </summary>
            /// <param name="subjectModules"></param>
            internal static void UpdateSubjectModulesCache(Collection<DBSubjectModule> subjectModules)
            {
                SubjectModulesCache = subjectModules;
                SubjectModulesCacheUpdated = true;
            }

            /// <summary>
            /// Establece el estado del cache de las áreas de formación como desactualizado
            /// </summary>
            internal static void SetSubjectModulesCacheOutdated() => SubjectModulesCacheUpdated = false;
            #endregion

            #region Subject Cache
            /// <summary>
            /// Obtiene o establece la lista de asignaturas en cache
            /// </summary>
            public static Collection<DBSubject> SubjectCache { get; internal set; }

            /// <summary>
            /// Determina si los datos en cache de las asignaturas están actualizados
            /// </summary>
            public static bool IsSubjectsCacheUpdated
            {
                get
                {
                    return SubjectsCacheUpdated;
                }
            }

            /// <summary>
            /// Obtiene o establece el estado de actualización del cache de las asignaturas
            /// </summary>
            private static bool SubjectsCacheUpdated { get; set; }

            /// <summary>
            /// Actualiza el cache de las asignaturas con los datos proporcionados
            /// </summary>
            /// <param name="subjects"></param>
            internal static void UpdateSubjectsCache(Collection<DBSubject> subjects)
            {
                SubjectCache = subjects;
                SubjectsCacheUpdated = true;
            }

            /// <summary>
            /// Establece el estado del cache de las asignaturas como desactualizado
            /// </summary>
            internal static void SetSubjectsCacheOutdated() => SubjectsCacheUpdated = false;
            #endregion

            #region Student Cache
            /// <summary>
            /// Obtiene o establece la lista de estudiantes en cache
            /// </summary>
            public static Collection<DBStudent> StudentCache { get; internal set; }

            /// <summary>
            /// Determina si los datos en cache de los estudiantes están actualizados
            /// </summary>
            public static bool IsStudentCacheUpdated
            {
                get
                {
                    return StudentsCacheUpdated;
                }
            }

            /// <summary>
            /// Obtiene o establece el estado de actualización del cache de los estudiantes
            /// </summary>
            private static bool StudentsCacheUpdated { get; set; }

            /// <summary>
            /// Actualiza el cache de los estudiantes con los datos proporcionados
            /// </summary>
            /// <param name="students"></param>
            internal static void UpdateStudentsCache(Collection<DBStudent> students)
            {
                StudentCache = students;
                StudentsCacheUpdated = true;
            }

            /// <summary>
            /// Establece el estado del cache de los estudiantes como desactualizado
            /// </summary>
            internal static void SetStudentsCacheOutdated() => StudentsCacheUpdated = false;
            #endregion

            #region Pending Subjects Cache
            /// <summary>
            /// Obtiene o establece la lista de asignaturas pendientes en cache
            /// </summary>
            public static Collection<DBPendingSubject> PendingSubjectCache { get; set; }

            /// <summary>
            /// Determina si los datos en cache de las asignaturas pendientes están actualizados
            /// </summary>
            public static bool IsPendingSubjectCacheUpdated
            {
                get
                {
                    return PendingSubjectUpdated;
                }
            }

            /// <summary>
            /// Obtiene o establece el estado de actualización del cache de los estudiantes
            /// </summary>
            private static bool PendingSubjectUpdated { get; set; }

            /// <summary>
            /// Actualiza el cache de las asignaturas pendientes con los datos proporcionados
            /// </summary>
            /// <param name="pendingSubjects"></param>
            internal static void UpdatePendingSubjectsCache(Collection<DBPendingSubject> pendingSubjects)
            {
                PendingSubjectCache = pendingSubjects;
                PendingSubjectUpdated = true;
            }

            /// <summary>
            /// Establece el estado del cache de las asignaturas pendientes como desactualizado
            /// </summary>
            internal static void SetPendingSubjectsCacheOutdated() => PendingSubjectUpdated = false;
            #endregion
        }
    }
}
