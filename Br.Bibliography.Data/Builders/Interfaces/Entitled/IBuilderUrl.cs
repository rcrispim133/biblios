using Br.Bibliography.Data.Builders.Base;
using Br.Bibliography.Data.Builders.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Entitled;

namespace Br.Bibliography.Data.Builders.Interfaces.Entitled
{
    public interface IBuilderUrl<TBuilder> : 
        IBuilderText<TBuilder, EntityUrl> 
            where TBuilder : class, IBuilder<TBuilder, EntityUrl>, new()
    {
    }
}
