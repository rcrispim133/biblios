using Br.Bibliography.Core.Constants.Base.Interfaces;
using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Core.Constants.Base.Impl
{
    public abstract class ConstantAcronym<TEntity> : ConstantText<TEntity>, IConstantAcronym<TEntity> 
        where TEntity : class, IEntityAcronym<TEntity>, new()
    {
        #region Acronym

        public abstract int ConstantMaxAcronym { get; }

        #endregion
    }
}
