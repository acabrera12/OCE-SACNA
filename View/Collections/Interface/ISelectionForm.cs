using System;

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
        event SelectionFormEventHanlder<T> Acepted;

        /// <summary>
        /// Evento llamado cuando se cancela el formulario
        /// </summary>
        event EventHandler Aborted;

        /// <summary>
        /// Limpia el formulario
        /// </summary>
        void Clear();
    }

    /// <summary>
    /// Representa un método que controlará un evento de un formulario de
    /// selección de datos
    /// </summary>
    /// <typeparam name="T">Tipo de datos a seleccionar</typeparam>
    /// <param name="selectedItem">Elemento seleccionado</param>
    public delegate void SelectionFormEventHanlder<T>(T selectedItem);
}
