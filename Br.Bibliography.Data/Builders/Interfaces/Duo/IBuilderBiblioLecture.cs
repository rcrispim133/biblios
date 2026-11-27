using Br.Bibliography.Data.Builders.Base;
using Br.Bibliography.Data.Builders.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Duo;

namespace Br.Bibliography.Data.Builders.Interfaces.Duo
{
    public interface IBuilderBiblioLecture<TBuilder> : 
        IBuilderBase<TBuilder, EntityBiblioLecture> 
            where TBuilder : class, IBuilder<TBuilder, EntityBiblioLecture>, new()
    {
    }
}
