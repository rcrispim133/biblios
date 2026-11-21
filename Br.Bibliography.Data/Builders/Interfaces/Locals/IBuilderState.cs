using Br.Bibliography.Data.Builders.Base;
using Br.Bibliography.Data.Builders.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Locals;

namespace Br.Bibliography.Data.Builders.Interfaces.Locals
{
    public interface IBuilderState<TBuilder> : IBuilderText<TBuilder, EntityState> where TBuilder : class, IBuilder<TBuilder, EntityState>, new()
    {
    }
}
