using Br.Bibliography.Core.Constants.Impl.Alumni;
using Br.Bibliography.Data.Builders.Base;
using Br.Bibliography.Data.Builders.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Alumni;

namespace Br.Bibliography.Data.Builders.Interfaces.Alumni
{
    public interface IBuilderCredit<TBuilder> : 
        IBuilderText<TBuilder, EntityCredit, ConstantCredit> 
            where TBuilder : class, IBuilder<TBuilder, EntityCredit, ConstantCredit>, new()
    {
    }
}
