using Br.Bibliography.Data.Builders.Base;
using Br.Bibliography.Data.Builders.Base.Interfaces;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Br.Bibliography.Model.Entities.Interfaces.Duo;

namespace Br.Bibliography.Data.Builders.Interfaces.Duo
{
    public interface IBuilderLectureTeacher<TBuilder> : IBuilderBase<TBuilder, EntityLectureTeacher> where TBuilder : class, IBuilder<TBuilder, EntityLectureTeacher>, new()
    {
    }
}
