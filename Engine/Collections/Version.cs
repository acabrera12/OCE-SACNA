using OCESACNA.Engine.Collections.Abstract;
namespace OCESACNA.Engine.Collections
{
    public class Version2 : VersionBase
    {
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

    public class Version3 : VersionBase
    {
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

    public class Version4 : VersionBase
    {
        public int SubVersion { get; set; }
        public int Modification { get; set; }
        public int Iteration { get; set; }

        public override string GetAsText()
        {
            return ConstructVer(Version, SubVersion, Modification, Iteration);
        }

        public Version4(int version, int subversion, int modification, int iteration)
        {
            this.Version = version;
            this.SubVersion = subversion;
            this.Modification = modification;
            this.Iteration = iteration;
        }
    }
}