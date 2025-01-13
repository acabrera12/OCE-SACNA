using System.Collections.Generic;
namespace OCESACNA.View.Collections
{
    /// <summary>
    /// Interfaz de la cual derivan los formularios de datos
    /// </summary>
    public interface IDataForm
    {
        /// <summary>
        /// Establece los datos en el formulario
        /// </summary>
        void SetData(Dictionary<string, dynamic> data);
        /// <summary>
        /// Obtiene los datos en el formulario
        /// </summary>
        /// <returns><c>Object[]</c> Colección de objetos</returns>
        object[] GetData();
        /// <summary>
        /// Limpia los datos del formulario
        /// </summary>
        void ClearData();
    }
}
