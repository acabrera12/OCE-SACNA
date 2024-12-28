using MySql.Data.MySqlClient;
using OCESACNA.Engine.Collections;
using OCESACNA.Engine.DBCollections;
using System;
using System.Collections.Generic;

namespace OCESACNA.Engine.Core
{
    public static partial class ConnectManager
    {
        private static Connection DBConnection;
        private static readonly List<Request> RequestQueue = new List<Request>();
        private static bool isRequesting = false;

        internal static void Init(string server)
        {
            DBConnection = new Connection(server);

            if (DBConnection.GetConnection() == null)
            {
                throw new Exception("DBConnection Failed");
            }

            UpdateManager.Updated.Connect(Update);
        }

        private static MySqlDataReader Query(string query)
        {
            MySqlCommand MySQLCommand = new MySqlCommand(query)
            {
                Connection = DBConnection.GetConnection()
            };
            MySqlDataReader DataReader = MySQLCommand.ExecuteReader();
            return DataReader;
        }


        private static void Update(object Sender, EventArgs Args)
        {
            if (isRequesting || RequestQueue.Count == 0)
            {
                return;
            }

            Request r = RequestQueue[0];
            RequestQueue.RemoveAt(0);

            isRequesting = true;
            SendRequest(r);
        }

        private static void SendRequest(Request request)
        {
            MySqlDataReader Data = Query(request.query);

            List<Dictionary<string, dynamic>> list = new List<Dictionary<string, dynamic>>();

            while (Data.Read())
            {
                Dictionary<string, dynamic> current = new Dictionary<string, dynamic>();

                foreach (string key in request.keys)
                {
                    current.Add(key, Data[key]);
                }

                list.Add(current);
            }

            request.Complete(new RequestEventArgs(list));
            isRequesting = false;
        }

        public static void RunCustom(string query, string[] keys)
        {
            Request r = new Request(query, keys);
            RequestQueue.Add(r);
        }

        public static void RunCustom(string query, string[] keys, Request.CompleEventHandle callback)
        {
            Request r = new Request(query, keys);
            r.Connect(callback);
            RequestQueue.Add(r);
        }

        #region user commands
        public static void GetAllUsers(Request.CompleEventHandle callback)
        {
            Request r = new Request("SELECT * FROM users", UserKeys);
            r.Connect(callback);
            RequestQueue.Add(r);
        }

        public static void GetUserByID(int id, Request.CompleEventHandle callback)
        {
            Request r = new Request($"SELECT * FROM users WHERE UserID = {id}", UserKeys);
            r.Connect(callback);
            RequestQueue.Add(r);
        }

        public static void AddUser(DBUser user)
        {
            Request r = new Request($"INSER INTO users (UserName, Password, Rank, State) VALUES" +
                $" ({user.UserName}, {user.Password}, {user.Rank}, {user.State})", EmptyKey);
            RequestQueue.Add(r);
        }

        public static void UpdateUser(DBUser user)
        {
            Request r = new Request($"UPDATE users SET UserName ={user.UserName}, " +
                $"Password ={user.Password}, Rank ={user.Rank}, State={user.State} " +
                $"WHERE UserID = {user.UserID}", UserKeys);
            RequestQueue.Add(r);
        }

        public static void DeleteUser(int id)
        {
            Request r = new Request($"DELETE FROM users WHERE UserID ={id}", EmptyKey);
            RequestQueue.Add(r);
        }
        #endregion
        #region course commands
        public static void GetAllCourses(Request.CompleEventHandle callback)
        {
            Request r = new Request("SELECT * FROM courses", CourseKey);
            r.Connect(callback);
            RequestQueue.Add(r);
        }

        public static void GetCourseByID(int id, Request.CompleEventHandle callback)
        {
            Request r = new Request($"SELECT * FROM courses WHERE CourseID = {id}", CourseKey);
            r.Connect(callback);
            RequestQueue.Add(r);
        }

        public static void AddCourse(DBCourse course)
        {
            Request r = new Request("INSERT INTO courses (Year, Mention, Section) VALUES " +
                $"({course.Year}, {course.Mention}, {course.Section})", EmptyKey);
            RequestQueue.Add(r);
        }

        public static void UpdateCourse(DBCourse course)
        {
            Request r = new Request($"UPDATE courses SET Year ={course.Year}, Mention ={course.Mention}," +
                $" Section ={course.Section} WHEHRE CourseID ={course.CourseID}", CourseKey);
            RequestQueue.Add(r);
        }

        public static void DeleteCourse(int id)
        {
            Request r = new Request($"DELETE FROM courses WHERE CourseID ={id}", CourseKey);
            RequestQueue.Add(r);
        }
        #endregion
        #region representative commands
        public static void GetAllRepresentatives(Request.CompleEventHandle callback)
        {
            Request r = new Request("SELECT * FROM representatives", RepresentativeKeys);
            r.Connect(callback);
            RequestQueue.Add(r);
        }

        public static void GetRepresentativeByID(int id, Request.CompleEventHandle callback)
        {
            Request r = new Request($"SELECT * FROM representatives WHERE RprsentID ={id}", RepresentativeKeys);
            r.Connect(callback);
            RequestQueue.Add(r);
        }

        public static void AddRepresentative(DBRepresentative rprsent)
        {
            Request r = new Request($"INSERT INTO representatives (FullName) VALUES " +
                $"({rprsent.FullName})", EmptyKey);
            RequestQueue.Add(r);
        }

        public static void UpdateRepresentative(DBRepresentative rprsent)
        {
            Request r = new Request($"UPDATE representatives SET FullName ={rprsent.FullName} " +
                $"WHERE RprsentID ={rprsent.RprsentID}", RepresentativeKeys);
            RequestQueue.Add(r);
        }

        public static void DeleteRepresentative(int id)
        {
            Request r = new Request($"DELETE FROM representatives WHERE RprsentID ={id}", RepresentativeKeys);
            RequestQueue.Add(r);
        }
        #endregion
        #region teachers commands
        public static void GetAllTeachers(Request.CompleEventHandle callback)
        {
            Request r = new Request("SELECT * FROM teachers", TeacherKeys);
            r.Connect(callback);
            RequestQueue.Add(r);
        }

        public static void GetTeacherByID(int id, Request.CompleEventHandle callback)
        {
            Request r = new Request($"SELECT * FROM teachers WHERE TeachID ={id}", TeacherKeys);
            r.Connect(callback);
            RequestQueue.Add(r);
        }

        public static void AddTeacher(DBTeacher teacher)
        {
            Request r = new Request($"INSERT INTO teachers (FullName, CourseID) VALUES " +
                $"({teacher.FullName}, {teacher.CourseID})", EmptyKey);
            RequestQueue.Add(r);
        }

        public static void UpdateTeacher(DBTeacher teacher)
        {
            Request r = new Request($"UPDATE teachers SET FullName = {teacher.FullName}, " +
                $"CourseID ={teacher.CourseID} WHERE TeachID ={teacher.TeachID}", TeacherKeys);
            RequestQueue.Add(r);
        }

        public static void DeleteTeacher(int id)
        {
            Request r = new Request($"DELETE FROM teachers WHERE TeachID ={id}", EmptyKey);
            RequestQueue.Add(r);
        }
        #endregion
        #region SbjetModule commands
        public static void GetAllSbjetModules(Request.CompleEventHandle callback)
        {
            Request r = new Request("SELECT * FROM subjectmodules", SbjetModuleKeys);
            r.Connect(callback);
            RequestQueue.Add(r);
        }

        public static void GetSbjetModuleByID(int id, Request.CompleEventHandle callback)
        {
            Request r = new Request($"SELECT * FROM subjectmodules WHERE SbjetModuleID ={id}", SbjetModuleKeys);
            r.Connect(callback);
            RequestQueue.Add(r);
        }

        public static void AddSbjetModule(DBSubjectModule sbjetModule)
        {
            Request r = new Request($"INSERT INTO subjectmodules (Name) VALUES ({sbjetModule.Name})", EmptyKey);
            RequestQueue.Add(r);
        }

        public static void UpdateSbjetModule(DBSubjectModule sbjetModule)
        {
            Request r = new Request($"UPDATE subjectmodules SET Name ={sbjetModule.Name} " +
                $"WHERE SbjetModuleID = {sbjetModule.SbjetModuleID}", SbjetModuleKeys);
            RequestQueue.Add(r);
        }

        public static void DeleteSbjetModule(int id)
        {
            Request r = new Request($"DELETE FROM subjectmodules WHERE SbjetModuleID ={id}", EmptyKey);
            RequestQueue.Add(r);
        }
        #endregion
        #region subject commands
        public static void GetAllSubjects(Request.CompleEventHandle callback)
        {
            Request r = new Request("SELECT * FROM subjects", SubjectKeys);
            r.Connect(callback);
            RequestQueue.Add(r);
        }

        public static void GetSubjectByID(int id, Request.CompleEventHandle callback)
        {
            Request r = new Request($"SELECT * FROM subjecs WHERE SubjectID ={id}", SubjectKeys);
            r.Connect(callback);
            RequestQueue.Add(r);
        }

        public static void AddSubject(DBSubject sbjet)
        {
            Request r = new Request($"INSERT INTO subjecs (SbjetModuleID, Name, TeachID, CourseID) VALUES " +
                $"({sbjet.SbjetModuleID}, {sbjet.Name}, {sbjet.TeachID}, {sbjet.CourseID})", EmptyKey);
            RequestQueue.Add(r);
        }

        public static void UpdateSubject(DBSubject sbjet)
        {
            Request r = new Request($"UPDATE subjecs SET SbjetModuleID ={sbjet.SbjetModuleID}, " +
                $"Name ={sbjet.Name}, TeachID ={sbjet.TeachID}, CourseID={sbjet.CourseID} " +
                $"WHERE SubjectID ={sbjet.SubjectID}", SubjectKeys);
            RequestQueue.Add(r);
        }

        public static void DeleteSubject(int id)
        {
            Request r = new Request($"DELETE FROM subjects WHERE SubjectID ={id}", EmptyKey);
            RequestQueue.Add(r);
        }
        #endregion
        #region students commands
        public static void GetAllStudents(Request.CompleEventHandle callback)
        {
            Request r = new Request("SELECT * FROM students", Studentkeys);
            r.Connect(callback);
            RequestQueue.Add(r);
        }

        public static void GetStudentByID(int id, Request.CompleEventHandle callback)
        {
            Request r = new Request($"SELECT * FROM students WHERE StudentID ={id}", Studentkeys);
            r.Connect(callback);
            RequestQueue.Add(r);
        }

        public static void AddStudent(DBStudent std)
        {
            Request r = new Request("INSERT INTO students (Cedula, LastNames, FirstNames, Age, Sex, Birthdate, " +
                "BirthPlace, FederalEntty, Address, PhoneNumber, Email, RprsentID, CourseID) VALUES " +
                $"({std.Cedula}, {std.LastNames}, {std.FirstNames}, {std.Age}, {std.Sex}, {std.Birthdate}, " +
                $"{std.BirthPlace}, {std.FederalEntty}, {std.Address}, {std.PhoneNumber}, {std.Email}), " +
                $"{std.RprsentID}, {std.CourseID}", EmptyKey);
            RequestQueue.Add(r);
        }

        public static void UpdateStudent(DBStudent std)
        {
            Request r = new Request($"UPDATE students SET Cedula ={std.Cedula}, LastNames={std.LastNames}, " +
                $"FirstNames = {std.FirstNames}, Age ={std.Age}, Sex ={std.Sex}, Birthdate ={std.Birthdate}, " +
                $"BirthPlace ={std.BirthPlace}, FederalEntty ={std.FederalEntty}, Address ={std.Address}, " +
                $"PhoneNumber ={std.PhoneNumber}, Email ={std.Email}, RprsentID ={std.RprsentID}, " +
                $"CourseID ={std.CourseID} WHERE StudentID ={std.StudentID}", Studentkeys);
            RequestQueue.Add(r);
        }

        public static void DeleteStudent(int id)
        {
            Request r = new Request($"DELETE FROM students WHERE StudentID ={id}", EmptyKey);
            RequestQueue.Add(r);
        }
        #endregion
        #region score commands
        public static void GetAllScores(Request.CompleEventHandle callback)
        {
            Request r = new Request("SELECT * FROM scores", ScoreKey);
            r.Connect(callback);
            RequestQueue.Add(r);
        }

        public static void GetScoreByID(int id, Request.CompleEventHandle callback)
        {
            Request r = new Request($"SELECT * FROM scores WHERE ScoreID ={id}", ScoreKey);
            r.Connect(callback);
            RequestQueue.Add(r);
        }

        public static void GetScoresByStudentID(int id, Request.CompleEventHandle callback)
        {
            Request r = new Request($"SELECT * FROM scores WHERE StudentID ={id}", ScoreKey);
            r.Connect(callback);
            RequestQueue.Add(r);
        }


        #endregion
    }
}
