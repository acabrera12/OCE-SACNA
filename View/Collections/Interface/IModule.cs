using System;
using DataGridViewCellEventArgs = System.Windows.Forms.DataGridViewCellEventArgs;

namespace OCESACNA.View.Collections
{
    /// <summary>
    /// Interfaz <see cref="IModule"/> requerida para la construcción basica de algún módulo de datos
    /// </summary>
    public interface IModule
    {

        /// <summary>
        /// Obtiene o establece el valor que determina si se está editando los datos en el formulario
        /// </summary>
        bool IsEditing { get; set; }

        /// <summary>
        /// Obtiene o establece el valor del índice seleccionado de la regilla de datos
        /// </summary>
        int SelectedIndex { get; set; }

        /// <summary>
        /// Carga los datos desde la base de datos
        /// </summary>
        void LoadData();

        /// <summary>
        /// Es llamado cuando los datos de la base de datos fueron modificados
        /// </summary>
        //void ReloadData();

        /// <summary>
        /// Es llamado cuando se modifica el texto de una de las cajas de texto del formulario
        /// </summary>
        void TextBox_TextChanged(object sender, EventArgs e);

        /// <summary>
        /// Es llamado cuando se hace click en un elemento de la regilla de datos
        /// </summary>
        void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e);

        /// <summary>
        /// Es llamado cuando se hace clien en el botón para crear
        /// </summary>
        void CreateButton_Click(object sender, EventArgs e);

        /// <summary>
        /// Es llamado cuando se hace clien en el botón para editar
        /// </summary>
        void EditButton_Click(object sender, EventArgs e);

        /// <summary>
        /// Es llamado cuando se hace clien en el botón para eliminar
        /// </summary>
        void EraseButton_Click(object sender, EventArgs e);

        /// <summary>
        /// Limpia las cajas de texto del formulario
        /// </summary>
        void Clear();
    }
}
