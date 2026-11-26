using Br.Bibliography.Core.Constants.Interfaces.Entitled;
using Br.Bibliography.Data.Builders.Base;
using Br.Bibliography.Data.Builders.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Entitled;

namespace Br.Bibliography.Data.Builders.Interfaces.Entitled
{
    public interface IBuilderYear<TBuilder> : 
        IBuilderBase<TBuilder, EntityYear, IConstantYear> 
            where TBuilder : class, IBuilder<TBuilder, EntityYear, IConstantYear>, new()
    {
    }
}
