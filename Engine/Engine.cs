using Engine.Core;

namespace Engine
{
    public static class Engine
    {
        public static void Initialize()
        {

        }

        public static async Task StartProcessing()
        {
            await Processor.StartProcessing();
        }
    }
}
