using Br.Bibliography.Core.Constants.Impl.Entitled;
using Br.Bibliography.Data.Builders.Base;
using Br.Bibliography.Data.Builders.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Entitled;

namespace Br.Bibliography.Data.Builders.Interfaces.Entitled
{
    public interface IBuilderTitle<TBuilder> : 
        IBuilderText<TBuilder, EntityTitle, ConstantTitle> 
            where TBuilder : class, IBuilder<TBuilder, EntityTitle, ConstantTitle>, new()
    {
    }
}
