using Br.Bibliography.Core.Constants.Impl.Locals;
using Br.Bibliography.Data.Builders.Base;
using Br.Bibliography.Data.Builders.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Locals;

namespace Br.Bibliography.Data.Builders.Interfaces.Locals
{
    public interface IBuilderCountry<TBuilder> : 
        IBuilderText<TBuilder, EntityCountry, ConstantCountry> 
            where TBuilder : class, IBuilder<TBuilder, EntityCountry, ConstantCountry>, new()
    {
    }
}
