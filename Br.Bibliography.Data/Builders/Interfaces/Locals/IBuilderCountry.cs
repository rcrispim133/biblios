using Br.Bibliography.Core.Constants.Interfaces.Locals;
using Br.Bibliography.Data.Builders.Base;
using Br.Bibliography.Data.Builders.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Locals;

namespace Br.Bibliography.Data.Builders.Interfaces.Locals
{
    public interface IBuilderCountry<TBuilder> : 
        IBuilderText<TBuilder, EntityCountry, IConstantCountry> 
            where TBuilder : class, IBuilder<TBuilder, EntityCountry, IConstantCountry>, new()
    {
    }
}
