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
        void ApplyTheme(Theme theme);
    }
}
