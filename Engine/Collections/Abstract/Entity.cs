namespace OCESACNA.Engine.Collections.Abstract
{
    /// <summary>
    /// Clase abstracta <c>Entity</c> de la cual derivan las entidades
    /// </summary>
    public abstract class Entity
    {
        /// <summary>
        /// Valor m�ximo al que los IDs de las entidades pueden llegar
        /// </summary>
        public const int MaxID = 999999999;

        /// <summary>
        /// Determina si un ID es v�lido dentro del contexto de las entidades
        /// </summary>
        /// <param name="id">ID a comprobar</param>
        /// <returns><c>True</c> si es v�lido, de lo contrario <c>False</c></returns>
        public bool IsValidID(int id)
        {
            if (id > MaxID || id < 0)
            {
                return false;
            }
            return true;
        }
    }
}