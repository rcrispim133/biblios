using Br.Bibliography.Core.Constants.Interfaces.Duo;
using Br.Bibliography.Data.Builders.Base;
using Br.Bibliography.Data.Builders.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Duo;

namespace Br.Bibliography.Data.Builders.Interfaces.Duo
{
    public interface IBuilderBiblioAuthor<TBuilder> : 
        IBuilderBase<TBuilder, EntityBiblioAuthor, IConstantBiblioAuthor> 
            where TBuilder : class, IBuilder<TBuilder, EntityBiblioAuthor, IConstantBiblioAuthor>, new()
    {
    }
}
