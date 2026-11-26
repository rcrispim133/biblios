using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Core.Constants.Base.Interfaces
{
    public interface IConstantAcronym<TEntity> : IConstantText<TEntity> where TEntity : class, IEntityAcronym<TEntity>, new()
    {
        #region Defaults

        const uint DefaultMaxAcronym = 24;

        #endregion

        #region Constants

        uint ConstantMaxAcronym { get; }

        #endregion
    }
}
