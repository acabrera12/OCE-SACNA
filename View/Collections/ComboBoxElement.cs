using ComboBox = System.Windows.Forms.ComboBox;

namespace OCESACNA.View.Collections
{
    /// <summary>
    /// Representa un elemento con Texto y Valor para controles <see cref="ComboBox"/>
    /// </summary>
    /// <typeparam name="T">Tipo de valor interno</typeparam>
    public class ComboBoxElement<T>
    {
        /// <summary>
        /// Obtiene o establece el texto a mostrar como miembro de visualización en controles <see cref="ComboBox"/>
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Obtiene o establece el valor a almacenar como interno para los controles <see cref="ComboBox"/>
        /// </summary>
        public T Value { get; set; }

        /// <summary>
        /// Configura el <paramref name="comboBox"/> proporcionado para mostrar correctamente los valres del <see cref="ComboBoxElement{T}"/>
        /// </summary>
        /// <param name="comboBox">ComboBox a configurar</param>
        /// <param name="setSelectedIndex">Establecer el índice seleccionado del <paramref name="comboBox"/> en elv alor 0</param>
        public static void SetupComboBox(ComboBox comboBox, bool setSelectedIndex)
        {
            comboBox.DisplayMember = "Text";
            comboBox.ValueMember = "Value";

            if (setSelectedIndex)
            {
                comboBox.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Inicializa una instancia de la clase <see cref="ComboBoxElement{T}"/>
        /// </summary>
        /// <param name="text">Texto que se usuará como miembro de visualización</param>
        /// <param name="value">Valor que se usuará como miembro inteno de tipo <typeparamref name="T"/></param>
        public ComboBoxElement(string text, T value)
        {
            Text = text;
            Value = value;
        }
    }
}
