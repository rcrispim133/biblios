using Br.Bibliography.Core.Constants.Interfaces.Sector;
using Br.Bibliography.Data.Builders.Base;
using Br.Bibliography.Model.Entities.Impl.Sector;

namespace Br.Bibliography.Data.Builders.Interfaces.Sector
{
    public interface IBuilderLine<TBuilder> : 
        Base.Interfaces.IBuilderLine<TBuilder, EntityLine, IConstantLine> 
            where TBuilder : class, IBuilder<TBuilder, EntityLine, IConstantLine>, new()
    {
    }
}
