using OCESACNA.Engine.Collections;
using OCESACNA.Engine.DBCollections;
using System;
using System.Collections.Generic;

namespace OCESACNA.Engine.Core
{
    public static class ConversionManager
    {
        public static User DictionaryToUser(Dictionary<string, dynamic> input)
        {
            User user = new User()
            {
                UserID = input["UserID"],
                UserName = input["UserName"],
                Password = input["Password"],
                Rank = (User.RANKING)input["Rank"],
                State = (User.STATES)input["State"]
            };

            return user;
        }

        public static Course DictionaryToCourse(Dictionary<string, dynamic> input)
        {
            Course course = new Course()
            {
                CourseID = input["CourseID"],
                Year = input["Year"],
                Mention = input["Mention"],
                Section = input["Section"]
            };

            return course;
        }

        public static Representative DictionaryToRprsentative(Dictionary<string, dynamic> input)
        {
            Representative representative = new Representative()
            {
                RprsentID = input["RprsentID"],
                FullName = input["FullName"],
                PhoneNumber = input["PhoneNumber"],
                Email = input["Email"]
            };

            return representative;
        }

        public static Teacher DictionaryToTeacher(Dictionary<string, dynamic> input)
        {
            Teacher teacher = new Teacher()
            {
                TeachID = input["TeachID"],
                FullName = input["FullName"],
                Course = input["Course"]
            };

            return teacher;
        }

        public static SubjectModule DictionaryToSbjetModule(Dictionary<string, dynamic> input)
        {
            SubjectModule subjectModule = new SubjectModule()
            {
                SbjetModuleID = input["SbjetModuleID"],
                Name = input["Name"]
            };

            return subjectModule;
        }

        public static Subject DictionaryToSubject(Dictionary<string, dynamic> input)
        {
            Subject subject = new Subject()
            {
                SubjectID = input["SubjectID"],
                SbjetModule = input["SbjetModule"],
                Name = input["Name"],
                Teach = input["Teach"],
                Course = input["Course"]
            };

            return subject;
        }

        public static Student DictonaryToStudent(Dictionary<string, dynamic> input)
        {
            Student student = new Student()
            {
                StudentID = input["StudentID"],
                Cedula = input["Cedula"],
                LastNames = input["LastNames"],
                FirstNames = input["FirstNames"],
                Age = input["Age"],
                Sex = input["Sex"],
                Birthdate = input["Birthdate"],
                BirthPlace = input["BirthPlace"],
                FederalEntty = input["FederalEntty"],
                Address = input["Address"],
                PhoneNumber = input["PhoneNumber"],
                Email = input["Email"],
                Rprsent = input["Rprsent"],
                Course = input["Course"]
            };

            return student;
        }

        public static Score DictionaryToScore(Dictionary<string, dynamic> input)
        {
            Score score = new Score()
            {
                ScoreID = input["ScoreID"],
                Student = input["student"],
                Subject = input["Subject"],
                First = input["First"],
                Second = input["Second"],
                Third = input["Third"],
                Final = input["Final"],
            };

            return score;
        }

        // entity to db entity

        public static DBUser UserToDBUser(User user)
        {
            DBUser DBUser = new DBUser()
            {
                UserID = user.UserID,
                UserName = user.UserName,
                Password = user.Password,
                Rank = Convert.ToInt32(user.Rank),
                State = Convert.ToInt32(user.State)
            };

            return DBUser;
        }

        public static DBCourse CourseToDBCourse(Course course)
        {
            DBCourse DBCourse = new DBCourse()
            {
                CourseID = course.CourseID,
                Year = course.Year,
                Mention = course.Mention,
                Section = char.Parse(course.Section)
            };

            return DBCourse;
        }

        public static DBRepresentative RprsentativeToDBRprsentative(Representative rpsent)
        {
            DBRepresentative DBRepresentative = new DBRepresentative()
            {
                RprsentID = rpsent.RprsentID,
                FullName = rpsent.FullName,
                PhoneNumber = rpsent.PhoneNumber,
                Email = rpsent.Email
            };

            return DBRepresentative;
        }

        public static DBTeacher TeacherToDBTeacher(Teacher teacher)
        {
            DBTeacher DBTeacher = new DBTeacher()
            {
                TeachID = teacher.TeachID,
                FullName = teacher.FullName,
                CourseID = teacher.Course.CourseID
            };

            return DBTeacher;
        }

        public static DBSubjectModule SubjectModuleToDBSubjectModule(SubjectModule subjectModule)
        {
            DBSubjectModule DBSubjectModule = new DBSubjectModule()
            {
                SbjetModuleID = subjectModule.SbjetModuleID,
                Name = subjectModule.Name
            };

            return DBSubjectModule;
        }

        public static DBSubject SubjectToDBSubject(Subject subject)
        {
            DBSubject DBSubject = new DBSubject()
            {
                SubjectID = subject.SubjectID,
                SbjetModuleID = subject.SbjetModule.SbjetModuleID,
                Name = subject.Name,
                TeachID = subject.Teach.TeachID,
                CourseID = subject.Course.CourseID
            };

            return DBSubject;
        }
    }
}
