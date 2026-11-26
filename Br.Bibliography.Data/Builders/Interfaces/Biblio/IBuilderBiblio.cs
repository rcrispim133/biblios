using Br.Bibliography.Core.Constants.Impl.Biblio;
using Br.Bibliography.Data.Builders.Base;
using Br.Bibliography.Data.Builders.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Biblio;

namespace Br.Bibliography.Data.Builders.Interfaces.Biblio
{
    public interface IBuilderBiblio<TBuilder> : 
        IBuilderBase<TBuilder, EntityBiblio, ConstantBiblio> 
            where TBuilder : class, IBuilder<TBuilder, EntityBiblio, ConstantBiblio>, new()
    {
    }
}
