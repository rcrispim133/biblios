using Br.Bibliography.Core.Constants.Interfaces.Biblio;
using Br.Bibliography.Data.Builders.Base;
using Br.Bibliography.Data.Builders.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Biblio;

namespace Br.Bibliography.Data.Builders.Interfaces.Biblio
{
    public interface IBuilderAuthor<TBuilder> : 
        IBuilderAcronym<TBuilder, EntityAuthor, IConstantAuthor> 
            where TBuilder : class, IBuilder<TBuilder, EntityAuthor, IConstantAuthor>, new()
    {
    }
}
