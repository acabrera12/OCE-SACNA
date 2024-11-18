using System;
using System.Linq;

namespace OCE_SACNA

public class Entity
{
    public const int MaxID = 999999999;
    public int ID { get; set;}

    public bool is_valid_id(int id)
    {
        if (ID < 0 || ID > MaxID)
        {
            return false;
        }
        return true;
    }
}