using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Core.Constants.Base.Interfaces
{
    public interface IConstantDesc<TEntity> : IConstantBase<TEntity> where TEntity : class, IEntityDesc<TEntity>, new()
    {
        #region Defaults

        const uint DefaultMaxDesc = 500;

        #endregion

        #region Constants

        uint ConstantMaxDesc { get; }

        #endregion
    }
}
