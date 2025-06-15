using System;
using System.Windows.Forms;

namespace OCESACNA.View.Collections
{
    /// <summary>
    /// Interfaz <see cref="ISelectionForm"/> requerida para la construcción de formularios de selección de datos
    /// </summary>
    /// <typeparam name="T">Tipo de datos</typeparam>
    public interface ISelectionForm<T>
    {
        /// <summary>
        /// Obtiene o establece el elemento seleccionado del tipo de datos del formulario
        /// </summary>
        T SelectedItem { get; set; }

        /// <summary>
        /// Carga los datos desde la base de datos
        /// </summary>
        void LoadData();

        /// <summary>
        /// Evento llamado cuando se acepta el formulario
        /// </summary>
        event EventHandler Acepted;

        /// <summary>
        /// Evento llamado cuando se cancela el formulario
        /// </summary>
        event EventHandler Aborted;

        /// <summary>
        /// Dispara el evento <see cref="Acepted"/>
        /// </summary>
        void OnAcept();

        /// <summary>
        /// Dispara el evento <see cref="Aborted"/>
        /// </summary>
        void OnAbort();

        /// <summary>
        /// Es llamado cuando se presiona el botón aceptar en el formulario
        /// </summary>
        void AceptButton_Click(object sender, EventArgs e);

        /// <summary>
        /// Es llamado cuando se presiona el botón cancelar en el formulario
        /// </summary>
        void AbortButton_Click(object sender, EventArgs e);

        /// <summary>
        /// Es llamado cuando se hace click en un elemento de la tabla de datos
        /// </summary>
        void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e);

        /// <summary>
        /// Limpia el formulario
        /// </summary>
        void Clear();
    }
}
