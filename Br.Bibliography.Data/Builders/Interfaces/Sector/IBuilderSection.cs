using Br.Bibliography.Data.Builders.Base;
using Br.Bibliography.Data.Builders.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Sector;

namespace Br.Bibliography.Data.Builders.Interfaces.Sector
{
    public interface IBuilderSection<TBuilder> : 
        IBuilderBase<TBuilder, EntitySection> 
            where TBuilder : class, IBuilder<TBuilder, EntitySection>, new()
    {
    }
}
