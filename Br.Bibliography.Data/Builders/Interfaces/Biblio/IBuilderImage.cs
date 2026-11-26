using Br.Bibliography.Core.Constants.Impl.Biblio;
using Br.Bibliography.Data.Builders.Base;
using Br.Bibliography.Data.Builders.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Biblio;

namespace Br.Bibliography.Data.Builders.Interfaces.Biblio
{
    public interface IBuilderImage<TBuilder> : 
        IBuilderText<TBuilder, EntityImage, ConstantImage> 
            where TBuilder : class, IBuilder<TBuilder, EntityImage, ConstantImage>, new()
    {
    }
}
