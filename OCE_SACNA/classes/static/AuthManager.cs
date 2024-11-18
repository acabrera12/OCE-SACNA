using System;
using System.Linq;
using System.Collections.Generic;

namespace OCE_SACNA;

public static class AuthManager
{
    // variables
    private static User loged_user;

    // enumeraciones
    public enum RANKING
    {
        UNASSIGNED,
        DEFAULT,
        USER,
        ADMIN
    }

    public enum USER_STATUS
    {
        UNASSIGNED,
        ENABLED,
        DISABLED
    }

    public enum CODES
    {
        OK,
        INVALID_USERNAME,
        INVALID_USER_RANK,
        INVALID_USER_ID,
        INVALID_USER_STATUS,
        INVALID_USER,
    }

    // metodos publicos
    public static bool get_admin_authorization()
    {
        if (loged_user.Rank == RANKING.DEFAULT)
        {
            return true;
        }

        if (loged_user.rank != RANKING.ADMIN)
        {
            return false;
        }

        return true;
    }

    public static CODES login(User user)
    {
        CODES result = validate_user(user);

        if (result != CODES.OK)
        {
            Console.WriteLine("Login error: " + result);
            return result;
        }

        Console.WriteLine("login successful as " + user.rank);

        loged_user = user;

        return result;
    }

    public static CODES logoff()
    {
        CODES result = validate_user(loged_user);

        if (result != CODES.OK)
        {
            Console.WriteLine("Logoff error" + result);
            return result;
        }

        loged_user = new User();

        return result;
    }

    // metodos privados
    private static CODES validate_user(User user)
    {
        if (!Entity.is_valid_id(user.ID))
        {
            return CODES.INVALID_USER_ID;
        }

        if (user.Rank == RANKING.UNASSIGNED)
        {
            return CODES.INVALID_USER_RANK;
        }

        if (user.Status == USER_STATUS.UNASSIGNED)
        {
            return CODES.INVALID_USER_STATUS;
        }

        if (user.Username == String.Empty)
        {
            return CODES.INVALID_USERNAME;
        }

        /* añadir la verificacion de la base de
        la base de datos cuando se realize la
        conexion.
        
        si no hay registros, devolver el codigo
        INVALID_USER perteneciente a CODES
        */

        return CODES.OK;
    }
}
