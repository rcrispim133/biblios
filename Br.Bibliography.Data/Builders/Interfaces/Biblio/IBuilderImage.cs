using Br.Bibliography.Data.Builders.Base;
using Br.Bibliography.Data.Builders.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Biblio;

namespace Br.Bibliography.Data.Builders.Interfaces.Biblio
{
    public interface IBuilderImage<TBuilder> : IBuilderText<TBuilder, EntityImage> where TBuilder : class, IBuilder<TBuilder, EntityImage>, new()
    {
    }
}
