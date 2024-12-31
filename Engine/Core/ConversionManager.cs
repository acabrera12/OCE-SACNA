using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCESACNA.Engine.DBCollections;
using OCESACNA.Engine.Collections;

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
    }
}
