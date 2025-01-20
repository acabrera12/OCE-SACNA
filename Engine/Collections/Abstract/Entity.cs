namespace OCESACNA.Engine.Collections.Abstract
{
    /// <summary>
    /// Clase abstracta <see cref="Entity"/> de la cual derivan las entidades
    /// </summary>
    public abstract class Entity
    {
        /// <summary>
        /// Valor máximo al que los IDs de las entidades pueden llegar
        /// </summary>
        public const int MaxID = 999999999;

        /// <summary>
        /// Determina si un ID es válido dentro del contexto de las entidades
        /// </summary>
        /// <param name="id">ID a comprobar</param>
        /// <returns><see langword="true"/> si es válido, de lo contrario <see langword="false"/></returns>
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