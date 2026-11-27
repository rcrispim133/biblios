using Br.Bibliography.Data.Builders.Base;
using Br.Bibliography.Model.Entities.Impl.Sector;

namespace Br.Bibliography.Data.Builders.Interfaces.Sector
{
    public interface IBuilderLine<TBuilder> : 
        Base.Interfaces.IBuilderLine<TBuilder, EntityLine> 
            where TBuilder : class, IBuilder<TBuilder, EntityLine>, new()
    {
    }
}
