using System.Linq;

namespace OCESACNA.View.Collections
{
    /// <summary>
    /// Filtrado de texto
    /// </summary>
    public static class TextFilter
    {
        /// <summary>
        /// Filtra el texto proporcionado a sólo caracteres numéricos
        /// </summary>
        /// <param name="text">Texto a filtrar</param>
        /// <returns>Una cadena <see langword="string"/> con sólo caracteres numéricos</returns>
        public static string IntFilter(string text)
        {
            string result = string.Empty;
            bool isNegative = false;

            foreach (char chr in text)
            {
                if (chr >= 48 && chr <= 57)
                {
                    result += chr;
                }
                else if (chr == 45 && !isNegative)
                {
                    result += chr;
                    isNegative = true;
                }
            }

            return result;
        }

        /// <summary>
        /// Determina si el texto proporcionado es equivalente a su versión filtrada
        /// </summary>
        /// <param name="text">Texto</param>
        /// <returns><see langword="true"/> si el válido, <see langword="false"/> si no</returns>
        public static bool IsValidIntText(string text)
        {
            return text == IntFilter(text);
        }

        /// <summary>
        /// Filtra el texto proporcionado a sólo caracteres númericos y decimales
        /// </summary>
        /// <param name="text">Texto a filtrar</param>
        /// <returns>Una cadena <see langword="string"/> con sólo caracteres numéricos y decimales</returns>
        public static string FloatFilter(string text)
        {
            string result = string.Empty;
            bool isNegative = false;
            bool hasDecimal = false;

            foreach (char chr in text)
            {
                if (chr >= 48 && chr <= 57)
                {
                    result += chr;
                }
                else if (chr == 46 && !hasDecimal)
                {
                    result += chr;
                    hasDecimal = true;
                }
                else if (chr == 45 && !isNegative)
                {
                    result += chr;
                    isNegative = true;
                }
            }

            return result;
        }

        /// <summary>
        /// Determina si el texto proporcionado es equivalente a su versión filtrada
        /// </summary>
        /// <param name="text">Texto</param>
        /// <returns><see langword="true"/> si el válido, <see langword="false"/> si no</returns>
        public static bool IsValidFloatText(string text)
        {
            return text == FloatFilter(text);
        }

        /// <summary>
        /// Filtra el texto proporcionados a sólo caracteres permitidos en una contraseña
        /// </summary>
        /// <param name="text">Texto a filtrar</param>
        /// <returns>Una cadena <see langword="string"/> con sólo caracteres permitidos en una contraseña</returns>
        public static string PasswordFilter(string text)
        {
            string result = string.Empty;

            char[] specialChars = new char[]
            {
                '#', '$', '%', '&', '*', '+', '-', '.', '_'
            };

            foreach (char chr in text)
            {
                if (specialChars.Contains(chr))
                {
                    result += chr;
                }
                else if (chr >= 48 && chr <= 57)
                {
                    result += chr;
                }
                else if ((chr >= 65 && chr <= 90) || (chr >= 97 && chr <= 122))
                {
                    result += chr;
                }
            }

            return result;
        }

        /// <summary>
        /// Determina si el texto proporcionado es equivalente a su versión filtrada
        /// </summary>
        /// <param name="text">Texto</param>
        /// <returns><see langword="true"/> si el válido, <see langword="false"/> si no</returns>
        public static bool IsValidPasswordText(string text)
        {
            return text == PasswordFilter(text);
        }
    }
}
