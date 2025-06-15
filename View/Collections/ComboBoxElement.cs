using ComboBox = System.Windows.Forms.ComboBox;

namespace OCESACNA.View.Collections
{
    /// <summary>
    /// Representa un elemento con Texto y Valor para controles <see cref="ComboBox"/>
    /// </summary>
    public class ComboBoxElement
    {
        /// <summary>
        /// Obtiene o establece el texto a mostrar como miembro de visualización en controles <see cref="ComboBox"/>
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Obtiene o establece el valor a almacenar como interno para los controles <see cref="ComboBox"/>
        /// </summary>
        public object Value { get; set; }

        /// <summary>
        /// Configura el <paramref name="comboBox"/> proporcionado para mostrar correctamente los valres del <see cref="ComboBoxElement{T}"/>
        /// </summary>
        /// <param name="comboBox">ComboBox a configurar</param>
        /// <param name="setSelectedIndex">Establecer el índice seleccionado del <paramref name="comboBox"/> en el valor 0</param>
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
        /// Inicializa una instancia de la clase <see cref="ComboBoxElement"/>
        /// </summary>
        public ComboBoxElement()
        {
            Text = string.Empty;
            Value = null;
        }
    }

    /// <summary>
    /// Representa un elemento con Texto y Valor para controles <see cref="ComboBox"/>
    /// </summary>
    /// <typeparam name="T">Tipo de valor interno</typeparam>
    public class ComboBoxElement<T> : ComboBoxElement
    {
        /// <summary>
        /// Obtiene o establece el valor a almacenar como interno para los controles <see cref="ComboBox"/>
        /// </summary>
        public new T Value { get; set; }

        /// <summary>
        /// Inicializa una instancia de la clase <see cref="ComboBoxElement{T}"/>
        /// </summary>
        /// <param name="text">Texto</param>
        /// <param name="value">Valor interno</param>
        public ComboBoxElement(string text, T value)
        {
            Text = text;
            Value = value;
        }
    }
}
