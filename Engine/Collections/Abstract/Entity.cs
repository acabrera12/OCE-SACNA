namespace OCESACNA.Engine.Collections.Abstract
{
    public abstract class Entity
    {
        public const int MaxID = 999999999;

        public bool IsValidID(int id)
        {
            if (id > MaxID || id < 0)
            {
                return false;
            }
            return true;
        }
    }
}