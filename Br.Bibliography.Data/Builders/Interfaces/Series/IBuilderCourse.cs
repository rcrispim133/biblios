using Br.Bibliography.Core.Constants.Interfaces.Series;
using Br.Bibliography.Data.Builders.Base;
using Br.Bibliography.Data.Builders.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Series;

namespace Br.Bibliography.Data.Builders.Interfaces.Series
{
    public interface IBuilderCourse<TBuilder> : 
        IBuilderAcronymDesc<TBuilder, EntityCourse, IConstantCourse> 
            where TBuilder : class, IBuilder<TBuilder, EntityCourse, IConstantCourse>, new()
    {
    }
}
