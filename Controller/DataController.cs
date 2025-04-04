using MySql.Data.MySqlClient;
using OCESACNA.Model;
using System;
using System.Linq;
using System.Collections.ObjectModel;

namespace OCESACNA.Controller
{
    /// <summary>
    /// Controlador de datos
    /// </summary>
    public static partial class DataController
    {
        /// <summary>
        /// Obtiene o establece la conexión con la base de datos
        /// </summary>
        private static Connection DBConnection { get; set; }

        /// <summary>
        /// Obtiene el formato de guardado de fechas de la base de datos
        /// </summary>
        public const string DBDateFormat = "yyyy-MM-dd";

        /// <summary>
        /// Inicializa el controlador
        /// </summary>
        public static void Init(string Server, string User, string Password)
        {
            DBConnection = new Connection(Server, User, Password);

            if (DBConnection.GetConnection() == null)
            {
                throw new DBConnectionException();
            }
        }

        /// <summary>
        /// Ejecuta una consulta de MySql
        /// </summary>
        /// <param name="query">Consulta</param>
        /// <returns>Datos en forma de <see cref="MySqlDataReader"/></returns>
        private static MySqlDataReader Query(string query)
        {
            try
            {
                MySqlCommand sqlCommand = new MySqlCommand(query)
                {
                    Connection = DBConnection.GetConnection()
                };

                return sqlCommand.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.WriteLine($"{typeof(DataController)}: Exception:{e}");
                return null;
            }
        }

        #region user commands
        /// <summary>
        /// Obtiene la lista de usuarios en la base de datos
        /// </summary>
        /// <returns>Una lista en forma de <see cref="Collection{T}"/> de <see cref="DBUser"/></returns>
        /// <exception cref="NullReferenceException"></exception>
        public static Collection<DBUser> GetAllUsers()
        {
            MySqlDataReader data = Query("SELECT * FROM users") ?? throw new NullReferenceException();

            Collection<DBUser> list = new Collection<DBUser>();

            while (data.Read())
            {
                DBUser current = new DBUser()
                {
                    UserID = (int)data["UserID"],
                    UserName = (string)data["UserName"],
                    Password = (string)data["Password"],
                    PasswordHash = (string)data["PasswordHash"],
                    Rank = (int)data["Rank"],
                    State = (int)data["State"]
                };

                list.Add(current);
            }

            data.Close();

            return list;
        }

        /// <summary>
        /// Obtiene el usuario de la base de datos con el <paramref name="id"/> proporcionado
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Un usuario <see cref="DBUser"/> si existe, <see langword="null"/> si no</returns>
        /// <exception cref="NullReferenceException"></exception>
        public static DBUser GetUser(int id)
        {
            MySqlDataReader data = Query($"SELECT * FROM users WHERE `UserID` = '{id}'") ?? throw new NullReferenceException();

            DBUser? user = null;
            while (data.Read())
            {
                user = new DBUser()
                {
                    UserID = (int)data["UserID"],
                    UserName = (string)data["UserName"],
                    Password = (string)data["Password"],
                    PasswordHash = (string)data["PasswordHash"],
                    Rank = (int)data["Rank"],
                    State = (int)data["State"]
                };
            }

            data.Close();

            return (DBUser)user;
        }

        /// <summary>
        /// Añade un usuario a la base de datos
        /// </summary>
        /// <param name="user">Usuario</param>
        public static void AddUser(DBUser user)
        {
            Query("INSERT INTO users (`UserName`, `Password`, `PasswordHash`, `Rank`, `State`) VALUES " +
                $"('{user.UserName}', '{user.Password}', '{user.PasswordHash}', '{user.Rank}', '{user.State}')")
                ?.Close();
        }

        /// <summary>
        /// Actualiza el usuario de la base de datos con los datos proporcionados
        /// </summary>
        /// <param name="user">Usuario</param>
        public static void UpdateUser(DBUser user)
        {
            Query($"UPDATE users SET `UserName` = '{user.UserName}', `Password` = '{user.Password}', " +
                $"`Rank` = '{user.Rank}', `State` = '{user.State}', `PasswordHash` = '{user.PasswordHash}' " +
                $"WHERE `UserID` = '{user.UserID}'")
                ?.Close();
        }

        /// <summary>
        /// Elimina de la base de datos al usuario con el <paramref name="id"/> proporcionado
        /// </summary>
        /// <param name="id">ID</param>
        public static void DeleteUser(int id)
        {
            Query($"DELETE FROM users WHERE `UserID` = '{id}'")
                ?.Close();
        }
        #endregion

        #region course commands
        /// <summary>
        /// Obtiene la lista de cursos de la base de datos
        /// </summary>
        /// <returns>Una lista en forma de <see cref="Collection{T}"/> de <see cref="DBCourse"/></returns>
        /// <exception cref="NullReferenceException"></exception>
        public static Collection<DBCourse> GetAllCourses()
        {
            if (Cache.IsCoursesCacheUpdated)
            {
                return Cache.CourseCache;
            }

            MySqlDataReader data = Query("SELECT * FROM courses") ?? throw new NullReferenceException();

            Collection<DBCourse> list = new Collection<DBCourse>();

            while (data.Read())
            {
                DBCourse current = new DBCourse()
                {
                    CourseID = (int)data["CourseID"],
                    Year = (int)data["Year"],
                    Mention = (string)data["Mention"],
                    Section = (char)data["Section"]
                };

                list.Add(current);
            }

            data.Close();

            Cache.UpdateCoursesCache(list);

            return list;
        }

        /// <summary>
        /// Obtiene el curso de la base de datos con el <paramref name="id"/> proporcionado
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Un curso <see cref="DBCourse"/> si existe, <see langword="null"/> si no</returns>
        /// <exception cref="NullReferenceException"></exception>
        public static DBCourse GetCourse(int id)
        {
            if (Cache.IsCoursesCacheUpdated && Cache.CourseCache.Where(t => t.CourseID == id).Count() != 0)
            {
                return Cache.CourseCache.Where(t => t.CourseID == id).First();
            }

            MySqlDataReader data = Query($"SELECT * FROM courses WHERE `CourseID` = '{id}'") ?? throw new NullReferenceException();

            DBCourse? course = null;
            while (data.Read())
            {
                course = new DBCourse()
                {
                    CourseID = (int)data["CourseID"],
                    Year = (int)data["Year"],
                    Mention = (string)data["Mention"],
                    Section = (char)data["Section"]
                };
            }

            data.Close();

            Cache.CourseCache.Add((DBCourse)course);

            return (DBCourse)course;
        }

        /// <summary>
        /// Añade un curso a la base de datos
        /// </summary>
        /// <param name="course">Curso</param>
        public static void AddCourse(DBCourse course)
        {
            Query("INSERT INTO courses (`Year`, `Mention`, `Section`) VALUES " +
                $"('{course.Year}', '{course.Mention}', '{course.Section}')")
                ?.Close();
            Cache.SetCoursesCacheOutdated();
        }

        /// <summary>
        /// Actualiza el curso de la base de datos con los datos proporcionados
        /// </summary>
        /// <param name="course">Curso</param>
        public static void UpdateCourse(DBCourse course)
        {
            Query($"UPDATE courses SET `Year` = '{course.Year}', `Mention` = '{course.Mention}', " +
                $"`Section` = '{course.Section}' WHERE `CourseID` = '{course.CourseID}'")
                ?.Close();
            Cache.SetCoursesCacheOutdated();
        }

        /// <summary>
        /// Elimina de la base de datos el curso con el <paramref name="id"/> proporcionado
        /// </summary>
        /// <param name="id">Curso</param>
        public static void DeleteCourse(int id)
        {
            Query($"DELETE FROM courses WHERE `CourseID` = '{id}'")
                ?.Close();
            Cache.SetCoursesCacheOutdated();
        }
        #endregion

        #region representative commands
        /// <summary>
        /// Obtiene la lista de representates de la base de datos
        /// </summary>
        /// <returns>Una lista en forma de <see cref="Collection{T}"/> de <see cref="DBRepresentative"/></returns>
        /// <exception cref="NullReferenceException"></exception>
        public static Collection<DBRepresentative> GetAllRepresentatives()
        {
            if (Cache.IsRepresentativesCacheUpdated)
            {
                return Cache.RepresentativeCache;
            }

            MySqlDataReader data = Query("SELECT * FROM representatives") ?? throw new NullReferenceException();

            Collection<DBRepresentative> list = new Collection<DBRepresentative>();

            while (data.Read())
            {
                DBRepresentative current = new DBRepresentative()
                {
                    RprsentID = (int)data["RprsentID"],
                    FullName = (string)data["FullName"],
                    PhoneNumber = (string)data["PhoneNumber"],
                    Email = (string)data["Email"]
                };

                list.Add(current);
            }

            data.Close();

            Cache.UpdateRepresentativesCache(list);

            return list;
        }

        /// <summary>
        /// Obtiene el representante de la base de datos con el <paramref name="id"/> proporcionado
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Un representante <see cref="DBRepresentative"/> si existe, <see langword="null"/> si no</returns>
        /// <exception cref="NullReferenceException"></exception>
        public static DBRepresentative GetRepresentative(int id)
        {
            if (Cache.IsRepresentativesCacheUpdated && Cache.RepresentativeCache.Where(t => t.RprsentID == id).Count() != 0)
            {
                return Cache.RepresentativeCache.Where(t => t.RprsentID == id).First();
            }

            MySqlDataReader data = Query($"SELECT FROM representatives WHERE `RprsentID` = '{id}'") ?? throw new NullReferenceException();

            DBRepresentative? representative = null;
            while (data.Read())
            {
                representative = new DBRepresentative()
                {
                    RprsentID = (int)data["RprsentID"],
                    FullName = (string)data["FullName"],
                    PhoneNumber = (string)data["PhoneNumber"],
                    Email = (string)data["Email"]
                };
            }

            Cache.RepresentativeCache.Add((DBRepresentative)representative);

            return (DBRepresentative)representative;
        }

        /// <summary>
        /// Añade un representante a la base de datos
        /// </summary>
        /// <param name="representative">Representante</param>
        public static void AddRepresentative(DBRepresentative representative)
        {
            Query("INSERT INTO representatives (`FullName`, `PhoneNumber`, `Email`) VALUES " +
                $"('{representative.FullName}', '{representative.PhoneNumber}', " +
                $"'{representative.Email}')")
                ?.Close();
            Cache.SetRepresentativesCacheOutdated();
        }

        /// <summary>
        /// Actualiza el representante de la base de datos con los datos proporcionados
        /// </summary>
        /// <param name="representative">Representante</param>
        public static void UpdateRepresentative(DBRepresentative representative)
        {
            Query($"UPDATE FROM SET `FullName` = '{representative.FullName}', " +
                $"`PhoneNumber` = '{representative.PhoneNumber}', `Email` = '{representative.Email}' " +
                $"WHERE `RprsentID` = '{representative.RprsentID}'")
                ?.Close();
            Cache.SetRepresentativesCacheOutdated();
        }

        /// <summary>
        /// Elimina el representante de la base de datos con el <paramref name="id"/> proporcionado
        /// </summary>
        /// <param name="id">ID</param>
        public static void DeleteRepresenative(int id)
        {
            Query($"DELETE FROM WHERE `RprsentID` = '{id}'")
                ?.Close();
            Cache.SetRepresentativesCacheOutdated();
        }
        #endregion

        #region teacher commands
        /// <summary>
        /// Obtiene la lista de docentes de la base de datos
        /// </summary>
        /// <returns>Una lista en forma <see cref="Collection{T}"/> de <see cref="DBTeacher"/></returns>
        /// <exception cref="NullReferenceException"></exception>
        public static Collection<DBTeacher> GetAllTeachers()
        {
            if (Cache.IsTeachersCacheUpdated)
            {
                return Cache.TeacherCache;
            }

            MySqlDataReader data = Query("SELECT * FROM teachers") ?? throw new NullReferenceException();

            Collection<DBTeacher> list = new Collection<DBTeacher>();

            while (data.Read())
            {
                DBTeacher current = new DBTeacher()
                {
                    TeachID = (int)data["TeachID"],
                    FullName = (string)data["FullName"],
                    CourseID = (int)data["CourseID"]
                };

                list.Add(current);
            }

            data.Close();

            Cache.UpdateTeachersCache(list);

            return list;
        }

        /// <summary>
        /// Obtiene el docente de la base de datos con el <paramref name="id"/> proporcionado
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Un docente <see cref="DBTeacher"/> si existe, <see langword="null"/> si no</returns>
        /// <exception cref="NullReferenceException"></exception>
        public static DBTeacher GetTeacher(int id)
        {
            if (Cache.IsTeachersCacheUpdated && Cache.TeacherCache.Where(t => t.TeachID == id).Count() != 0)
            {
                return Cache.TeacherCache.Where(t => t.TeachID == id).First();
            }

            MySqlDataReader data = Query($"SELECT * FROM teachers WHERE `TeachID` = '{id}'") ?? throw new NullReferenceException();

            DBTeacher? teacher = null;
            while (data.Read())
            {
                teacher = new DBTeacher()
                {
                    TeachID = (int)data["TeachID"],
                    FullName = (string)data["FullName"],
                    CourseID = (int)data["CourseID"]
                };
            }

            Cache.TeacherCache.Add((DBTeacher)teacher);

            return (DBTeacher)teacher;
        }

        /// <summary>
        /// Añade un docente a la base de datos
        /// </summary>
        /// <param name="teacher">Docente</param>
        public static void AddTeacher(DBTeacher teacher)
        {
            Query("INSERT INTO teachers (`FullName`, `CourseID`) VALUES " +
                $"('{teacher.FullName}', '{teacher.CourseID}')")
                ?.Close();
            Cache.SetTeachersCacheOutdated();
        }

        /// <summary>
        /// Actualiza un docente de la base de datos con los datos proporcionados
        /// </summary>
        /// <param name="teacher">Docente</param>
        public static void UpdateTeacher(DBTeacher teacher)
        {
            Query($"UPDATE FROM teachers SET `FullName` = '{teacher.FullName}', `CourseID` = '{teacher.CourseID}' " +
                $"WHERE `TeachID` = '{teacher.TeachID}'")
                ?.Close();
            Cache.SetTeachersCacheOutdated();
        }

        /// <summary>
        /// Elimina el docente de la base de datos con el <paramref name="id"/> proporcionado
        /// </summary>
        /// <param name="id">ID</param>
        public static void DeleteTeacher(int id)
        {
            Query($"DELETE FROM teachers WHERE `TeachID` = '{id}'")
                ?.Close();
            Cache.SetTeachersCacheOutdated();
        }
        #endregion

        #region subject module commands
        /// <summary>
        /// Obtiene la lista de áreas de formación de la base de datos
        /// </summary>
        /// <returns>Una lista en forma de <see cref="Collection{T}"/> de <see cref="DBSubjectModule"/></returns>
        /// <exception cref="NullReferenceException"></exception>
        public static Collection<DBSubjectModule> GetAllSubjectModules()
        {
            if (Cache.IsSubjectModulesCacheUpdated)
            {
                return Cache.SubjectModulesCache;
            }

            MySqlDataReader data = Query("SELECT * FROM subject_modules") ?? throw new NullReferenceException();

            Collection<DBSubjectModule> list = new Collection<DBSubjectModule>();

            while (data.Read())
            {
                DBSubjectModule current = new DBSubjectModule()
                {
                    SbjetModuleID = (int)data["SbjetModuleID"],
                    Name = (string)data["Name"]
                };

                list.Add(current);
            }

            data.Close();

            Cache.UpdateSubjectModulesCache(list);

            return list;
        }

        /// <summary>
        /// Obtiene el área de formación con el <paramref name="id"/> proporcionado
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Un área de formación <see cref="DBSubjectModule"/> si existe, <see langword="null"/> si no</returns>
        /// <exception cref="NullReferenceException"></exception>
        public static DBSubjectModule GetSubjectModule(int id)
        {
            if (Cache.IsSubjectModulesCacheUpdated && Cache.SubjectModulesCache.Where(t => t.SbjetModuleID == id).Count() != 0 )
            {
                return Cache.SubjectModulesCache.Where(t => t.SbjetModuleID == id).First();
            }

            MySqlDataReader data = Query($"SELECT * FROM subject_modules WHERE `SbjetModuleID` = '{id}'") ?? throw new NullReferenceException();

            DBSubjectModule? subjectModule = null;
            while (data.Read())
            {
                subjectModule = new DBSubjectModule()
                {
                    SbjetModuleID = (int)data["SbjetModuleID"],
                    Name = (string)data["Name"]
                };
            }

            data.Close();

            Cache.SubjectModulesCache.Add((DBSubjectModule)subjectModule);

            return (DBSubjectModule)subjectModule;
        }

        /// <summary>
        /// Añade el área de formación a la base de datos
        /// </summary>
        /// <param name="subjectModule">Área de formación</param>
        public static void AddSubjectModule(DBSubjectModule subjectModule)
        {
            Query($"INSERT INTO subject_module (`Name`) VALUES ('{subjectModule.Name}')")
                ?.Close();
            Cache.SetSubjectModulesCacheOutdated();
        }

        /// <summary>
        /// Actualiza el área de formación con los datos proporcionados
        /// </summary>
        /// <param name="subjectModule"></param>
        public static void UpdateSubjectModule(DBSubjectModule subjectModule)
        {
            Query($"UPDATE FROM subject_module SET `Name` = '{subjectModule.Name}' " +
                $"WHERE `SbjetModuleID` = '{subjectModule.SbjetModuleID}'")
                ?.Close();
            Cache.SetSubjectModulesCacheOutdated();
        }

        /// <summary>
        /// Elimina de la base de datos el área de formación con el <paramref name="id"/> proporcionado
        /// </summary>
        /// <param name="id">ID</param>
        public static void DeleteSubjectModule(int id)
        {
            Query($"DELETE FROM subject_module WHERE `SbjetModuleID` = '{id}'")
                ?.Close();
            Cache.SetSubjectModulesCacheOutdated();
        }
        #endregion

        #region subject commands
        /// <summary>
        /// Obtiene la lista de asignaturas de la base de datos
        /// </summary>
        /// <returns>Una lista en forma <see cref="Collection{T}"/> de <see cref="DBSubject"/></returns>
        /// <exception cref="NullReferenceException"></exception>
        public static Collection<DBSubject> GetAllSubjects()
        {
            if (Cache.IsSubjectsCacheUpdated)
            {
                return Cache.SubjectCache;
            }

            MySqlDataReader data = Query("SELECT * FROM subjects") ?? throw new NullReferenceException();

            Collection<DBSubject> list = new Collection<DBSubject>();

            while (data.Read())
            {
                DBSubject current = new DBSubject()
                {
                    SubjetID = (int)data["SubjetID"],
                    SbjetModuleID = (int)data["SbjetModuleID"],
                    Name = (string)data["Name"],
                    TeachID = (int)data["TeachID"],
                    CourseID = (int)data["CourseID"]
                };

                list.Add(current);
            }

            data.Close();

            Cache.UpdateSubjectsCache(list);

            return list;
        }

        /// <summary>
        /// Obtiene la asignatura de la base de datos con el <paramref name="id"/> proporcionado
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Una asignatura <see cref="DBSubject"/> si existe, <see langword="null"/> si no</returns>
        /// <exception cref="NullReferenceException"></exception>
        public static DBSubject GetSubject(int id)
        {
            if (Cache.IsSubjectsCacheUpdated && Cache.SubjectCache.Where(t => t.SubjetID == id).Count() != 0)
            {
                return Cache.SubjectCache.Where(t => t.SubjetID == id).First();
            }

            MySqlDataReader data = Query($"SELECT * FROM subjects WHERE `SubjetID` = '{id}'") ?? throw new NullReferenceException();

            DBSubject? subject = null;
            while (data.Read())
            {
                subject = new DBSubject()
                {
                    SubjetID = (int)data["SubjetID"],
                    SbjetModuleID = (int)data["SbjetModuleID"],
                    Name = (string)data["Name"],
                    TeachID = (int)data["TeachID"],
                    CourseID = (int)data["CourseID"]
                };
            }

            Cache.SubjectCache.Add((DBSubject)subject);

            return (DBSubject)subject;
        }

        /// <summary>
        /// Añade una asignatura a la base de datos
        /// </summary>
        /// <param name="subject">Asignatura</param>
        public static void AddSubject(DBSubject subject)
        {
            Query("INSERT INTO subjects (`SbjetModuleID`, `Name`, `TeachID`, `CourseID`) VALUES " +
                $"('{subject.SbjetModuleID}', '{subject.Name}', '{subject.TeachID}', " +
                $"'{subject.CourseID}')")
                ?.Close();
            Cache.SetSubjectsCacheOutdated();
        }

        /// <summary>
        /// Actualiza la asignatura de la base de datos con los datos proporcionados
        /// </summary>
        /// <param name="subject">Asignatura</param>
        public static void UpdateSubject(DBSubject subject)
        {
            Query($"UPDATE FROM subjects SET `SbjetModuleID` = '{subject.SbjetModuleID}', " +
                $"`Name` = '{subject.Name}', `TeachID` = '{subject.TeachID}', " +
                $"`CourseID` = '{subject.CourseID}' WHERE `SubjetID` = '{subject.SubjetID}'")
                ?.Close();
            Cache.SetSubjectsCacheOutdated();
        }

        /// <summary>
        /// Elimina la asignatura de la base de datos con el <paramref name="id"/> proporcionado
        /// </summary>
        /// <param name="id"><ID/param>
        public static void DeleteSubject(int id)
        {
            Query($"DELETE FROM subjects WHERE `SubjetID` = '{id}'")
                ?.Close();
            Cache.SetSubjectsCacheOutdated();
        }
        #endregion

        #region student commands
        /// <summary>
        /// Obtiene la lista de estudiantes de la base de datos
        /// </summary>
        /// <returns>Una lista en forma <see cref="Collection{T}"/> de <see cref="DBStudent"/></returns>
        /// <exception cref="NullReferenceException"></exception>
        public static Collection<DBStudent> GetAllStudents()
        {
            if (Cache.IsStudentCacheUpdated)
            {
                return Cache.StudentCache;
            }

            MySqlDataReader data = Query("SELECT * FROM students") ?? throw new NullReferenceException();

            Collection<DBStudent> list = new Collection<DBStudent>();

            while (data.Read())
            {
                DBStudent current = new DBStudent()
                {
                    StudentID = (int)data["StudentID"],
                    Cedula = (int)data["Cedula"],
                    LastNames = (string)data["LastNames"],
                    FirstNames = (string)data["FirstNames"],
                    Age = (int)data["Age"],
                    Sex = (int)data["Sex"],
                    Birthdate = (DateTime)data["Birthdate"],
                    BirthPlace = (string)data["BirthPlace"],
                    FederalEntty = (string)data["FederalEntty"],
                    Address = (string)data["Address"],
                    PhoneNumber = (string)data["PhoneNumber"],
                    Email = (string)data["Email"],
                    RprsentID = (int)data["RprsentID"],
                    CourseID = (int)data["CourseID"]
                };

                list.Add(current);
            }

            data.Close();

            Cache.UpdateStudentsCache(list);

            return list;
        }

        /// <summary>
        /// Obtiene el estudiante de la base de datos con el <paramref name="id"/> proporcionado
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Un estudiante <see cref="DBStudent"/> si existe, <see langword="null"/> si no</returns>
        /// <exception cref="NullReferenceException"></exception>
        public static DBStudent GetStudent(int id)
        {
            if (Cache.IsStudentCacheUpdated && Cache.StudentCache.Where(t => t.StudentID == id).Count() != 0)
            {
                return Cache.StudentCache.Where(t => t.StudentID == id).First();
            }

            MySqlDataReader data = Query($"SELECT * FROM students WHERE `StudentID` = '{id}'") ?? throw new NullReferenceException();
            
            DBStudent? student = null;
            while (data.Read())
            {
                student = new DBStudent()
                {
                    StudentID = (int)data["StudentID"],
                    Cedula = (int)data["Cedula"],
                    LastNames = (string)data["LastNames"],
                    FirstNames = (string)data["FirstNames"],
                    Age = (int)data["Age"],
                    Sex = (int)data["Sex"],
                    Birthdate = (DateTime)data["Birthdate"],
                    BirthPlace = (string)data["BirthPlace"],
                    FederalEntty = (string)data["FederalEntty"],
                    Address = (string)data["Address"],
                    PhoneNumber = (string)data["PhoneNumber"],
                    Email = (string)data["Email"],
                    RprsentID = (int)data["RprsentID"],
                    CourseID = (int)data["CourseID"]
                };
            }

            data.Close();

            Cache.StudentCache.Add((DBStudent)student);

            return (DBStudent)student;
        }

        /// <summary>
        /// Añade un estudiante a la base de datos
        /// </summary>
        /// <param name="student">Estudiante</param>
        public static void AddStudent(DBStudent student)
        {
            Query("INSERT INTO students (`Cedula`, `LastNames`, `FirstNames`, " +
                "`Age`, `Sex`, `Birthdate`, `BirthPlace`, `FederalEntty`, `Address`, " +
                "`PhoneNumber`, `Email`, `RprsentID`, `CourseID`) VALUES " +
                $"('{student.Cedula}', '{student.LastNames}', '{student.FirstNames}', " +
                $"'{student.Age}', '{student.Sex}', '{student.Birthdate.Date.ToString(DBDateFormat)}', '{student.BirthPlace}', " +
                $"'{student.FederalEntty}', '{student.Address}', '{student.PhoneNumber}', " +
                $"'{student.Email}', '{student.RprsentID}', '{student.CourseID}')")
                ?.Close();
            Cache.SetStudentsCacheOutdated();
        }

        /// <summary>
        /// Actualiza el estudiante de la base de datos con los datos proporcionados
        /// </summary>
        /// <param name="student">Estudiante</param>
        public static void UpdateStudent(DBStudent student)
        {
            Query($"UPDATE students SET `Cedula` ='{student.Cedula}', `LastNames` ='{student.LastNames}', " +
                $"`FirstNames` ='{student.FirstNames}', `Age` ='{student.Age}', " +
                $"`Sex` ='{student.Sex}', `Birthdate` ='{student.Birthdate.Date.ToString(DBDateFormat)}', " +
                $"`BirthPlace` ='{student.BirthPlace}', `FederalEntty` ='{student.FederalEntty}', " +
                $"`Address` ='{student.Address}', `PhoneNumber` ='{student.PhoneNumber}', " +
                $"`Email` ='{student.Email}', `RprsentID` ='{student.RprsentID}', " +
                $"`CourseID` ='{student.CourseID}' WHERE `StudentID` ='{student.StudentID}'")
                ?.Close();
            Cache.SetStudentsCacheOutdated();
        }

        /// <summary>
        /// Elimina de la base de datos el estudiante con el <paramref name="id"/> proporcionado
        /// </summary>
        /// <param name="id"></param>
        public static void DeleteStudent(int id)
        {
            Query($"DELETE FROM students WHERE `StudentID` = '{id}'")
                ?.Close();
            Cache.SetStudentsCacheOutdated();
        }
        #endregion

        #region score commands
        public static void GetAllScores()
        {
            throw new NotImplementedException();
        }

        public static void GetAllScoresByStudent()
        {
            throw new NotImplementedException();
        }

        public static void GetAllScoresBySubject()
        {
            throw new NotImplementedException();
        }

        public static void GetScore()
        {
            throw new NotImplementedException();
        }

        public static void AddScore()
        {
            throw new NotImplementedException();
        }

        public static void UpdateScore()
        {
            throw new NotImplementedException();
        }

        public static void DeleteScore()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
