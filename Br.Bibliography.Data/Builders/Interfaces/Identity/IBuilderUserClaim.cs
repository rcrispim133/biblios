using Br.Bibliography.Core.Constants.Impl.Identity;
using Br.Bibliography.Data.Builders.Base;
using Br.Bibliography.Data.Builders.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Identity;

namespace Br.Bibliography.Data.Builders.Interfaces.Identity
{
    public interface IBuilderUserClaim<TBuilder> : 
        IBuilderBase<TBuilder, EntityUserClaim, ConstantUserClaim> 
            where TBuilder : class, IBuilder<TBuilder, EntityUserClaim, ConstantUserClaim>, new()
    {
    }
}
