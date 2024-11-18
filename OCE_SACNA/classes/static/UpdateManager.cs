using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Reflection;

namespace OCE_SACNA;

public class UpdateManager
{
    private List<IUpdatable> updatables = new List<IUpdatable>();
    private bool is_updating = true;

    /*
        tiempo en ms (microsegundos) que transcurren
        entre cada llamado, fue calculado dividiendo
        1000ms (1s) entre los fps (30)
    */
    private static int update_time_ms = 33;

    // metodo asincronico que llama a los metodos Update()
    public async Task StartUpdating()
    {
        while (is_updating)
        {
            //ConnectManager.Update(); // actualizar ConnectManager
            //SettingsManager.Update(); // actualizar Settings Manager

            foreach (IUpdatable updatable in updatables)
            {
                updatable.Update();
            }
            await Task.Delay(update_time_ms);
        }
    }

    // detiene los llamados Update()
    public void StopUpdating()
    {
        this.is_updating = false;
    }

    // detecta las clases que usan Update()
    public UpdateManager()
    {
        // Usa reflexión para encontrar todas las clases con el atributo AutoUpdate
        var updatableTypes = Assembly.GetExecutingAssembly().GetTypes()
            .Where(t => t.GetCustomAttributes(typeof(AutoUpdateAttribute), true).Length > 0)
            .Where(t => typeof(IUpdatable).IsAssignableFrom(t));

        foreach (var type in updatableTypes)
        {
            var instance = (IUpdatable)Activator.CreateInstance(type);
            updatables.Add(instance);
        }
    }
}
