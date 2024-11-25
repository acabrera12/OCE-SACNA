using System.Reflection;

namespace OfficeLayer
{
    public class ProcessManager
    {
        private List<IProcessabled> processables = new List<IProcessabled>();
        private int ProcessDelay = 33; // delay in ms
        private bool IsProcessing = true;

        public async Task StartProcessing()
        {
            IsProcessing = true;

            while (IsProcessing)
            {
                foreach (IProcessabled processabled in processables)
                {
                    processabled.Process();
                }
                await Task.Delay(ProcessDelay);
            }
        }

        public void StopProcessing()
        {
            IsProcessing = false;
        }

        public ProcessManager()
        {
            var ProcessabledTypes = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.GetCustomAttributes(typeof(AutoProcessAtrribute), true).Length > 0)
                .Where(t => typeof(IProcessabled).IsAssignableFrom(t));
        }
    }

    [AttributeUsage(AttributeTargets.Class)]
    public class AutoProcessAtrribute : Attribute
    {

    }

    public interface IProcessabled
    {
        void Process();
    }
}
