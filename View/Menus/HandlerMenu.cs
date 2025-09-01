using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OCESACNA.View.Menus
{
    /// <summary>
    /// Representa el menú de soporte integrado
    /// </summary>
    public partial class HandlerMenu : Form
    {
        /// <summary>
        /// Obtiene o establece el valor que determina si se termina la ejecución de la aplicación
        /// </summary>
        public static bool CloseOnExit { get; private set; } = false;

        /// <summary>
        /// Obtiene o establece el error del menú
        /// </summary>
        private Exception Exception { get; set; }

        /// <summary>
        /// Inicializa una nueva instancia de la clase 
        /// </summary>
        /// <param name="exception">Error provocado</param>
        public HandlerMenu(Exception exception)
        {
            Exception = exception;
            InitializeComponent();
        }
    }
}
