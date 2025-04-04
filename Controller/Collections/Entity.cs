using System.Linq;
namespace OCESACNA.Controller
{
    /// <summary>
    /// Representa una entidad
    /// </summary>
    public abstract class Entity
    {
        /// <summary>
        /// Máximo ID posible
        /// </summary>
        public const int MaxID = 999999999;

        /// <summary>
        /// Determina si un ID es válido
        /// </summary>
        /// <param name="ID">ID</param>
        /// <returns><see langword="true"/> si es válido, <see langword="false"/> si no</returns>
        public static bool IsValidID(int ID) => ID >= 0 && ID <= MaxID;
        /*{
            if (ID < 0 || ID > MaxID)
            {
                return false;
            }
            return true;
        }*/

        /// <summary>
        /// Calcula el prodio de un conjunto de números
        /// </summary>
        /// <param name="values">Números</param>
        /// <returns>Un número <see langword="double"/> resultante del cálculo</returns>
        public static double Average(double[] values)
        {
            double result = 0;

            if (values.Count() == 0)
            {
                return result;
            }

            result = values.Sum() / values.Count();

            return result;
        }
    }
}
