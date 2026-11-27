using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Core.Constants.Base.Interfaces
{
    public interface IConstantRaw<TEntity> : IConstantText<TEntity> where TEntity : class, IEntityRaw<TEntity>, new()
    {
        #region Defaults

        int DefaultMaxRaw { get; }

        #endregion
    }
}
