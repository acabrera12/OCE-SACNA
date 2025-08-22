using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace OCESACNA.View.Collections
{
    // Temas version 3.0
    /// <summary>
    /// Representa una colección de colores de un tema para las interfaces
    /// </summary>
    public class ColorTheme
    {

        /// <summary>
        /// Inicializa una instancia de la clase <see cref="ColorTheme"/>
        /// </summary>
        public ColorTheme()
        {
            Name = "Predeterminado";
            DarkMode = false;
            _ThemeEnumeration = Themes.SACNA;
            _BackgroundColor = SystemColors.Control;
            _DarkBackgroundColor = Color.FromArgb(28, 28, 28);
            _ForeColor = SystemColors.ControlLightLight;
            _DarkForeColor = Color.FromArgb(45, 45, 48);
            _HightlineColor = Color.FromArgb(122, 122, 204);
            _FontColor = SystemColors.ControlText;
            _DarkFontColor = SystemColors.ControlLightLight;
            _ContrastedFontColor = SystemColors.ControlLightLight;
            _DarkContrastedFontColor = SystemColors.ControlLightLight;
            _ButtonStyle = new ButtonStyle(SystemColors.ButtonFace, SystemColors.ButtonShadow);
            _DarkButtonStyle = new ButtonStyle(Color.FromArgb(45, 45, 48), SystemColors.ControlText);
            _HightlineButtonStyle = new ButtonStyle(Color.FromArgb(122, 122, 204), Color.FromArgb(122, 122, 204));
        }

        /// <summary>
        /// Representa un método que controlará un evento de cambio de tema de color
        /// </summary>
        /// <param name="theme">tema</param>
        public delegate void ThemeChangedEventHandler(ColorTheme theme);

        /// <summary>
        /// Representa un método que controlará un evento de cambio de modo de color
        /// </summary>
        /// <param name="value"></param>
        public delegate void DarkModeChangedEventHandler(bool value);

        /// <summary>
        /// Evento llamado cuando se cambia el tema
        /// </summary>
        public static event ThemeChangedEventHandler ThemeChanged;

        /// <summary>
        /// Evento llamado cuando se cambia el modo de color
        /// </summary>
        public event DarkModeChangedEventHandler DarkModeChanged;

        /// <summary>
        /// Representa la enumeración de temas
        /// </summary>
        public enum Themes
        {
            SACNA = 0
        }

        /// <summary>
        /// Representa el tipo de fondo
        /// </summary>
        public enum BackgroundType
        {
            Background,
            ForeBackground,
            HightlineBackground
        }

        /// <summary>
        /// Es llamado cuando se cambia el tema
        /// </summary>
        /// <param name="theme">Nuevo tema</param>
        protected static void OnThemeChanged(ColorTheme theme)
        {
            ThemeChanged?.Invoke(theme);
        }

        /// <summary>
        /// Es llamado cuando se cambia el modo de color
        /// </summary>
        /// <param name="value"></param>
        protected void OnDarkModeChanged(bool value)
        {
            DarkModeChanged?.Invoke(value);
        }

        /// <summary>
        /// Dispara el evento <see cref="ThemeChanged"/>
        /// </summary>
        /// <param name="theme">tema</param>
        public static void ChangeTheme(ColorTheme theme)
        {
            Program.Settings.Theme = (int)theme._ThemeEnumeration;
            OnThemeChanged(theme);
        }

        /// <summary>
        /// Establece el valor de <see cref="DarkMode"/>
        /// </summary>
        /// <param name="value">nuevo valor</param>
        public void SetDarkMode(bool value)
        {
            DarkMode = value;
            Program.Settings.ThemeDarkMode = value;
            OnDarkModeChanged(value);
        }

        /// <summary>
        /// Aplica el color de fondo a los paneles proporcionados
        /// </summary>
        /// <param name="controls">Paneles</param>
        public void ApplyBackgroundStyle(params Control[] controls)
        {
            foreach (Control control in controls)
            {
                control.BackColor = BackgroundColor;
                control.ForeColor = FontColor;
            }
        }

        /// <summary>
        /// Aplica el color de elemento en primer plano a los paneles proporcionados
        /// </summary>
        /// <param name="controls">Paneles</param>
        public void ApplyForeStyle(params Control[] controls)
        {
            foreach (Control control in controls)
            {
                control.BackColor = ForeColor;
                control.ForeColor = FontColor;
            }
        }


        /// <summary>
        /// Aplica el color de elementos resaltados a los paneles proporcionados
        /// </summary>
        /// <param name="controls">Paneles</param>
        public void ApplyHightlineStyle(params Control[] controls)
        {
            foreach (Control control in controls)
            {
                control.BackColor = HightlineColor;
                control.ForeColor = FontColor;
            }
        }

        /// <summary>
        /// Aplica el color de la fuente de texto a las etiquetas proporcionadas
        /// </summary>
        /// <param name="background">Fondo del elemento</param>
        /// <param name="labels">Etiquetas</param>
        public void ApplyFontStyle(BackgroundType background, params Label[] labels)
        {
            foreach (Label label in labels)
            {
                Color backColor;

                switch (background)
                {
                    case BackgroundType.ForeBackground:
                        backColor = ForeColor;
                        break;
                    case BackgroundType.HightlineBackground:
                        backColor = HightlineColor;
                        break;
                    default:
                        backColor = BackgroundColor;
                        break;
                }

                label.BackColor = backColor;
                label.ForeColor = FontColor;
            }
        }

        /// <summary>
        /// Aplica el color de la fuente de texto oscuro a las etiquetas proporcionadas
        /// </summary>
        /// <param name="background">Fondo del elemento</param>
        /// <param name="labels">Etiquetas</param>
        public void ApplyContrastedFontStyle(BackgroundType background, params Label[] labels)
        {
            foreach (Label label in labels)
            {
                Color backColor;

                switch (background)
                {
                    case BackgroundType.ForeBackground:
                        backColor = BackgroundColor;
                        break;
                    case BackgroundType.HightlineBackground:
                        backColor = HightlineColor;
                        break;
                    default:
                        backColor = BackgroundColor;
                        break;
                }

                label.BackColor = backColor;
                label.ForeColor = ContrastedFontColor;
            }
        }

        /// <summary>
        /// Aplica el estilo de botones a los botones proporcionados
        /// </summary>
        /// <param name="buttons">Botones</param>
        public void ApplyButtonStyle(params Button[] buttons)
        {
            foreach (Button button in buttons)
            {
                button.FlatStyle = DarkMode ? FlatStyle.Popup : FlatStyle.Standard;
                button.BackColor = ButtonStyle.BackgroundColor;
                button.ForeColor = FontColor;

                if (button is FontAwesome.Sharp.IconButton)
                {
                    ((FontAwesome.Sharp.IconButton)button).IconColor = FontColor;
                }
            }
        }

        /// <summary>
        /// Aplica el estilo de botones resaltados a los botones proporcionados
        /// </summary>
        /// <param name="buttons">Botones</param>
        public void ApplyHightlineButtonStyle(params Button[] buttons)
        {
            foreach (Button button in buttons)
            {
                button.FlatStyle = FlatStyle.Flat;
                button.BackColor = HightlineButtonStyle.BackgroundColor;
                button.ForeColor = ContrastedFontColor;

                if (button is FontAwesome.Sharp.IconButton)
                {
                    ((FontAwesome.Sharp.IconButton)button).IconColor = ContrastedFontColor;
                }
            }
        }

        /// <summary>
        /// Obtiene el tema solicitado
        /// </summary>
        /// <param name="theme">Tema solicitado</param>
        /// <returns>El tema solicitado clase <see cref="ColorTheme"/></returns>
        public static ColorTheme GetTheme(Themes theme)
        {
            return _ThemeList.Where(t => t._ThemeEnumeration == theme).First();
        }

        /// <summary>
        /// Obtiene o establece el nombre del tema
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Obtiene o establece el valor que determina si se usan los colores oscuros del tema
        /// </summary>
        public bool DarkMode { get; private set; }

        /// <summary>
        /// Obtiene el color del fondo
        /// </summary>
        public Color BackgroundColor
        {
            get
            {
                return DarkMode ? _DarkBackgroundColor : _BackgroundColor;
            }
        }

        /// <summary>
        /// Obtiene el color de elementos en primer plano
        /// </summary>
        public Color ForeColor
        {
            get
            {
                return DarkMode ? _DarkForeColor : _ForeColor;
            }
        }

        /// <summary>
        /// Obtiene el color de elementos resaltados
        /// </summary>
        public Color HightlineColor
        {
            get
            {
                return _HightlineColor;
            }
        }

        /// <summary>
        /// Obtiene el color de la fuente de texo
        /// </summary>
        public Color FontColor
        {
            get
            {
                return DarkMode ? _DarkFontColor : _FontColor;
            }
        }

        /// <summary>
        /// Obtiene el color de la fuente de texto en fondo oscuro
        /// </summary>
        public Color ContrastedFontColor
        {
            get
            {
                return DarkMode ? _DarkContrastedFontColor : _ContrastedFontColor;
            }
        }

        /// <summary>
        /// Obtiene el estilo para los botones
        /// </summary>
        public ButtonStyle ButtonStyle
        {
            get
            {
                return DarkMode ? _DarkButtonStyle : _ButtonStyle;
            }
        }

        /// <summary>
        /// Obtiene el estilo para los botones
        /// </summary>
        public ButtonStyle HightlineButtonStyle
        {
            get
            {
                return _HightlineButtonStyle;
            }
        }

        /// <summary>
        /// Enumeración del tema
        /// </summary>
        private readonly Themes _ThemeEnumeration;

        /// <summary>
        /// Color del fondo
        /// </summary>
        private readonly Color _BackgroundColor;

        /// <summary>
        /// Color del fondo oscuro
        /// </summary>
        private readonly Color _DarkBackgroundColor;

        /// <summary>
        /// Color del elemento en primer plano
        /// </summary>
        private readonly Color _ForeColor;

        /// <summary>
        /// Color del elemento en primer plano oscuro
        /// </summary>
        private readonly Color _DarkForeColor;

        /// <summary>
        /// Color del elemento resaltado
        /// </summary>
        private readonly Color _HightlineColor;

        /// <summary>
        /// Color de la fuente de texo
        /// </summary>
        private readonly Color _FontColor;

        /// <summary>
        /// Color de la fuente de texo oscuro
        /// </summary>
        private readonly Color _DarkFontColor;

        /// <summary>
        /// Color de la fuente de texo en fondo oscuro
        /// </summary>
        private readonly Color _ContrastedFontColor;

        /// <summary>
        /// Color de la fuente de texo en fondo claro
        /// </summary>
        private readonly Color _DarkContrastedFontColor;

        /// <summary>
        /// Estilo para botones
        /// </summary>
        private readonly ButtonStyle _ButtonStyle;

        /// <summary>
        /// Estilo para botones oscuros
        /// </summary>
        private readonly ButtonStyle _DarkButtonStyle;

        /// <summary>
        /// Estilo para botones resaltados
        /// </summary>
        private readonly ButtonStyle _HightlineButtonStyle;

        /// <summary>
        /// Lista de temas
        /// </summary>
        private static readonly Collection<ColorTheme> _ThemeList = new Collection<ColorTheme>()
        {
            new ColorTheme()
        };
    }

    /// <summary>
    /// Representa el estilo para los botones
    /// </summary>
    public struct ButtonStyle
    {
        /// <summary>
        /// Inicializa una instancia de la estructura <see cref="ButtonStyle"/>
        /// </summary>
        /// <param name="backgroundColor">Color del fondo para botones</param>
        /// <param name="borderColor">Color del borde para botones</param>
        public ButtonStyle(Color backgroundColor, Color borderColor)
        {
            BackgroundColor = backgroundColor;
            BorderColor = borderColor;
        }

        /// <summary>
        /// Obtiene el color del fondo para los botones
        /// </summary>
        public Color BackgroundColor { get; }

        /// <summary>
        /// Obtiene el color del borde para los botones
        /// </summary>
        public Color BorderColor { get; }
    }

    /// <summary>
    /// Representa un estilo para las cajas de texto
    /// </summary>
    public struct TextBoxStyle
    {

    }

    /// <summary>
    /// Representa un estilo para las regillas de datos
    /// </summary>
    public struct DataGridStyle
    {

    }
}
