using Engine.Core;
using Engine.ClassDB;
using Engine.ClassDB.Asbtract;
using Engine.Interface;

namespace Engine
{
    public static class EngineController
    {
        public static Version3 Version = new Version3(0,1,2);

        public static void Initialize()
        {

        }

        public static Version3 GetEngineVersion()
        {
            return Version;
        }

        public static string GetEngineVersionAsString()
        {
            return Version.GetVersionAsString();
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

        public static void AddProcessableItem(IProcessable item)
        {
            Processor.AddProcessable(item);
        }
    }

    public static class AuthMgrController
    {
        public static AuthMgr.ResultCode Login(User user)
        {
            return AuthMgr.TryLogginAs(user);
        }

        public static AuthMgr.ResultCode Logout()
        {
            return AuthMgr.Logout();
        }

        public static bool GetAdminAuthorization()
        {
            return AuthMgr.GetAdministratorAuthorization();
        }
    }
}
