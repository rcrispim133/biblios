using Br.Bibliography.Core.Constants.Impl.Sector;
using Br.Bibliography.Data.Builders.Base;
using Br.Bibliography.Data.Builders.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Sector;

namespace Br.Bibliography.Data.Builders.Interfaces.Sector
{
    public interface IBuilderLine<TBuilder> : 
        IBuilderLine<TBuilder, EntityLine, ConstantLine> 
            where TBuilder : class, IBuilder<TBuilder, EntityLine, ConstantLine>, new()
    {
    }
}
