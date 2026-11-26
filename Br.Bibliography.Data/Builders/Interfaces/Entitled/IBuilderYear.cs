using Br.Bibliography.Core.Constants.Impl.Entitled;
using Br.Bibliography.Data.Builders.Base;
using Br.Bibliography.Data.Builders.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Entitled;

namespace Br.Bibliography.Data.Builders.Interfaces.Entitled
{
    public interface IBuilderYear<TBuilder> : 
        IBuilderBase<TBuilder, EntityYear, ConstantYear> 
            where TBuilder : class, IBuilder<TBuilder, EntityYear, ConstantYear>, new()
    {
    }
}
