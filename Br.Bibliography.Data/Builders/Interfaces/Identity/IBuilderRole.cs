using Br.Bibliography.Data.Builders.Base;
using Br.Bibliography.Data.Builders.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Identity;

namespace Br.Bibliography.Data.Builders.Interfaces.Identity
{
    public interface IBuilderRole<TBuilder> : IBuilderBase<TBuilder, EntityRole> where TBuilder : class, IBuilder<TBuilder, EntityRole>, new()
    {
    }
}
