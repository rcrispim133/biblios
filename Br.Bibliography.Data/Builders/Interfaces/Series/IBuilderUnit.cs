using Br.Bibliography.Data.Builders.Base;
using Br.Bibliography.Data.Builders.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Series;

namespace Br.Bibliography.Data.Builders.Interfaces.Series
{
    public interface IBuilderUnit<TBuilder> : 
        IBuilderAcronym<TBuilder, EntityUnit> 
            where TBuilder : class, IBuilder<TBuilder, EntityUnit>, new()
    {
    }
}
