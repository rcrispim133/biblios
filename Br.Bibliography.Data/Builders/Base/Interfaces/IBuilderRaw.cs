using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Data.Builders.Base.Interfaces
{
    public interface IBuilderRaw<TBuilder, TEntity> : IBuilderText<TBuilder, TEntity> where TBuilder : class, IBuilder<TBuilder, TEntity>, new() where TEntity : class, IEntityRaw<TEntity>
    {
    }
}
