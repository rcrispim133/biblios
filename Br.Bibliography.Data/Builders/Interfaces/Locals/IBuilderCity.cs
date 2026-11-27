using Br.Bibliography.Data.Builders.Base;
using Br.Bibliography.Data.Builders.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Locals;

namespace Br.Bibliography.Data.Builders.Interfaces.Locals
{
    public interface IBuilderCity<TBuilder> : 
        IBuilderText<TBuilder, EntityCity> 
            where TBuilder : class, IBuilder<TBuilder, EntityCity>, new()
    {
    }
}
