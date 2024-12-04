namespace Engine.ClassDB.Asbtract
{
    internal class VersionBase
    {
        private string ConstructVersion(params int[] args)
        {
            string value = String.Empty;
            int index = 0;

            foreach (int arg in args)
            {
                if (index != args.Count() - 1)
                {
                    value += $"{arg}.";
                } else {
                    value += $"{arg}";
                }
            }

            return value;
        }
    }

    public class Version2 : VersionBase
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
            return ConstructVersion(this.Version, this.SubVersion);
        }
    }

    public class Version3 : VersionBase
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
            return ConstructVersion(this.Version, this.SubVersion, this.Iteration);
        }
    }
}