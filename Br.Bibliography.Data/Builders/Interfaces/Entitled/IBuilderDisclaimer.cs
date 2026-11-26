using Br.Bibliography.Core.Constants.Interfaces.Entitled;
using Br.Bibliography.Data.Builders.Base;
using Br.Bibliography.Data.Builders.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Entitled;

namespace Br.Bibliography.Data.Builders.Interfaces.Entitled
{
    public interface IBuilderDisclaimer<TBuilder> : 
        IBuilderDesc<TBuilder, EntityDisclaimer, IConstantDisclaimer> 
            where TBuilder : class, IBuilder<TBuilder, EntityDisclaimer, IConstantDisclaimer>, new()
    {
    }
}
