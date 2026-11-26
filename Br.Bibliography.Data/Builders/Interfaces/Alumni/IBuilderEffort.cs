using Br.Bibliography.Core.Constants.Interfaces.Alumni;
using Br.Bibliography.Data.Builders.Base;
using Br.Bibliography.Data.Builders.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Alumni;

namespace Br.Bibliography.Data.Builders.Interfaces.Alumni
{
    public interface IBuilderEffort<TBuilder> : 
        IBuilderText<TBuilder, EntityEffort, IConstantEffort> 
            where TBuilder : class, IBuilder<TBuilder, EntityEffort, IConstantEffort>, new()
    {
    }
}
