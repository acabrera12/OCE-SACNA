using Engine.Core;
using Engine.ClassDB;
using Engine.ClassDB.Asbtract;
using Engine.Interface;

namespace Engine
{
    public static class EngineController
    {
        public static void Initialize()
        {

        }
    }

    public static class ProcessorController
    {
        public static void EndProcessing()
        {
            Processor.StopProcessing();
        }

        public static async Task StartProcessing()
        {
            await Processor.StartProcessing();
        }

        public static void AddProcessableItem(IProcesable item)
        {
            Processor.AddProcessable(item);
        }
    }

    public static class AuthMgrController
    {
        public static AuthMgr.ResultCode Loggin(User user)
        {
            return AuthMgr.TryLogginAs(user);
        }

        public static AuthMgr.ResultCode Logout()
        {
            return AuthMgr.Logoff();
        }

        public static bool GetAdminAuthorization()
        {
            return AuthMgr.GetAdministratorAuthorization();
        }
    }
}
