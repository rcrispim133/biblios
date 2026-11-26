using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Core.Constants.Base.Interfaces
{
    public interface IConstantText<TEntity> : IConstantBase<TEntity> where TEntity : class, IEntityBase<TEntity> , new()
    {
        #region Defaults

        const int DefaultMaxText = 144;

        #endregion

        #region Constants

        int ConstantMaxText { get; }

        #endregion
    }
}
