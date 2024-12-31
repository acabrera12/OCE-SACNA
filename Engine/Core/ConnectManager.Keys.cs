namespace OCESACNA.Engine.Core
{
    public static partial class ConnectManager
    {
        private static readonly string[] UserKeys = { "UserID", "UserName", "Password", "Rank", "State" };
        private static readonly string[] CourseKey = { "CourseID", "Year", "Mention", "Section" };
        private static readonly string[] RepresentativeKeys = { "RprsentID", "FullName", "PhoneNumber", "Email" };
        private static readonly string[] TeacherKeys = { "TeachID", "FullName", CourseKey[0] };
        private static readonly string[] SbjetModuleKeys = { "SbjetModuleID", "Name" };
        private static readonly string[] SubjectKeys = { "SubjectID", SbjetModuleKeys[0], "Name", TeacherKeys[0], CourseKey[0] };
        private static readonly string[] Studentkeys = {
            "StudentID", "Cedula", "LastNames", "FirstNames", "Age",
            "Sex", "Birthdate", "BirthPlace", "FederalEntty", "Address",
            "PhoneNumber", "Email", RepresentativeKeys[0], CourseKey[0]
        };
        private static readonly string[] ScoreKey = {
            "ScoreID", Studentkeys[0],  SubjectKeys[0], "First", "FirstDef",
            "FirstInas", "Second", "SecondDef", "SecondInas", "Third", "ThirdDef",
            "ThirdInas", "Final", "FinalDef", "FinalInas"
        };
    }
}
