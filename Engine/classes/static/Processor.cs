namespace Engine
{
    internal static class Processor
    {
        private static List<IProcessable> ProcessableElements = new List<IProcessable>();
        private static bool IsProcessing = false;
        
        internal static async Task StartProcessing()
        {
            IsProcessing = true;

            while (IsProcessing)
            {
                foreach (IProcessable Processable in ProcessableElements)
                {
                    Processable.Process();
                }
            }
        }

        internal static void StopProcessing()
        {
            IsProcessing = false;
        }

        internal static void Initialize()
        {
            
        }
    }
}