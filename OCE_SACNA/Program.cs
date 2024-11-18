using System;
using System.Linq;
using System.Threading.Tasks;

namespace OCE_SACNA;

public static class Program
{
    private static UpdateManager UpdateManager = new UpdateManager();

    public static async Task Main()
    {
        SettingsManager.Load();

        User user = new User(0, "Chilos", AuthManager.RANKING.ADMIN, AuthManager.USER_STATUS.ENABLED);

        AuthManager.login(user);

        await UpdateManager.StartUpdating();
    }
}
