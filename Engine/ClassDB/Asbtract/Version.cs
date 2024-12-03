namespace Engine.ClassDB.Asbtract
{
    public class Version2
    {
        public int Version { get; set; }
        public int SubVersion { get; set; }

        public Version2(int version, int subversion)
        {
            this.Version = version;
            this.SubVersion = subversion;
        }

        public string GetVersionAsString()
        {
            string value = $"{this.Version}.{this.SubVersion}";
            return value;
        }
    }

    public class Version3
    {
        public int Version { get; set; }
        public int SubVersion { get; set; }
        public int Iteration { get; set; }

        public Version3(int version, int subversion, int iteration)
        {
            this.Version = version;
            this.SubVersion = subversion;
            this.Iteration = iteration;
        }

        public string GetVersionAsString()
        {
            string value = $"{this.Version}.{this.SubVersion}.{this.Iteration}";
            return value;
        }
    }
}