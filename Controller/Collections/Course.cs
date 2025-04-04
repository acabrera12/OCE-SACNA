using OCESACNA.Model;
namespace OCESACNA.Controller
{
    /// <summary>
    /// Representa un curso
    /// </summary>
    public class Course : Entity
    {
        /// <summary>
        /// Obtiene o establece el ID
        /// </summary>
        public int CourseID { get; set; }

        /// <summary>
        /// Obtiene o establece el Año
        /// </summary>
        public Years Year { get; set; }

        /// <summary>
        /// Obtiene o establece la Mención
        /// </summary>
        public string Mention { get; set; }

        /// <summary>
        /// Obtiene o establece la Sección
        /// </summary>
        public char Section { get; set; }

        /// <summary>
        /// Años
        /// </summary>
        public enum Years
        {
            Year1th = 0,
            Year2th = 1,
            Year3th = 2,
            Year4th = 3,
            Year5th = 4
        }

        /// <summary>
        /// Inicializa una instancia de la clase <see cref="Course"/>
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="year">Año</param>
        /// <param name="mention">Mencion</param>
        /// <param name="section">Sección</param>
        public Course(int id = -1, Years year = Years.Year1th, string mention = "", char section = '?')
        {
            CourseID = id;
            Year = year;
            Mention = mention;
            Section = section;
        }

        /// <summary>
        /// Obtiene el texto que representa el año proporcionado
        /// </summary>
        /// <param name="years">Año</param>
        /// <returns>una cadena que representa a <paramref name="years"/></returns>
        public static string GetYearsText(Years years)
        {
            switch (years)
            {
                case Years.Year1th:
                    return "1°er Año";
                case Years.Year2th:
                    return "2°do Año";
                case Years.Year3th:
                    return "3°er Año";
                case Years.Year4th:
                    return "4°to Año";
                case Years.Year5th:
                    return "5°to Año";
                default:
                    return "Error";
            }
        }

        /// <summary>
        /// <see cref="DBCourse"/> -> <see cref="Course"/>
        /// </summary>
        public static implicit operator Course(DBCourse DBCourse)
        {
            return new Course()
            {
                CourseID = DBCourse.CourseID,
                Year = (Years)DBCourse.Year,
                Mention = DBCourse.Mention,
                Section = DBCourse.Section
            };
        }

        /// <summary>
        /// <see cref="Course"/> -> <see cref="DBCourse"/>
        /// </summary>
        public static implicit operator DBCourse(Course Course)
        {
            return new DBCourse()
            {
                CourseID = Course.CourseID,
                Year = (int)Course.Year,
                Mention = Course.Mention,
                Section = Course.Section
            };
        }
    }
}
