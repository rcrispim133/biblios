using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Core.Constants.Base.Interfaces
{
    public interface IConstantRaw<TEntity> : IConstantText<TEntity> where TEntity : class, IEntityRaw<TEntity>, new()
    {
        #region Defaults

        const int DefaultMaxRaw = 1024 * 1024 * 1024;

        #endregion

        #region Constants

        int ConstantMaxRaw { get; }

        #endregion
    }
}
