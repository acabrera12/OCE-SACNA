namespace Engine.ClassDB.Asbtract
{
    public class Version
    {
        protected string ConstructVer(params int[] args)
        {
            string value = string.Empty;
            int index = 0;

            foreach (int num in args)
            {
                if (index != args.Count() - 1)
                {
                    value += $"{num}.";
                }
                else
                {
                    value += $"{num}";
                }
                index++;
            }

            return value;
        }

        public virtual string GetAsText()
        {
            return String.Empty;
        }
    }

    public class Version2 : Version
    {
        public int Version { get; set; }
        public int SubVersion { get; set; }

        public override string GetAsText()
        {
            return ConstructVer(Version, SubVersion);
        }

        public Version2(int version, int subversion)
        {
            this.Version = version;
            this.SubVersion = subversion;
        }
    }


    public class Version3 : Version
    {
        public int Version { get; set; }
        public int SubVersion { get; set; }
        public int Modification { get; set; }

        public override string GetAsText()
        {
            return ConstructVer(Version, SubVersion, Modification);
        }

        public Version3(int version, int subversion, int modification)
        {
            this.Version = version;
            this.SubVersion = subversion;
            this.Modification = modification;
        }
    }
}