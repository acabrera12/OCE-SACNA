namespace OCESACNA.View.Collections
{
    /// <summary>
    /// Interfaz <see cref="IColoreable"/> requerida para aplicar temas de color a formularios
    /// </summary>
    public interface IColoreable
    {
        /// <summary>
        /// Aplica el <paramref name="theme"/> proporcionado
        /// </summary>
        /// <param name="theme">Tema de color</param>
        void ApplyTheme(ColorTheme theme);

        /// <summary>
        /// Es llamado cuando se cambia el tema del programa
        /// </summary>
        /// <param name="theme">Tema de color</param>
        void ColorTheme_ThemeChanged(ColorTheme theme);

        /// <summary>
        /// Es llamado cuando se cambio de modo de color del tema del programa
        /// </summary>
        /// <param name="value">nuevo valor</param>
        void ColorTheme_DarkModeChanged(bool value);
    }
}
