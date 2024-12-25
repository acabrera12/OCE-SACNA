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

        public bool IsUpperThan(Version2 version)
        {
            if (version.Version > Version)
            {
                return true;
            }
            else if (version.SubVersion > SubVersion)
            {
                return true;
            }
            return false;
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
        public bool IsUpperThan(Version3 version)
        {
            if (version.Version > Version)
            {
                return true;
            }
            else if (version.SubVersion > SubVersion)
            {
                return true;
            }
            else if (version.Modification > Modification)
            {
                return true;
            }
            return false;
        }
    }
}