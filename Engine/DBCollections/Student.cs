using System;
namespace OCESACNA.Engine.DBCollections
{
    public class DBStudent
    {
        public int StudentID { get; set; }
	    public int Cedula { get; set; }
	    public string LastNames { get; set; }
    	public string FirstNames { get; set; }
    	public int Age { get; set; }
    	public bool Sex { get; set; }
    	public DateTime Birthdate { get; set; }
    	public string BirthPlace { get; set; }
    	public string FederalEntty { get; set; }
    	public string Address { get; set; }
    	public string PhoneNumber { get; set; }
    	public string Email { get; set; }
	    public int RprsentID { get; set; }
    	public int CourseID { get; set; }

        public DBStudent(int id = -1, int cedula = -1, string lastnames = "", string firstnames = "", int age = -1, bool sex = false, string birthdate = "", string birthplace = "", string federalentty = "", string address = "", string phonenumber = "", string email = "", int rprsentid = -1, int courseid = -1)
        {
            this.StudentID = id;
            this.Cedula = cedula;
            this.LastNames = lastnames;
            this.FirstNames = firstnames;
            this.Age = age;
            this.Sex = sex;
            this.Birthdate = DateTime.Parse(birthdate);
            this.BirthPlace = birthplace;
            this.FederalEntty = federalentty;
            this.Address = address;
            this.PhoneNumber = phonenumber;
            this.Email = email;
            this.RprsentID = rprsentid;
            this.CourseID = courseid;
        }
    }
}