using Br.Bibliography.Core.Constants.Impl.Identity;
using Br.Bibliography.Data.Builders.Base;
using Br.Bibliography.Data.Builders.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Identity;

namespace Br.Bibliography.Data.Builders.Interfaces.Identity
{
    public interface IBuilderRole<TBuilder> : 
        IBuilderBase<TBuilder, EntityRole, ConstantRole> 
            where TBuilder : class, IBuilder<TBuilder, EntityRole, ConstantRole>, new()
    {
    }
}
