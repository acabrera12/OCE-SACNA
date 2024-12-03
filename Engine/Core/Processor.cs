using Engine.Interface;

namespace Engine.Core
{
    internal static class Processor
    {
        private static readonly List<IProcessable> Processables = new List<IProcessable>();
        private static bool IsProcessing = false;
        private static readonly int ProcessDelay = 33;

        public static async Task StartProcessing()
        {
            while (IsProcessing)
            {
                foreach (IProcessable processable in Processables)
                {
                    processable.Process();
                }
            }

            await Task.Delay(ProcessDelay);
        }

        public static void StopProcessing()
        {
            IsProcessing = false;
        }

        public static void AddProcessable(IProcessable processable)
        {
            Processables.Add(processable);
        }
    }
}
