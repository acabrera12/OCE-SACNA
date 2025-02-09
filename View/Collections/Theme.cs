using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCESACNA.View.Collections
{
    /// <summary>
    /// Clase destinada al re-coloreado de las innterfaces
    /// </summary>
    public class Theme
    {
        /// <summary>
        /// Obtiene o establece el color del fondo
        /// </summary>
        public Color BackgroundColor { get; set; }

        /// <summary>
        /// Obtiene o establece el color principal
        /// </summary>
        public Color MainColor { get; set; }

        /// <summary>
        /// Obtiene o establece el color secundario
        /// </summary>
        public Color SecondaryColor { get; set; }

        /// <summary>
        /// Obtiene o establece el color de la fuente contrastado
        /// </summary>
        public Color FontColorContrast { get; set; }

        /// <summary>
        /// Obtiene o establece el color de la fuente
        /// </summary>
        public Color FontColor { get; set; }

        /// <summary>
        /// Inicializa una instancia de la clase <see cref="Theme"/>
        /// </summary>
        /// <param name="BackgroundColor">Color del fondo</param>
        /// <param name="MainColor">Color principal</param>
        /// <param name="SecondaryColor">Color secundario</param>
        /// <param name="FontColorContrast">Color de la fuente contrastado</param>
        /// <param name="FontColor">Color de la fuente</param>
        public Theme(Color BackgroundColor, Color MainColor, Color SecondaryColor, Color FontColorContrast, Color FontColor)
        {
            this.BackgroundColor = BackgroundColor;
            this.MainColor = MainColor;
            this.SecondaryColor = SecondaryColor;
            this.FontColorContrast = FontColorContrast;
            this.FontColor = FontColor;
        }

        /// <summary>
        /// Temas disponibles
        /// </summary>
        public enum Themes
        {
            Default = 0
        }

        /// <summary>
        /// Obtiene el tema relacionado a la enumeración proporcionada en <paramref name="t"/>
        /// </summary>
        /// <param name="t">Tema enumerado</param>
        /// <returns><see cref="Theme"/> relacionado a la enumeración</returns>
        public static Theme GetTheme(Themes t)
        {
            Theme[] list = { Default };
            return list[(int)t];
        }

        #region Defined Themes
        /// <summary>
        /// Tema predeterminado
        /// </summary>
        public static Theme Default { get; } = new Theme(SystemColors.Control, Color.SteelBlue, SystemColors.Window, SystemColors.ControlText, SystemColors.ControlText);

        #endregion
    }

    /// <summary>
    /// Interfaz destinada a la implementación en formularios para colorear la interfaz con la clase <see cref="Theme"/>
    /// </summary>
    public interface IColoreable
    {
        /// <summary>
        /// Aplica el tema proporcionado
        /// </summary>
        /// <param name="theme">Tema a aplicar</param>
        void ApplyTheme(Theme theme);
    }
}
