using Br.Bibliography.Core.Constants.Interfaces.Identity;
using Br.Bibliography.Data.Builders.Base;
using Br.Bibliography.Data.Builders.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Identity;

namespace Br.Bibliography.Data.Builders.Interfaces.Identity
{
    public interface IBuilderUser<TBuilder> : 
        IBuilderBase<TBuilder, EntityUser, IConstantUser> 
            where TBuilder : class, IBuilder<TBuilder, EntityUser, IConstantUser>, new()
    {
    }
}
