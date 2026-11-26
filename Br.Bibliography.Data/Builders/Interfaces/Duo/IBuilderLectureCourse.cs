using Br.Bibliography.Core.Constants.Impl.Duo;
using Br.Bibliography.Data.Builders.Base;
using Br.Bibliography.Data.Builders.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Duo;

namespace Br.Bibliography.Data.Builders.Interfaces.Duo
{
    public interface IBuilderLectureCourse<TBuilder> : 
        IBuilderBase<TBuilder, EntityLectureCourse, ConstantLectureCourse> 
            where TBuilder : class, IBuilder<TBuilder, EntityLectureCourse, ConstantLectureCourse>, new()
    {
    }
}
