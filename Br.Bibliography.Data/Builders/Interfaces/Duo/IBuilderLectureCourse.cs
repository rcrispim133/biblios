using Br.Bibliography.Data.Builders.Base;
using Br.Bibliography.Data.Builders.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Duo;

namespace Br.Bibliography.Data.Builders.Interfaces.Duo
{
    public interface IBuilderLectureCourse<TBuilder> : IBuilderBase<TBuilder, EntityLectureCourse> where TBuilder : class, IBuilder<TBuilder, EntityLectureCourse>, new()
    {
    }
}
