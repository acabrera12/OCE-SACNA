namespace OCESACNA.Engine.Collections.Abstract
{
    public abstract class VersionBase
    {
        public int Version { get; set; }

        public virtual string GetAsText()
        {
            return ConstructVer(Version);
        }

        protected string ConstructVer(params int[] args)
        {
            string text = "";
            int index = 0;
            foreach (var ver in args)
            {
                text += ver.ToString();
                if (index != args.Length - 1)
                {
                    text += ".";
                }
                index++;
            }
            return text;
        }
    }
}