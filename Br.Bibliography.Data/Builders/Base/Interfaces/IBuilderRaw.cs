using Br.Bibliography.Core.Constants.Base.Interfaces;
using Br.Bibliography.Model.Entities.Base.Interfaces;

namespace Br.Bibliography.Data.Builders.Base.Interfaces
{
    public interface IBuilderRaw<TBuilder, TEntity, TConstant> :
        IBuilderText<TBuilder, TEntity, TConstant>
            where TBuilder : class, IBuilder<TBuilder, TEntity, TConstant>, new()
            where TEntity : class, IEntityRaw<TEntity>, new()
            where TConstant : class, IConstantRaw<TEntity>
    {
    }
}
