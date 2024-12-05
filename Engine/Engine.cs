using Engine.Core;
using Engine.ClassDB;
using Engine.ClassDB.Asbtract;
using Engine.Interface;

namespace Engine
{
    public static class EngineController
    {
        public static Version3 Version = new Version3(0,1,8);

        public static void Initialize()
        {

        }

        public static Version3 GetEngineVersion()
        {
            return Version;
        }

        public static string GetEngineVersionAsText()
        {
            return Version.GetAsText();
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
}
