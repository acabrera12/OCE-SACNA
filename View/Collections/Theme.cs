using System.Collections.Generic;
using System.Drawing;

namespace OCESACNA.View.Collections
{
    /// <summary>
    /// Representa un conjunto de colores que conforman un tema
    /// </summary>
    public class Theme
    {
        /// <summary>
        /// Obtiene o establece la enumeración del tema
        /// </summary>
        public Themes ThemeEnumeration { get; set; }

        /// <summary>
        /// Obtiene o establece el color de fondo
        /// </summary>
        public Color BackColor { get; set; }

        /// <summary>
        /// Obtiene o establece el color frontal
        /// </summary>
        public Color Color { get; set; }

        /// <summary>
        /// Obtiene o establece el color de resaltado
        /// </summary>
        public Color HighlightColor { get; set; }

        /// <summary>
        /// Obtiene o establece el color de primer plano
        /// </summary>
        public Color ForeColor { get; set; }

        /// <summary>
        /// Obtiene o establece el color de la fuente contrastado
        /// </summary>
        public Color ContrastForeColor { get; set; }

        /// <summary>
        /// Obtiene o establece el color de los botones
        /// </summary>
        public Color ButtonFaceColor { get; set; }

        /// <summary>
        /// Enumeración de los temas disponibles
        /// </summary>
        public enum Themes
        {
            System = 0,
            LigthBlack = 1
        }

        /// <summary>
        /// Inicializa una instancia de la clase <see cref="Theme"/> con valores predeterminados
        /// </summary>
        public Theme()
        {
            ThemeEnumeration = Themes.System;
            BackColor = SystemColors.Control;
            Color = SystemColors.ControlLightLight;
            HighlightColor = Color.MediumPurple;
            ForeColor = SystemColors.ControlText;
            ContrastForeColor = SystemColors.ControlLightLight;
            ButtonFaceColor = SystemColors.ButtonFace;
        }

        /// <summary>
        /// Inicializa una instancia de la clase <see cref="Theme"/>
        /// </summary>
        /// <param name="back">Color del fondo</param>
        /// <param name="color">Color frontal</param>
        /// <param name="highlightColor">Color del resaltado</param>
        /// <param name="fore">Color de la fuente</param>
        /// <param name="contrastFontColor">Color de la fuente contrastado</param>
        /// <param name="btnColor">Color para los botones</param>
        /// <param name="themeEnumeration">Enumeración del tema</param>
        public Theme(Color back, Color color, Color highlightColor, Color fore, Color contrastFontColor, Color btnColor, Themes themeEnumeration)
        {
            BackColor = back;
            Color = color;
            HighlightColor = highlightColor;
            ForeColor = fore;
            ContrastForeColor = contrastFontColor;
            ButtonFaceColor = btnColor;
            ThemeEnumeration = themeEnumeration;
        }

        /// <summary>
        /// Obtiene el tema enumerado
        /// </summary>
        /// <param name="theme">Enumeración del tema</param>
        /// <returns><see cref="Theme"/> asociado a la enumeración proporcinada</returns>
        public static Theme GetTheme(Themes theme)
        {
            return ThemesList[theme];
        }

        /// <summary>
        /// Representa un método que controlará un evento
        /// </summary>
        /// <param name="newTheme"></param>
        public delegate void ThemeChangedEventHandler(Theme newTheme);

        /// <summary>
        /// Evento de cambiar el tema del programa
        /// </summary>
        public static event ThemeChangedEventHandler ThemeChanged;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newTheme"></param>
        protected static void OnThemeChanged(Theme newTheme)
        {
            ThemeChanged?.Invoke(newTheme);
        }

        public static void ChangeTheme(Theme newTheme)
        {
            OnThemeChanged(newTheme);
        }

        #region temas de color
        /// <summary>
        /// Tema predeterminado. Usa colores del sistema
        /// </summary>
        public static Theme System { get; } = new Theme();

        /// <summary>
        /// Tema claro con color de resaltado oscuro
        /// </summary>
        public static Theme LigthBlack { get; } = new Theme(SystemColors.Control, SystemColors.ControlLightLight, Color.FromArgb(30, 30, 30), SystemColors.ControlText, SystemColors.ControlLightLight, SystemColors.ButtonFace, Themes.LigthBlack);

        #endregion

        /// <summary>
        /// Lista de temas
        /// </summary>
        private static readonly Dictionary<Themes, Theme> ThemesList = new Dictionary<Themes, Theme>()
        {
            { Themes.System, System },
            { Themes.LigthBlack, LigthBlack }
        };
    }
}
