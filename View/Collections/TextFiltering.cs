using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCESACNA.View.Collections
{
    /// <summary>
    /// Clase estática usada para el filtrado de texto
    /// </summary>
    public static class TextFiltering
    {
        /// <summary>
        /// Filtra el text al tipo seleccionado
        /// </summary>
        /// <param name="Text">Texto</param>
        /// <param name="Type">Tipo de Filtrado</param>
        /// <returns>Texto filtrado usando <paramref name="Type"/></returns>
        public static string Filter(string Text, FilteringType Type)
        {
            switch (Type)
            {
                case FilteringType.Password:
                    return PasswordFiltering(Text);
                case FilteringType.Int:
                    return IntFiltering(Text);
                case FilteringType.Float:
                    return FloatFiltering(Text);
                default:
                    throw new Exception("Invalid FilteringType");
            }
        }

        /// <summary>
        /// Tipos de Filtrado
        /// </summary>
        public enum FilteringType
        {
            Password,
            Int,
            Float
        }

        /// <summary>
        /// Filtra los caracteres de un texto a formato contraseña
        /// </summary>
        /// <param name="text">Texto</param>
        /// <returns>Una cadena <see langword="string"/> filtrada</returns>
        private static string PasswordFiltering(string text)
        {
            string value = string.Empty;

            foreach(char c in text)
            {
                if ((c >= 48 && c <= 57) || c == 46)
                {
                    value += c;
                }
            }

            return value;
        }

        /// <summary>
        /// Filtra los caracteres de un texto a formato entero
        /// </summary>
        /// <param name="text">Texto</param>
        /// <returns>Una cadena <see langword="string"/> filtrada</returns>
        private static string IntFiltering(string text)
        {
            string value = string.Empty;

            foreach (char c in text)
            {
                if (c >= 48 && c <= 57)
                {
                    value += c;
                }
            }

            return value;
        }

        /// <summary>
        /// Filtra los caracteres de un texto a formato flotante
        /// </summary>
        /// <param name="text">Texto</param>
        /// <returns>Una cadena <see langword="string"/> filtrada</returns>
        private static string FloatFiltering(string text)
        {
            return text;
        }
    }
}
