using Br.Bibliography.Data.Builders.Base;
using Br.Bibliography.Data.Builders.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Series;

namespace Br.Bibliography.Data.Builders.Interfaces.Series
{
    public interface IBuilderCycle<TBuilder> : 
        IBuilderText<TBuilder, EntityCycle> 
            where TBuilder : class, IBuilder<TBuilder, EntityCycle>, new()
    {
    }
}
