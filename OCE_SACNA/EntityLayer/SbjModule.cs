namespace EntityLayer
{
    public class SbjModule : Entity
    {
        public string Name { get; set; }

        public SbjModule(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
    }
}
