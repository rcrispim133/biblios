using Br.Bibliography.Data.Builders.Base;
using Br.Bibliography.Data.Builders.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Alumni;

namespace Br.Bibliography.Data.Builders.Interfaces.Alumni
{
    public interface IBuilderWork<TBuilder> : 
        IBuilderText<TBuilder, EntityWork> 
            where TBuilder : class, IBuilder<TBuilder, EntityWork>, new()
    {
    }
}
