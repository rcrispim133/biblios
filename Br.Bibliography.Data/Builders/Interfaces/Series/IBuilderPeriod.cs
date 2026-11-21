using Br.Bibliography.Data.Builders.Base;
using Br.Bibliography.Data.Builders.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Series;

namespace Br.Bibliography.Data.Builders.Interfaces.Series
{
    public interface IBuilderPeriod<TBuilder> : IBuilderText<TBuilder, EntityPeriod> where TBuilder : class, IBuilder<TBuilder, EntityPeriod>, new()
    {
    }
}
