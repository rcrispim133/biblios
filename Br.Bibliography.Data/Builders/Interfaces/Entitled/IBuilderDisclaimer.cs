using Br.Bibliography.Core.Constants.Impl.Entitled;
using Br.Bibliography.Data.Builders.Base;
using Br.Bibliography.Data.Builders.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Entitled;

namespace Br.Bibliography.Data.Builders.Interfaces.Entitled
{
    public interface IBuilderDisclaimer<TBuilder> : 
        IBuilderDesc<TBuilder, EntityDisclaimer, ConstantDisclaimer> 
            where TBuilder : class, IBuilder<TBuilder, EntityDisclaimer, ConstantDisclaimer>, new()
    {
    }
}
