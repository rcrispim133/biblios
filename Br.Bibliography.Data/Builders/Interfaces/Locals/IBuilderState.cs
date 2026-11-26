using Br.Bibliography.Core.Constants.Impl.Locals;
using Br.Bibliography.Data.Builders.Base;
using Br.Bibliography.Data.Builders.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Locals;

namespace Br.Bibliography.Data.Builders.Interfaces.Locals
{
    public interface IBuilderState<TBuilder> : 
        IBuilderText<TBuilder, EntityState, ConstantState> 
            where TBuilder : class, IBuilder<TBuilder, EntityState, ConstantState>, new()
    {
    }
}
