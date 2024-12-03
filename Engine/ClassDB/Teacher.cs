using Engine.ClassDB.Asbtract;

namespace Engine.ClassDB;

public class Teacher : Entity
{
    public string Name { get; set; }

    public Teacher(int ID = -1, string name = "")
    {
        this.ID = ID;
        this.Name = name;
    }
}
