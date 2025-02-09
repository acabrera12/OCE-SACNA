using OCESACNA.Engine.Collections;

namespace OCESACNA.View.Collections
{
    /// <summary>
    /// Clase <see cref="ComboBoxElement"/> usada para crear elementos con valores para controles <see cref="System.Windows.Forms.ComboBox">ComboBox</see>
    /// </summary>
    public class ComboBoxElement
    {
        /// <summary>
        /// Texto a mostrar en controles <see cref="System.Windows.Forms.ComboBox"/>
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// Valor interno a almacenar
        /// </summary>
        public object Value { get; set; }

        /// <summary>
        /// Ajustar un control <see cref="System.Windows.Forms.ComboBox"/> para mostrar correctamente los datos
        /// </summary>
        /// <param name="comboBox"> <see cref="System.Windows.Forms.ComboBox"/></param> a ajustar</param>
        public static void AjustComboBox(System.Windows.Forms.ComboBox comboBox)
        {
            comboBox.DisplayMember = "Text";
            comboBox.ValueMember = "Value";
        }
    }

    /// <summary>
    /// Clase <see cref="RankComboBoxElement"/> usada para crear elementos <see cref="ComboBoxElement"/> con valores <see cref="User.RANKING"/>
    /// </summary>
    public class RankComboBoxElement : ComboBoxElement
    {
        /// <summary>
        /// Valor interno
        /// </summary>
        public new User.RANKING Value { get; set; }

        /// <summary>
        /// Inicializa una instancia de la clase <see cref="RankComboBoxElement"/>
        /// </summary>
        /// <param name="Text">texto a mostrar</param>
        /// <param name="Value">valor a almacenar</param>
        public RankComboBoxElement(string Text, User.RANKING Value)
        {
            this.Text = Text;
            this.Value = Value;
        }
    }

    /// <summary>
    /// Clase <see cref="StateComboBoxElement"/> usada para crear elementos <see cref="ComboBoxElement"/> con valores <see cref="User.STATES"/>
    /// </summary>
    public class StateComboBoxElement : ComboBoxElement
    {
        /// <summary>
        /// Valor interno
        /// </summary>
        public new User.STATES Value { get; set; }

        /// <summary>
        /// Inicializa una instancia de la clase <see cref="StateComboBoxElement"/>
        /// </summary>
        /// <param name="Text">texto a mostrar</param>
        /// <param name="Value">valor a almacenar</param>
        public StateComboBoxElement(string Text, User.STATES Value)
        {
            this.Text = Text;
            this.Value = Value;
        }
    }

    /// <summary>
    /// Clase <see cref="SexComboBoxElement"/> usada para crear elementos <see cref="ComboBoxElement"/> con valores <see cref="string"/>
    /// </summary>
    public class SexComboBoxElement : ComboBoxElement
    {
        /// <summary>
        /// Valor interno
        /// </summary>
        public new Student.SEXS Value { get; set; }

        /// <summary>
        /// Inicializa una instancia de la clase <see cref="SexComboBoxElement"/>
        /// </summary>
        /// <param name="Text">texto a mostrar</param>
        /// <param name="Value">valor a almacenar</param>
        public SexComboBoxElement(string Text, Student.SEXS Value)
        {
            this.Text = Text;
            this.Value = Value;
        }
    }

    /// <summary>
    /// Clase <see cref="BoolComboBoxElement"/> usada para crear elementos <see cref="ComboBoxElement"/> con valores <see cref="bool"/>
    /// </summary>
    public class BoolComboBoxElement : ComboBoxElement
    {
        /// <summary>
        /// Valor interno
        /// </summary>
        public new bool Value { get; set; }

        /// <summary>
        /// Inicializa una instancia de la clase <see cref="BoolComboBoxElement"/>
        /// </summary>
        /// <param name="Text">texto a mostrar</param>
        /// <param name="Value">valor a almacenar</param>
        public BoolComboBoxElement(string Text, bool Value)
        {
            this.Text = Text;
            this.Value = Value;
        }
    }

    /// <summary>
    /// Clase <see cref="StringComboBoxElement"/> usada para crear elementos <see cref="ComboBoxElement"/> con valores <see cref="string"/>
    /// </summary>
    public class StringComboBoxElement : ComboBoxElement
    {
        /// <summary>
        /// Valor interno
        /// </summary>
        public new string Value { get; set; }

        /// <summary>
        /// Inicializa una instancia de la clase <see cref="StringComboBoxElement"/>
        /// </summary>
        /// <param name="Text">texto a mostrar</param>
        /// <param name="Value">valor a almacenar</param>
        public StringComboBoxElement(string Text, string Value)
        {
            this.Text = Text;
            this.Value = Value;
        }
    }

    /// <summary>
    /// Clase <see cref="IntComboBoxElement"/> usada para crear elementos <see cref="ComboBoxElement"/> con valores <see cref="string"/>
    /// </summary>
    public class IntComboBoxElement : ComboBoxElement
    {
        /// <summary>
        /// Valor interno
        /// </summary>
        public new int Value { get; set; }

        /// <summary>
        /// Inicializa una instancia de la clase <see cref="IntComboBoxElement"/>
        /// </summary>
        /// <param name="Text">texto a mostrar</param>
        /// <param name="Value">valor a almacenar</param>
        public IntComboBoxElement(string Text, int Value)
        {
            this.Text = Text;
            this.Value = Value;
        }
    }

    public class CourseComboBoxElement : ComboBoxElement
    {
        /// <summary>
        /// Valor interno
        /// </summary>
        public new Course Value { get; set; }

        /// <summary>
        /// Inicializa una instancia de la clase <see cref="CourseComboBoxElement"/>
        /// </summary>
        /// <param name="Text">texto a mostrar</param>
        /// <param name="Value">valor a almacenar</param>
        public CourseComboBoxElement(string Text, Course Value)
        {
            this.Text = Text;
            this.Value = Value;
        }
    }
}
